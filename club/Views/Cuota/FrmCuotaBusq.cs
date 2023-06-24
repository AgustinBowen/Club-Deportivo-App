using clubApp.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clubApp.Views
{
    public partial class FrmCuotaBusq : FormBase
    {
        public FrmCuotaBusq()
        {
            InitializeComponent();
        }

        public void ShowBuscar()
        {
            this.Show();
        }

        private void FrmCuotaBusq_Activated_1(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;
        }

        private void BuscarBtn_Click_1(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            // verificar si hay multiples opciones a usar como filtro que elija alguna, si son dos campos, no hace falta.            
            string criterio = null;
            if (this.AnioChk.Checked)
            {
                criterio = String.Format("anio = {0}", AnioTxt.Text);
            }

            if (this.MesChk.Checked)
            {
                criterio = String.Format("mes = {0} ", MesTxt.Text);
            }
            if (this.EstadoChk.Checked)
            {
                criterio = String.Format("estado like '%{0}%'", EstadoTxt.Text);
            }

            try
            {
                var lista = Cuota.FindAllStatic(criterio, (p1, p2) => (p1.Id).CompareTo(p1.Id));
                MainView.Instance.Cursor = Cursors.Default;

                if (lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados con criterio ingresado", "Sin resultados...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // invocar Formulario de Listado.
                FrmCuotaList frm = new FrmCuotaList();
                frm.ShowListado(lista, this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelarBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AnioChk_CheckedChanged(object sender, EventArgs e)
        {
            this.AnioTxt.Enabled = this.AnioChk.Checked;
        }

        private void EstadoChk_CheckedChanged(object sender, EventArgs e)
        {
            this.EstadoTxt.Enabled = this.EstadoChk.Checked;
        }

        private void MesChk_CheckedChanged(object sender, EventArgs e)
        {
            this.MesTxt.Enabled = this.MesChk.Checked;
        }

        private void ActSocioChk_CheckedChanged(object sender, EventArgs e)
        {
            this.ActSocioCbo.Enabled = this.ActSocioChk.Checked;
        }
    }
}
