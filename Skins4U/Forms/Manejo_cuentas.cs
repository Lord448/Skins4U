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

        public static class cache
        {
            public static string Nick_cache;
            public static int saldo_cache;
            public static string Usuario_cache;
        }

        private void Undo(string selector)
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string query_update = null;
            try
            {
                lblExeption.ForeColor = Color.Green;
                if (selector == "Eliminacion")
                    query_update = "UPDATE Cuentas SET Estado='Activo' WHERE Nick='" + cache.Nick_cache + "'";
                else if (selector == "Saldos")
                    query_update = "UPDATE Cuentas SET Saldo='" + cache.saldo_cache.ToString() + "' WHERE Nick='" + cache.Nick_cache + "'";
                else if (selector == "Insercion")
                    query_update = "DELETE FROM Cuentas WHERE Nick='" + cache.Nick_cache + "'";
                var update = new MySqlCommand(query_update, conexion);
                update.ExecuteNonQuery();

                lblExeption.Text = "La operación se realizó con éxito";
                //Proceso de Refresh
                var consultas = new MySqlCommand("SELECT Nick, Saldo, Estado, Usuario, Contraseña FROM Cuentas", conexion);
                Metodos.Refresh_table(consultas, dGVCuentas);
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

        private void Manejo_cuentas_Load(object sender, EventArgs e)
        {
            MySqlConnection conexion = Conexion.conexion();
            string query_consulta = "SELECT Nick, Saldo, Estado, Usuario, Contraseña FROM Cuentas";
            try
            {
                conexion.Open();
                var consultas = new MySqlCommand(query_consulta, conexion);
                Metodos.Refresh_table(consultas, dGVCuentas);
            }
            catch (Exception ex)
            {
                lblExeption.ForeColor = Color.Red;
                lblExeption.Text = "No se pudo conectar con la base de datos" + ex.Message;
            }
            finally
            {
                conexion.Close();
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
            else
            {
                advertencia.ShowDialog();

            }
            if (Advertencia.variables.comprobador == "aceptar" && Advertencia.variables.comprobador != null)
            {
                string nick = txtNick.Text.ToString();
                int Saldo = int.Parse(txtSaldo.Text.ToString());
                string Usuario = txtUsuario.Text.ToString();
                string Contraseña = "Salerosa123";
                cache.Nick_cache = nick;

                string query_insercion = "INSERT INTO Cuentas VALUES ('" + nick + "', '" + Saldo + "', 'Activo', '" + Usuario + "', '" + Contraseña + "')";
                string query_consulta = "SELECT Nick, Saldo, Estado, Usuario, Contraseña FROM Cuentas";
                MySqlConnection conexion = Conexion.conexion();
                conexion.Open();
                try
                {
                    var insercion = new MySqlCommand(query_insercion, conexion);
                    insercion.ExecuteNonQuery();
                    //Proceso de refresh
                    var consultas = new MySqlCommand(query_consulta, conexion);
                    Metodos.Refresh_table(consultas, dGVCuentas);
                    lblExeption.ForeColor = Color.Green;
                    lblExeption.Text = "Se insertó el vendedor con éxito";
                    //Reinicio de var
                    txtSaldo.Text = null;
                    txtNick.Text = null;
                    txtUsuario.Text = null;
                    Advertencia.variables.comprobador = null;
                    btnUndo_Insert.Visible = true;
                }
                catch (Exception ex)
                {
                    lblExeption.ForeColor = Color.Red;
                    lblExeption.Text = "Error: " + ex.Message;
                }
                finally
                {
                    conexion.Close();
                }
            }
            else
            {
                advertencia.Close();
            }
        }
        //-----------------------------------------------Botón undo de inserción-----------------------------------------------
        private void btnUndo_Insert_Click(object sender, EventArgs e)
        {
            Advertencia advertencia = new Advertencia();
            advertencia.ShowDialog();
            if(Advertencia.variables.comprobador == "aceptar" && Advertencia.variables.comprobador != null)
            {
                lblExeption.Text = null;
                Undo("Insercion");
            }
            else
            {
                advertencia.Close();
            }
            btnUndo_Insert.Visible = false;
        }

        //-----------------------------------------------Botón aceptar de eliminación--------------------------------------------
        private void btnAceptar_Elim_Click(object sender, EventArgs e)
        {
            lblExeption.ForeColor = Color.Red;
            Advertencia advertencia = new Advertencia();
            if (txtNick_elim.Text == "")
                lblExeption.Text = "Inserte un valor en la casilla de vendedor";
            else
                advertencia.ShowDialog();

            if (Advertencia.variables.comprobador == "aceptar" && Advertencia.variables.comprobador != null)
            {
                MySqlConnection conexion = Conexion.conexion();
                conexion.Open();
                try
                {
                    string Nick = txtNick_elim.Text;
                    cache.Nick_cache = Nick;
                    string query_update = "UPDATE Cuentas SET Estado='Inactivo' WHERE Nick='" + Nick + "'";
                    var update = new MySqlCommand(query_update, conexion);
                    update.ExecuteNonQuery();
                    lblExeption.ForeColor = Color.Green;
                    lblExeption.Text = "Se pudo desactivar al vendedor con éxito";
                    //Proceso de refresh
                    var consultas = new MySqlCommand("SELECT Nick, Saldo, Estado, Usuario, Contraseña FROM Cuentas", conexion);
                    Metodos.Refresh_table(consultas, dGVCuentas);
                    //Reinicio de var
                    txtNick_elim.Text = null;
                    Advertencia.variables.comprobador = null;
                    btnUndo_Elim.Visible = true;
                }
                catch (Exception ex)
                {
                    lblExeption.ForeColor = Color.Red;
                    lblExeption.Text = "Error: " + ex.Message;
                }
                finally
                {
                    conexion.Close();
                }
            }
            else
            {
                advertencia.Close();
            }
        }
        //-----------------------------------------------Botón de undo de eliminación---------------------------------------------------
        private void btnUndo_Elim_Click(object sender, EventArgs e)
        {
            Advertencia advertencia = new Advertencia();
            advertencia.ShowDialog();
            if (Advertencia.variables.comprobador == "aceptar" && Advertencia.variables.comprobador != null)
            {
                Undo("Eliminacion");
            }
            else
            {
                advertencia.Close();
            }
            btnUndo_Elim.Visible = false;
        }
        //-----------------------------------------------Botón aceptar de update--------------------------------------------
        private void btnSaldosUp_Click(object sender, EventArgs e)
        {
            lblExeption.ForeColor = Color.Red;
            Advertencia advertencia = new Advertencia();
            if (txtNickUp.Text == "")
                lblExeption.Text = "Inserte un valor en la casilla de vendedor";
            else if (txtSaldoUp.Text == "")
                lblExeption.Text = "Inserte un valor en la casilla de saldo";
            else
                advertencia.ShowDialog();
            if (Advertencia.variables.comprobador == "aceptar" && Advertencia.variables.comprobador != null)
            {
                string nick = txtNickUp.Text;
                int saldo = int.Parse(txtSaldoUp.Text);
                cache.Nick_cache = nick;
                MySqlConnection conexion = Conexion.conexion();
                conexion.Open();
                try
                {
                    string query_saldo_ant = "SELECT Saldo FROM Cuentas WHERE Nick='" + nick + "'";
                    var saldo_anterior = new MySqlCommand(query_saldo_ant, conexion);
                    cache.saldo_cache = Convert.ToInt32(saldo_anterior.ExecuteScalar());
                    string query_update = "UPDATE Cuentas SET Saldo='" + saldo + "' WHERE Nick='" + nick + "'";
                    var update = new MySqlCommand(query_update, conexion);
                    int comprobador = update.ExecuteNonQuery();
                    lblExeption.ForeColor = Color.Green;
                    lblExeption.Text = "Se pudieron actualizar los datos con éxito";
                    //Proceso de refresh
                    var consultas = new MySqlCommand("SELECT Nick, Saldo, Estado, Usuario, Contraseña FROM Cuentas", conexion);
                    Metodos.Refresh_table(consultas, dGVCuentas);
                    //Reinicio de var
                    txtSaldoUp.Text = null;
                    txtNickUp.Text = null;
                    btnUndo_Up.Visible = true;
                    Advertencia.variables.comprobador = null;
                }
                catch (Exception ex)
                {
                    lblExeption.ForeColor = Color.Red;
                    lblExeption.Text = ex.Message;
                }
            }
            else
            {
                advertencia.Close();
            }
        }
        //-----------------------------------------------Botón de undo de update de saldos---------------------------------------------------
        private void btnUndo_Up_Click(object sender, EventArgs e)
        {
            Advertencia advertencia = new Advertencia();
            advertencia.ShowDialog();
            if (Advertencia.variables.comprobador == "aceptar" && Advertencia.variables.comprobador != null)
            {
                Undo("Saldos");
            }
            else
            {
                advertencia.Close();
            }
            btnUndo_Up.Visible = false;
        }

        //-----------------------------------------------Botón aceptar de refresh------------------------------------------
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string query_consultas = "SELECT Nick, Saldo, Estado, Usuario, Contraseña FROM Cuentas";
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            try
            {
                //Comando de la sentencia SQL
                var consulta = new MySqlCommand(query_consultas, conexion);
                consulta.ExecuteNonQuery();
                Metodos.Refresh_table(consulta, dGVCuentas);
            }
            catch (Exception ex)
            {
                lblExeption.ForeColor = Color.Red;
                lblExeption.Text = "No se pudo conectar con la base de datos: " + ex.Message;
            }
            finally
            {
                conexion.Close();
            }
           
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            General general = new General();
            general.Show();
            this.Hide();
        }
    }
}
