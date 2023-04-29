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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            timer1.Start();
        }

        private void guardar_Click(object sender, EventArgs e)
        {       
            string cs = "datasource=127.0.0.1;port=3306;username=root;password=2016";
            string Query = "insert into sistema_monitoreo.usuario (idalumno,contraseña,nombre,apellidos,carrera,semestre) values( '" + this.idalumno.Text + "','" + this.contraseña.Text + "','" + this.nombre.Text + "','" + this.apellidos.Text + "','" + this.carrera.Text + "','" + this.semestre.Text + "') ; ";
            MySqlConnection conDB = new MySqlConnection(cs);
            MySqlCommand cmdDB = new MySqlCommand(Query, conDB);
            MySqlDataReader myReader;

            try 
            {
                conDB.Open();
                myReader = cmdDB.ExecuteReader();
                idalumno.Text = "";
                contraseña.Text = "";
                nombre.Text = "";
                apellidos.Text = "";
                carrera.Text = "";
                semestre.Text = "";
                MessageBox.Show("Datos Guardados Correctamente");
                while(myReader.Read())
                { }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.tiempo.Text = DateTime.Now.ToString();
        }

        private void editar_Click(object sender, EventArgs e)
        {
            string cs = "datasource=127.0.0.1;port=3306;username=root;password=2016";
            string Query = "update sistema_monitoreo.usuario set idalumno='" + this.idalumno.Text + "',contraseña='" + this.contraseña.Text + "',nombre='" + this.nombre.Text + "',apellidos='" + this.apellidos.Text + "',carrera='" + this.carrera.Text + "',semestre='" + this.semestre.Text + "' where idalumno='" + this.idalumno.Text + "' ; ";
            MySqlConnection conDB = new MySqlConnection(cs);
            MySqlCommand cmdDB = new MySqlCommand(Query, conDB);
            MySqlDataReader myReader;

            try
            {
                conDB.Open();
                myReader = cmdDB.ExecuteReader();
                idalumno.Text = "";
                contraseña.Text = "";
                nombre.Text = "";
                apellidos.Text = "";
                carrera.Text = "";
                semestre.Text = "";
                MessageBox.Show("Datos Editados Correctamente");
                while (myReader.Read())
                { }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            contraseña.PasswordChar = '*';
        }
    }
}
