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
    public partial class Pagos : Form
    {
        private void Pagos_Load(object sender, EventArgs e)
        {
            try
            {
                //Instanciaciones
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

                //Llenado de ComboBox
                var consulta_nombre = new MySqlCommand("SELECT Nick FROM Cuentas WHERE Estado='Activo'", conexion);
                MySqlDataReader registro = consulta_nombre.ExecuteReader();
                while (registro.Read())
                {
                    CbbCuentas.Items.Add(registro["Nick"].ToString());
                }

                conexion.Close();
            }
            catch (Exception)
            {
                lblEstados.ForeColor = Color.Red;
                lblEstados.Text = "No se pudo conectar con la base de datos";
            }
        }

        public Pagos()
        {
            InitializeComponent();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            //try
            //{
                lblEstados.ForeColor = Color.Red;
                Advertencia advertencia = new Advertencia();
                if (txtProducto.Text == "")
                    lblEstados.Text = "Inserte el producto a comprar";
                else if (txtPrecioRP.Text == "")
                    lblEstados.Text = "Inserte el precio en RP";
                else if (txtPrecioMXN.Text == "")
                    lblEstados.Text = "Inserte el precio en pesos mexicanos ";
                else if (txtComprador.Text == "")
                    lblEstados.Text = "Inserte el nombre del comprador ";
                else if (txtInvocador.Text == "")
                    lblEstados.Text = "Inserte el nombre del invocador ";
                else if (txtPlataforma.Text == "")
                    lblEstados.Text = "Inserte la plataforma";
                else if (txtFecha.Text == "")
                    lblEstados.Text = "Inserte la fecha de entrega";
                else if (CbbCuentas.Text == "")
                    lblEstados.Text = "Inserte la cuenta vendedora";
                else
                    advertencia.ShowDialog();
                if (Advertencia.variables.comprobador == "aceptar")
                {
                    //Instanciaciones
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

                    //----------------------------Selección de los ID------------------------
                    var consulta = new MySqlCommand("SELECT IFNULL(MAX(ID), 0) AS LASTID FROM Pagos", conexion);
                    int lastdid = Convert.ToInt32(consulta.ExecuteScalar());

                    int ID = lastdid + 1;
                    string Producto = txtProducto.Text;
                    int PrecioRP = int.Parse(txtPrecioRP.Text);
                    int PrecioMXN = int.Parse(txtPrecioMXN.Text);
                    string Comprador = txtComprador.Text;
                    string Invocador = txtInvocador.Text;
                    string vendedor = CbbCuentas.Text;
                    string plataforma = txtPlataforma.Text;
                    string fecha = txtFecha.Text;

                    //int IDinicial = Convert.ToInt32(consulta.ExecuteScalar());
                    //var contar = new MySqlCommand("SELECT COUNT(*) FROM pagos", conexion);
                    //contar.ExecuteNonQuery();
                    //------------------------------Consulta para pago----------------------------
                    var resta_pago = new MySqlCommand("SELECT Saldo FROM Cuentas WHERE Nick='" + vendedor + "'", conexion);
                    int saldo_pre = Convert.ToInt32(resta_pago.ExecuteScalar());
                    int saldo_post;
                    if (saldo_pre > PrecioRP)
                    {
                        //-------------------------Inserción de los datos-------------------------------
                        var insercion = new MySqlCommand("INSERT INTO Pagos VALUES ('" + ID + "', '" + Producto + "', '" + PrecioRP + "', '" + PrecioMXN + "', '" + Comprador + "', '" + Invocador + "', '" + plataforma + "', 'No entregado', '" + fecha + "', '" + vendedor + "')", conexion);
                        int comprobador = insercion.ExecuteNonQuery();
                        saldo_post = saldo_pre - PrecioRP;
                        if (comprobador > 0)
                        {
                            lblEstados.ForeColor = Color.Green;
                            lblEstados.Text = "Se añadío el pedido con éxito saldo actual: " + saldo_post;
                        }
                        else
                        {
                            lblEstados.ForeColor = Color.Red;
                            lblEstados.Text = "No se pudo añadir el pedido";
                        }

                        var update = new MySqlCommand("UPDATE Cuentas SET Saldo='" + saldo_post + "' WHERE Nick='" + vendedor + "'", conexion);
                        update.ExecuteNonQuery();
                    }
                    else if (saldo_pre == PrecioRP)
                    {
                        //-------------------------Inserción de los datos-------------------------------
                        var insercion = new MySqlCommand("INSERT INTO Pagos VALUES ('" + ID + "', '" + Producto + "', '" + PrecioRP + "', '" + PrecioMXN + "', '" + Comprador + "', '" + Invocador + "', '" + plataforma + "', 'No entregado', '" + fecha + "', '" + vendedor + "')", conexion);
                        int comprobador = insercion.ExecuteNonQuery();

                        if (comprobador > 0)
                        {
                            lblEstados.ForeColor = Color.Black;
                            lblEstados.Text = "Se añadío el pedido con éxito el saldo de la cuenta es 0, su nuevo estado es inactiva";
                        }
                        else
                        {
                            lblEstados.ForeColor = Color.Red;
                            lblEstados.Text = "No se pudo añadir el pedido";
                        }
                        
                        var update = new MySqlCommand("UPDATE Cuentas SET Saldo='0', Estado='Inactivo' WHERE Nick='" + vendedor + "'", conexion);
                        update.ExecuteNonQuery();
                    }
                    else
                    {
                        lblEstados.Text = "Saldo Insuficiente";
                    }
                    conexion.Close();
                }
                else
                {
                    advertencia.Close();
                }
            //}
            //catch (Exception)
            //{
            //    lblEstados.ForeColor = Color.Red;
            //    lblEstados.Text = "No se pudo conectar a la base de datos";
            //}
        }

        private void txtPrecioRP_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    //Instanciaciones
            //    MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

            //    //Entradas de datos de los builder
            //    builder.Server = "localhost";
            //    builder.Database = "pagos";
            //    builder.UserID = "root";
            //    builder.Password = "123";

            //    var conexion = new MySqlConnection(builder.ToString());
            //    conexion.Open();

            //    //Comprobación de saldos
            //    int entrada_RP = int.Parse(txtPrecioRP.ToString());
            //    var consulta = new MySqlCommand("SELECT Nombre, Saldo, Estado FROM cuentas", conexion);
            //    MySqlDataReader registro = consulta.ExecuteReader();
            //    List<cuenta> saldos = new List<cuenta>();

            //    while (registro.Read())
            //    {
            //        saldos.Add(new cuenta()
            //        {
            //            Nombre = Convert.ToString(registro["Nombre"]),
            //            Saldo = Convert.ToString(registro["Saldo"]),
            //            Estado = Convert.ToString(registro["Estado"])
            //        });
            //    }

            //    foreach (var saldo in saldos)
            //    {
            //        if (int.Parse(saldo.ToString()) > int.Parse(txtPrecioRP.Text))
            //        {

            //        }
            //    }
                
            //}
            //catch (Exception)
            //{
            //    lblEstados.Text = "No se pudo conectar con la base de datos";
            //}
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            General general = new General();
            general.Show();
            this.Hide();
        }

        private void btnPrecioSkins_Click(object sender, EventArgs e)
        {
            Precios_Skins precios = new Precios_Skins();
            precios.Show();
        }
    }
}
