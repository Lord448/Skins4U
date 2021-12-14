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
    public partial class Reporte_de_bugs : Form
    {
        public Reporte_de_bugs()
        {
            InitializeComponent();
        }

        private void Reporte_de_bugs_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

        }

        private void btnUndo_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Checar_reportes checar_Reportes = new Checar_reportes();
            checar_Reportes.ShowDialog();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            General general = new General();
            general.Show();
            this.Close();
        }

        private void CbbZona_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
