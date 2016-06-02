using System;
using System.Windows.Forms;

namespace ProyectoCoordinacionInformatica
{
    public partial class frmVentanaAcceso : Form
    {
        public frmVentanaAcceso()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("123")&& txtContraseña.Text.Equals("123"))
            {
                this.SetVisibleCore(false);
                menuPrincipal menu = new menuPrincipal(this);
                menu.Show();
                
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void limpiar()
        {
            this.txtContraseña.Text = "";
            this.txtUsuario.Text = "";
        }

=======
        private void frmVentanaAcceso_Load(object sender, EventArgs e)
        {

        }
>>>>>>> 9ae357149707623af94bb4f8feb17a18b05b84d0
    }
}
