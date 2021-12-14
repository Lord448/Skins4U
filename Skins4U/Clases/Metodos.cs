using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Data;
using System.Windows.Forms;

namespace Skins4U
{
    public static class Metodos
    {
        public static void Refresh_table(MySqlCommand consulta, DataGridView dataGrid)
        {
            //Adaptación al datagrid de pagos
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = consulta;
            //Adaptación de tablas
            DataTable cuentas = new DataTable();
            adapter.Fill(cuentas);
            dataGrid.DataSource = cuentas;
        }
    }
}
