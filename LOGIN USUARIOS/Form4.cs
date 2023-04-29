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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            contraseña.PasswordChar = '*';
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
                    MySqlCommand SelectCommand = new MySqlCommand("select * from sistema_monitoreo.usuario where idalumno= '" + this.usuario.Text + "'and contraseña= '" + this.contraseña.Text + "';", myConn);
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
                        Form5 f5 = new Form5();
                        f5.ShowDialog();
                        f5 = null;
                        usuario.Text = "";
                        contraseña.Text = "";
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuario y contraseña incorrectas");
                    }
                    myConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

        }
    }
}
