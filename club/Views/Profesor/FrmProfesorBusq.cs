using clubApp.db;
using System;
using System.Windows.Forms;

namespace clubApp.Views
{
    public partial class FrmProfesorBusq : FormBase
    {
        public FrmProfesorBusq()
        {
            InitializeComponent();
        }
        public override void ConfigurePermiso(PermisoAttribute perm)
        {

        }
        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            // verificar si hay multiples opciones a usar como filtro que elija alguna, si son dos campos, no hace falta.            
            string criterio = null;
            if (this.ApellidoChk.Checked)
            {
                criterio = String.Format("apellido like '%{0}%'", ApellidoTxt.Text);
            }
            if (this.NombresChk.Checked)
            {
                if (criterio == null)
                {
                    criterio = String.Format("nombres like '%{0}%'", NombresTxt.Text);
                }
                else
                {
                    criterio = String.Format(" and nombres like '%{0}%'", NombresTxt.Text);
                }
            }
            if (this.LocalidadChk.Checked)
            {
                if (criterio == null)
                    criterio = String.Format("cod_postal={0} ", LocalidadCbo.SelectedValue);
                else
                    criterio += String.Format(" and cod_postal = {0}", LocalidadCbo.SelectedValue);
            }
            if (this.LegajoChk.Checked)
            {
                if (criterio == null)
                {
                    criterio = String.Format("legajo = {0}", LegajoTxt.Text);
                }
                else
                {
                    criterio += String.Format(" and legajo = {0}", LegajoTxt.Text);
                }
            }

            try
            {
                var lista = Profesor.FindAllStatic(criterio, (p1, p2) => (p1.Apellido + p1.Nombres).CompareTo(p2.Apellido + p2.Nombres));
                MainView.Instance.Cursor = Cursors.Default;

                if (lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados con criterio ingresado", "Sin resultados...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // invocar Formulario de Listado.
                FrmProfesorList frm = new FrmProfesorList();
                frm.ShowListado(lista, this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApellidoChk_CheckedChanged(object sender, EventArgs e)
        {
            this.ApellidoTxt.Enabled = this.ApellidoChk.Checked;
        }

        private void LegajoChk_CheckedChanged(object sender, EventArgs e)
        {
            this.LegajoTxt.Enabled = this.LegajoChk.Checked;
        }

        private void NombresChk_CheckedChanged(object sender, EventArgs e)
        {
            this.NombresTxt.Enabled = this.NombresChk.Checked;
        }


        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowBuscar()
        {
            this.Show();
        }

        private void LocalidadChk_CheckedChanged(object sender, EventArgs e)
        {
            this.LocalidadCbo.Enabled = this.LocalidadChk.Checked;
        }

        private void FrmProfesorBusq_Load(object sender, EventArgs e)
        {
            LocalidadCbo.DataSource = Localidad.FindAllStatic(null, (loc1, loc2) => loc1.Nombre.CompareTo(loc2.Nombre));
            LocalidadCbo.SelectedIndex = -1;
        }

        private void FrmSocioBusq_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
