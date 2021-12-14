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
    public partial class Entregas : Form
    {
        public Entregas()
        {
            InitializeComponent();
        }

        private void Entregas_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                //Entradas de datos de los builder
                builder.Server = "norgron.com.mx";
                builder.Database = "norgronc_Skins4U_LAN";
                builder.UserID = "norgronc_Skins4U";
                builder.Password = "RAnECohX59J9";
                builder.Port = 3306;

                ////Entradas de datos de los builder
                //builder.Server = "localhost";
                //builder.Database = "pagos";
                //builder.UserID = "root";
                //builder.Password = "123";

                var conexion = new MySqlConnection(builder.ToString());
                conexion.Open();

                //Comando de la sentencia SQL -- Consu
                var consultasEn = new MySqlCommand("SELECT ID, Invocador, Fecha_entrega, Producto, Estado, PrecioRP, Vendedor FROM Pagos WHERE Estado='Entregado'", conexion);

                //Adaptación al datagrid de pagos
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = consultasEn;
                //Adaptación de tablas
                DataTable cuentas = new DataTable();
                adapter.Fill(cuentas);
                dGVEntregas.DataSource = cuentas;

                //Comando de la sentencia SQL -- Consu
                var consultasno = new MySqlCommand("SELECT ID, Invocador, Fecha_entrega, Producto, Estado, PrecioRP, Vendedor FROM Pagos WHERE Estado='No entregado'", conexion);

                //Adaptación al datagrid de pagos
                MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                adapter1.SelectCommand = consultasno;
                //Adaptación de tablas
                DataTable cuentas1 = new DataTable();
                adapter1.Fill(cuentas1);
                dGVNoEntregados.DataSource = cuentas1;
                conexion.Close();
            }
            catch (Exception)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "No se pudo conectar a la base de datos";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                //Entradas de datos de los builder
                builder.Server = "norgron.com.mx";
                builder.Database = "norgronc_Skins4U_LAN";
                builder.UserID = "norgronc_Skins4U";
                builder.Password = "RAnECohX59J9";
                builder.Port = 3306;

                ////Entradas de datos de los builder
                //builder.Server = "localhost";
                //builder.Database = "pagos";
                //builder.UserID = "root";
                //builder.Password = "123";

                var conexion = new MySqlConnection(builder.ToString());
                conexion.Open();

                //Comando de la sentencia SQL -- Consu
                var consultasEn = new MySqlCommand("SELECT ID, Invocador, Fecha_entrega, Producto, Estado, PrecioRP, Vendedor FROM Pagos WHERE Estado='Entregado'", conexion);

                //Adaptación al datagrid de pagos
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = consultasEn;
                //Adaptación de tablas
                DataTable cuentas = new DataTable();
                adapter.Fill(cuentas);
                dGVEntregas.DataSource = cuentas;

                //Comando de la sentencia SQL -- Consu
                var consultasno = new MySqlCommand("SELECT ID, Invocador, Fecha_entrega, Producto, Estado, PrecioRP, Vendedor FROM Pagos WHERE Estado='No entregado'", conexion);

                //Adaptación al datagrid de pagos
                MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                adapter1.SelectCommand = consultasno;
                //Adaptación de tablas
                DataTable cuentas1 = new DataTable();
                adapter1.Fill(cuentas1);
                dGVNoEntregados.DataSource = cuentas1;
                conexion.Close();
            }
            catch (Exception)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "No se pudo conectar a la base de datos";
            }
        }

        private void btnEntgregado_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                //Entradas de datos de los builder
                builder.Server = "norgron.com.mx";
                builder.Database = "norgronc_Skins4U_LAN";
                builder.UserID = "norgronc_Skins4U";
                builder.Password = "RAnECohX59J9";
                builder.Port = 3306;

                ////Entradas de datos de los builder
                //builder.Server = "localhost";
                //builder.Database = "pagos";
                //builder.UserID = "root";
                //builder.Password = "123";

                var conexion = new MySqlConnection(builder.ToString());
                conexion.Open();
                int ID = int.Parse(txtID.Text);
                var update = new MySqlCommand("UPDATE Pagos SET Estado='Entregado' WHERE ID='" + ID + "'", conexion);
                int comprobador = update.ExecuteNonQuery();

                if (comprobador > 0)
                    lblStatus.Text = "Se actualizó con éxito";
                else
                    lblStatus.Text = "No se pudo actualizar";
                //Comando de la sentencia SQL -- Consultas
                var consultas = new MySqlCommand("SELECT ID, Invocador, Fecha_entrega, Producto, Estado, PrecioRP, Vendedor FROM Pagos WHERE Estado='Entregado'", conexion);
                var consultasno = new MySqlCommand("SELECT ID, Invocador, Fecha_entrega, Producto, Estado, PrecioRP, Vendedor FROM Pagos WHERE Estado='No entregado'", conexion);
                //Adaptación al datagrid de entregados
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = consultas;
                //Adaptación de tablas
                DataTable cuentas = new DataTable();
                adapter.Fill(cuentas);
                dGVEntregas.DataSource = cuentas;

                //Adaptación al datagrid de no entregados
                MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                adapter1.SelectCommand = consultasno;
                //Adaptación de tablas
                DataTable cuentas1 = new DataTable();
                adapter1.Fill(cuentas1);
                dGVNoEntregados.DataSource = cuentas1;
                conexion.Close();
            }
            catch (Exception)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "No se pudo conectar a la base de datos";
            }
        }

        private void btnNOEntregado_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                //Entradas de datos de los builder
                builder.Server = "norgron.com.mx";
                builder.Database = "norgronc_Skins4U_LAN";
                builder.UserID = "norgronc_Skins4U";
                builder.Password = "RAnECohX59J9";
                builder.Port = 3306;

                ////Entradas de datos de los builder
                //builder.Server = "localhost";
                //builder.Database = "pagos";
                //builder.UserID = "root";
                //builder.Password = "123";

                var conexion = new MySqlConnection(builder.ToString());
                conexion.Open();
                int ID = int.Parse(txtID.Text);
                var update = new MySqlCommand("UPDATE Pagos SET Estado='No Entregado' WHERE ID='" + ID + "'", conexion);
                int comprobador = update.ExecuteNonQuery();

                if (comprobador > 0)
                    lblStatus.Text = "Se actualizó con éxito";
                else
                    lblStatus.Text = "No se pudo actualizar";
                //Comando de la sentencia SQL -- Consultas
                var consultas = new MySqlCommand("SELECT ID, Invocador, Fecha_entrega, Producto, Estado, PrecioRP, Vendedor FROM Pagos WHERE Estado='Entregado'", conexion);
                var consultasno = new MySqlCommand("SELECT ID, Invocador, Fecha_entrega, Producto, Estado, PrecioRP, Vendedor FROM Pagos WHERE Estado='No entregado'", conexion);
                //Adaptación al datagrid de entregados
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = consultas;
                //Adaptación de tablas
                DataTable cuentas = new DataTable();
                adapter.Fill(cuentas);
                dGVEntregas.DataSource = cuentas;
                
                //Adaptación al datagrid de no entregados
                MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                adapter1.SelectCommand = consultasno;
                //Adaptación de tablas
                DataTable cuentas1 = new DataTable();
                adapter1.Fill(cuentas1);
                dGVNoEntregados.DataSource = cuentas1;
                conexion.Close();
            }
            catch (Exception)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "No se pudo conectar a la base de datos";
            }
        }

        private void btnRegresa_Click(object sender, EventArgs e)
        {
            General general = new General();
            general.Show();
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
