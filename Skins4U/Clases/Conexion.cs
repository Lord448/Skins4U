using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Skins4U
{
    public static class Conexion
    {
        public static MySqlConnection conexion()
        {

            ////Conexión real
            //string server = "norgron.com.mx";
            //string database = "norgronc_Skins4U_LAN";
            //string usuario = "norgronc_Skins4U";
            //string contraseña = "RAnECohX59J9";
            //int port = 3306;

            //Conexión prueba
            string server = "localhost";
            string database = "pagos";
            string usuario = "root";
            string contraseña = "123";
            int port = 3306;

            string cn_query = "Database=" + database + "; Data Source=" + server + "; User Id=" + usuario + "; Password=" + contraseña + "; Port=" + port;
            try
            {
                MySqlConnection conexionBD = new MySqlConnection(cn_query);

                return conexionBD;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
