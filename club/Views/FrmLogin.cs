using clubApp.db;
using System;
using System.Windows.Forms;

namespace clubApp.Views
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IngresarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario.FindUsuario(UsuarioTxt.Text, ClaveTxt.Text);

                // Leer configuracion de permisos del usuario.
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error autenticacion...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.Dispose();
            MainView.Instance.ShowUsuario();
        }
    }
}
