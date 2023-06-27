using clubApp.db;
using System;
using System.Windows.Forms;

namespace clubApp.Views
{
    public partial class FrmLocalidadBusq : FormBase
    {
        public FrmLocalidadBusq()
        {
            InitializeComponent();
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            // verificar si hay multiples opciones a usar como filtro que elija alguna, si son dos campos, no hace falta.            
            string criterio = null;
            if (this.NombreChk.Checked)
            {
                criterio = String.Format("nombre like '%{0}%'", NombreTxt.Text);
            }
            if (this.CodPostalChk.Checked)
            {
                if (criterio == null)
                {
                    criterio = String.Format("cod_postal = {0}", CodPostalTxt.Text);
                }
                else
                {
                    criterio += String.Format(" and cod_postal = {0}", CodPostalTxt.Text);
                }
            }

            try
            {
                var lista = Localidad.FindAllStatic(criterio, (p1, p2) => (p1.Nombre).CompareTo(p2.Nombre));
                MainView.Instance.Cursor = Cursors.Default;

                if (lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados con criterio ingresado", "Sin resultados...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // invocar Formulario de Listado.
                FrmLocalidadList frm = new FrmLocalidadList();
                frm.ShowListado(lista, this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NombreChk_CheckedChanged(object sender, EventArgs e)
        {
            this.NombreTxt.Enabled = this.NombreChk.Checked;
        }

        private void CodPostalChk_CheckedChanged(object sender, EventArgs e)
        {
            this.CodPostalTxt.Enabled = this.CodPostalChk.Checked;
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ShowBuscar()
        {
            this.Show();
        }


        private void FrmLocalidadBusq_Activated_1(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;
        }

        private void CodPostalTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
