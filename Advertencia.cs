using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skins4U
{
    public partial class Advertencia : Form
    {
        public Advertencia()
        {
            InitializeComponent();
        }

        public static class variables
        {
            public static string comprobador;
        }

        private void Advertencia_Load(object sender, EventArgs e)
        {
            variables.comprobador = null;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            variables.comprobador = "aceptar";
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            variables.comprobador = "cancelar";
            this.Close();
        }

    }
}
