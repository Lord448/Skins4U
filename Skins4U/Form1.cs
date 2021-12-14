using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Skins4U
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nick = textBox4.Text;
            int Saldo = int.Parse(textBox1.Text);
            string Usuario = textBox2.Text;

            string query = "INSERT INTO Cuentas VALUES('"+Nick+"', '"+Saldo+"', 'Activo', '"+Usuario+"', 'Salerosa123')";
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro guardado");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
