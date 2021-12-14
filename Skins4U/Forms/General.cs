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
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
        }
        
        private void General_Load(object sender, EventArgs e)
        {
            try
            {
                //Instanciaciones
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

                ////Entradas de datos de los builder
                //builder.Server = "norgron.com.mx";
                //builder.Database = "norgronc_Skins4U_LAN";
                //builder.UserID = "norgronc_Skins4U";
                //builder.Password = "RAnECohX59J9";
                //builder.Port = 3306;

                //Entradas de datos de los builder
                builder.Server = "localhost";
                builder.Database = "pagos";
                builder.UserID = "root";
                builder.Password = "123";

                var conexion = new MySqlConnection(builder.ToString());
                conexion.Open();

                //Comando de la sentencia SQL
                var command_cuentas = new MySqlCommand("SELECT Nick, Saldo, Estado, Usuario, Contraseña FROM Cuentas", conexion);
                var command_pagos = new MySqlCommand("SELECT ID, Producto, PrecioRP, PrecioMXN, Comprador, Invocador, Plataforma, Estado, Fecha_entrega, Vendedor FROM Pagos", conexion);

                //Lector que captura el query
                //var reader = command.ExecuteReader();
                //while (reader.Read())
                //{
                //    //Imprime los valores de la tabla
                //    txtPrueba.Text += $"{reader.GetString(0)}" + " " + $"{reader.GetInt32(1)}" + "\r\n";
                //}
                //reader.Close();

                //Adaptación al datagrid de cuentas
                MySqlDataAdapter adapter_cuentas = new MySqlDataAdapter();
                adapter_cuentas.SelectCommand = command_cuentas;
                //Adaptación de tablas
                DataTable cuentas = new DataTable();
                adapter_cuentas.Fill(cuentas);
                DGvCuentas.DataSource = cuentas;

                //Adaptación al datagrid de pagos
                MySqlDataAdapter adapter_pagos = new MySqlDataAdapter();
                adapter_pagos.SelectCommand = command_pagos;
                //Adaptación de tablas
                DataTable pagos = new DataTable();
                adapter_pagos.Fill(pagos);
                dGVPagos.DataSource = pagos;
                conexion.Close();
            }
            catch (Exception)
            {
                lblExeption.ForeColor = Color.Red;
                lblExeption.Text = "No se pudo conectar a la base de datos";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                //Instanciaciones
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

                ////Entradas de datos de los builder
                //builder.Server = "norgron.com.mx";
                //builder.Database = "norgronc_Skins4U_LAN";
                //builder.UserID = "norgronc_Skins4U";
                //builder.Password = "RAnECohX59J9";
                //builder.Port = 3306;

                //Entradas de datos de los builder
                builder.Server = "localhost";
                builder.Database = "pagos";
                builder.UserID = "root";
                builder.Password = "123";

                var conexion = new MySqlConnection(builder.ToString());
                conexion.Open();

                //Comando de la sentencia SQL
                var command_cuentas = new MySqlCommand("SELECT Nick, Saldo, Estado, Usuario, Contraseña FROM Cuentas", conexion);
                var command_pagos = new MySqlCommand("SELECT ID, Producto, PrecioRP, PrecioMXN, Comprador, Invocador, Plataforma, Estado, Fecha_entrega, Vendedor FROM Pagos", conexion);

                //Adaptación al datagrid de cuentas
                MySqlDataAdapter adaptercuentas = new MySqlDataAdapter();
                adaptercuentas.SelectCommand = command_cuentas;
                //Adaptación de tablas
                DataTable cuentas = new DataTable();
                adaptercuentas.Fill(cuentas);
                DGvCuentas.DataSource = cuentas;

                //Adaptación al datagrid de pagos
                MySqlDataAdapter adapter_pagos = new MySqlDataAdapter();
                adapter_pagos.SelectCommand = command_pagos;
                //Adaptación de tablas
                DataTable pagos = new DataTable();
                adapter_pagos.Fill(pagos);
                dGVPagos.DataSource = pagos;
                conexion.Close();
            }
            catch (Exception)
            {
                lblExeption.ForeColor = Color.Red;
                lblExeption.Text = "No se ha podido conectar con la base de datos";
            }
        }

        private void btnCuentas_Click(object sender, EventArgs e)
        {
            Manejo_cuentas manejo_Cuentas = new Manejo_cuentas();
            manejo_Cuentas.Show();
            this.Hide();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            Pagos pagos = new Pagos();
            pagos.Show();
            this.Hide();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Entregas entregas = new Entregas();
            entregas.Show();
            this.Hide();
        }
        
        private void btnReportes_Click(object sender, EventArgs e)
        {
            Reporte_de_bugs reporte = new Reporte_de_bugs();
            reporte.Show();
            this.Hide();
        }

        private void btnNotasdelParche_Click(object sender, EventArgs e)
        {

        }
    }
}