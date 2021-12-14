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
    public partial class Manejo_cuentas : Form
    {
        
        public Manejo_cuentas()
        {
            InitializeComponent();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            General general = new General();
            general.Show();
            this.Hide();
        }

        private void Manejo_cuentas_Load(object sender, EventArgs e)
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
                var consultas = new MySqlCommand("SELECT Nick, Saldo, Estado, Usuario, Contraseña FROM Cuentas", conexion);

                //Adaptación al datagrid de pagos
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = consultas;
                //Adaptación de tablas
                DataTable cuentas = new DataTable();
                adapter.Fill(cuentas);
                dGVCuentas.DataSource = cuentas;
                conexion.Close();
            }
            catch (Exception)
            {
                lblExeption.ForeColor = Color.Red;
                lblExeption.Text = "No se pudo conectar con la base de datos";
            }
        }
        //-----------------------------------------------Botón aceptar de inserción-----------------------------------------------
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Advertencia advertencia = new Advertencia();
            lblExeption.ForeColor = Color.Red;
            if (txtNick.Text == "")
                lblExeption.Text = "Inserte un valor en la casilla de Vendedor";
            else if (txtSaldo.Text == "")
                lblExeption.Text = "Inserte un valor en la casilla de Saldo";
            else if (txtUsuario.Text == "")
                lblExeption.Text = "Inserte un valor en la casilla de Usuario";
            //else if (txtContra.Text == "")
            //    lblExeption.Text = "Inserte un valor en la casilla de Contraseña";
            else
            {
                advertencia.ShowDialog();

            }
            if (Advertencia.variables.comprobador == "aceptar" && Advertencia.variables.comprobador != null)
            {
                //Conexión LAN
                //Conexión NA
                //Conexión EUW
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                try
                {
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

                    //Sentencia SQL -- Inserción
                    string nick = txtNick.Text.ToString();
                    int Saldo = int.Parse(txtSaldo.Text.ToString());
                    string Usuario = txtUsuario.Text.ToString();
                    string Contraseña = "Salerosa123";
                    var insercion = new MySqlCommand("INSERT INTO Cuentas VALUES ('" + nick + "', '" + Saldo + "', 'Activo', '" + Usuario + "', '" + Contraseña + "')", conexion);
                    int comprobador = insercion.ExecuteNonQuery();

                    if (comprobador > 0)
                    {
                        lblExeption.ForeColor = Color.Green;
                        lblExeption.Text = "Se pudieron agregar los datos con éxito";
                    }

                    else
                    {
                        lblExeption.ForeColor = Color.Red;
                        lblExeption.Text = "No se pudieron agregar los datos";
                    }
                        

                    //Sentencia SQL -- Consulta
                    var consultas = new MySqlCommand("SELECT Nick, Saldo, Estado, Usuario, Contraseña FROM Cuentas", conexion);

                    //Adaptación al datagrid de pagos
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = consultas;
                    //Adaptación de tablas
                    DataTable cuentas = new DataTable();
                    adapter.Fill(cuentas);
                    dGVCuentas.DataSource = cuentas;

                    conexion.Close();

                    txtSaldo.Text = null;
                    txtNick.Text = null;
                }
                catch (Exception)
                {
                    lblExeption.ForeColor = Color.Red;
                    lblExeption.Text = "Error, no se ha podido insertar el vendedor";
                }
            }
            else
            {
                advertencia.Close();
            }
        }
        //-----------------------------------------------Botón aceptar de eliminación--------------------------------------------
        private void btnAceptar_Elim_Click(object sender, EventArgs e)
        {
            Advertencia advertencia = new Advertencia();
            if (txtNombre_elim.Text == "")
                lblExeption_elim.Text = "Inserte un valor en la casilla de vendedor";
            else
                advertencia.ShowDialog();

            if (Advertencia.variables.comprobador == "aceptar" && Advertencia.variables.comprobador != null)
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

                    string Nombre = txtNombre_elim.Text;
                    var conexion = new MySqlConnection(builder.ToString());
                    conexion.Open();
                    var update = new MySqlCommand("UPDATE Cuentas SET Estado='Inactivo' WHERE Nombre='" + Nombre + "'", conexion);
                    int comprobador = update.ExecuteNonQuery();

                    if (comprobador > 0)
                        lblExeption.Text = "Se pudieron agregar los datos con éxito";
                    else
                        lblExeption.Text = "No se pudieron agregar los datos";

                    //Sentencia SQL -- Consulta
                    var consultas = new MySqlCommand("SELECT Nick, Saldo, Estado FROM Cuentas", conexion);

                    //Adaptación al datagrid de pagos
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = consultas;
                    //Adaptación de tablas
                    DataTable cuentas = new DataTable();
                    adapter.Fill(cuentas);
                    dGVCuentas.DataSource = cuentas;

                    conexion.Close();

                    txtSaldo.Text = null;
                    txtNick.Text = null;
                }

                catch (Exception)
                {
                    lblExeption_elim.ForeColor = Color.Red;
                    lblExeption_elim.Text = "Error, no se ha podido desactivar el vendedor";
                }

            }
            else
            {
                advertencia.Close();
            }
        }
        //-----------------------------------------------Botón aceptar de refresh------------------------------------------
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

                //Comando de la sentencia SQL
                var command_cuentas = new MySqlCommand("SELECT Nick, Saldo, Estado, Usuario FROM Cuentas", conexion);
                int comprobador = command_cuentas.ExecuteNonQuery();
                //Adaptación al datagrid de cuentas
                MySqlDataAdapter adaptercuentas = new MySqlDataAdapter();
                adaptercuentas.SelectCommand = command_cuentas;
                //Adaptación de tablas
                DataTable cuentas = new DataTable();
                adaptercuentas.Fill(cuentas);
                dGVCuentas.DataSource = cuentas;
                conexion.Close();
            }
            catch (Exception)
            {
                lblExeption.ForeColor = Color.Red;
                lblExeption.Text = "No se pudo conectar con la base de datos";
            }
           
        }
    }
}
