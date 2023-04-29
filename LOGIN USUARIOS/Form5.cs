using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LOGIN_USUARIOS
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            load_table();
        }

        void load_table()
        {
            string cs = "datasource=127.0.0.1;port=3306;username=root;password=2016";
            MySqlConnection conDB = new MySqlConnection(cs);
            MySqlCommand cmdDB = new MySqlCommand("select idalumno,nombre,apellidos,carrera,semestre from sistema_monitoreo.usuario ;", conDB);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDB;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataview.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabla_Click(object sender, EventArgs e)
        {
            dataview.Visible = true;
            label1.Visible = true;
            chart1.Visible = false;
            label2.Visible = false;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            dataview.Visible = false;
            chart1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grafica_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
            label2.Visible = true;
            dataview.Visible = false;
            label1.Visible = false;

            string cs = "datasource=127.0.0.1;port=3306;username=root;password=2016";
            MySqlConnection conDB = new MySqlConnection(cs);
            MySqlCommand cmdDB = new MySqlCommand("select * from sistema_monitoreo.usuario ;", conDB);
            MySqlDataReader myReader;

            try 
            {
                conDB.Open();
                myReader = cmdDB.ExecuteReader();

                while(myReader.Read())
                {
                    this.chart1.Series["Series1"].Points.AddXY(myReader.GetString("carrera"),myReader.GetString("semestre"));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
