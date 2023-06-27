using clubApp.db;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace clubApp.Views
{
    public partial class FrmListadoLocalidad : FormBase
    {
        string criterio = null;
        public FrmListadoLocalidad()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void ProfesoresGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void NombreTxt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void CodPostalTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            if (this.NombreChk.Checked)
            {
                if (criterio == null)
                {
                    criterio = string.Format("nombre like '%{0}%'", this.NombreTxt.Text);
                }
                else
                {
                    criterio += string.Format(" and nombre like '%{0}%'", this.NombreTxt.Text);
                }
            }
            if (this.CodPostalChk.Checked)
            {
                try
                {
                    int.Parse(this.CodPostalTxt.Text);
                    if (criterio == null)
                    {
                        criterio = string.Format("cod_postal = {0}", this.CodPostalTxt.Text);
                    }
                    else
                    {
                        criterio = string.Format(" and cod_postal = {0}", this.CodPostalTxt.Text);
                    }
                }
                catch (FormatException r)
                {

                }
            }
            this.LocalidadGrd.DataSource = Localidad.FindAllStatic(criterio, (p1, p2) => (p1.Nombre).CompareTo(p2.Nombre));
        }

        private void ExportarBtn_Click(object sender, EventArgs e)
        {
            FrmExportarArchivo frm = new FrmExportarArchivo();
            List<Localidad> listaLocalidad = Localidad.FindAllStatic(criterio, null);
            frm.ShowExportar(listaLocalidad);
        }
    }
}
