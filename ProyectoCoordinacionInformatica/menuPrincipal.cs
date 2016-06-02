using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCoordinacionInformatica
{
    public partial class menuPrincipal : Form
    {
        private frmVentanaAcceso ventanaAcceso;

        public menuPrincipal(frmVentanaAcceso ventanaAcceso)
        {
            InitializeComponent();
            this.ventanaAcceso = ventanaAcceso;
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            ventanaAcceso.limpiar();
            ventanaAcceso.Show();
        }

        private void menuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
