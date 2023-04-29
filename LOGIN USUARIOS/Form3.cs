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
using System.Data.SqlClient;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace LOGIN_USUARIOS
{
    public partial class Form3 : Form
    {
        int count = 0;
        public Form3()
        {
            InitializeComponent();
            timer1.Start();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string cs = "datasource=127.0.0.1;port=3306;username=root;password=2016";
            string Query = "update sistema_monitoreo.acceso set hora_salida='" + this.label1.Text + "' ; ";
            MySqlConnection conDB = new MySqlConnection(cs);
            MySqlCommand cmdDB = new MySqlCommand(Query, conDB);
            MySqlDataReader myReader;

            try
            {
                conDB.Open();
                myReader = cmdDB.ExecuteReader();
                while (myReader.Read())
                { }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
            //arduino
            serialPort1.Open();
            serialPort1.Write("0");
            serialPort1.Close();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.label1.Text = DateTime.Now.ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int milliseconds = 1000;
            Thread.Sleep(milliseconds);
            string cs = "datasource=127.0.0.1;port=3306;username=root;password=2016";
            string Query = "insert into sistema_monitoreo.acceso (hora_entrada) values( '" + this.label1.Text + "') ; ";
            MySqlConnection conDB = new MySqlConnection(cs);
            MySqlCommand cmdDB = new MySqlCommand(Query, conDB);
            MySqlDataReader myReader;

            try
            {
                conDB.Open();
                myReader = cmdDB.ExecuteReader();
                while (myReader.Read())
                { }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
            count++;
            serialPort1.Close();
            serialPort1.PortName = "com4"; //Cambia el Puerto 
            serialPort1.BaudRate = 9600;
            serialPort1.DataBits = 8;
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;
            serialPort1.Handshake = Handshake.None;
            serialPort1.Encoding = System.Text.Encoding.Default;

            serialPort1.Open();
            serialPort1.Write("1");
            serialPort1.Close();
         }
    }
}
