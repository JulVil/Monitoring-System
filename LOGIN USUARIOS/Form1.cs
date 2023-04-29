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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
    
        private void acceder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usuario.Text))
            {
                MessageBox.Show("Por favor escribe tu usuario");
            }
            else
                try
                {
                    string myConnection = "datasource=127.0.0.1;port=3306;username=root;password=2016";
                   
                    MySqlConnection myConn = new MySqlConnection(myConnection);
                    MySqlCommand SelectCommand = new MySqlCommand("select * from sistema_monitoreo.usuario where idalumno= '" + this.usuario.Text + "'and contraseña= '"+this.contraseña.Text+ "';", myConn);
                    string Query = "insert into sistema_monitoreo.acceso (hora_entrada, idalumno) values('" + this.label5.Text + "' , '" + this.usuario.Text + "') ; ";
                    MySqlDataReader myReader;
                    myConn.Open();
                    myReader = SelectCommand.ExecuteReader();
                    int count = 0;

                    while (myReader.Read())
                    {
                        count = count + 1;
                    }
                    if (count == 1)
                    {
                        MessageBox.Show("Usuario Aceptado");
                        this.Hide();
                        Form3 f3 = new Form3();
                        f3.ShowDialog();
                        f3 = null;
                        usuario.Text = "";
                        contraseña.Text = "";
                        Show();
                    }
                        else if (count > 1)
                    {
                        MessageBox.Show("Usuario Duplicado");
                    }
                    else
                    {
                        MessageBox.Show("Usuario y contraseña incorrectas o no existente por favor registrate");
                        usuario.Text = "";
                        contraseña.Text = "";
                    }
                    myConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }
        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
             private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.label5.Text = DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contraseña.PasswordChar = '*';
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            usuario.Text = "";
            contraseña.Text = "";
        }

        private void admin_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
            usuario.Text = "";
            contraseña.Text = "";            
        }
    }
}