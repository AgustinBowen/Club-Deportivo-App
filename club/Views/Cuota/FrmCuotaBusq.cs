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
            if (this.ImpagaChk.Checked)
            {
                criterio = String.Format("estado like '%{0}%'", 'i');
            }
            if (this.PagaChk.Checked)
            {
                criterio = String.Format("estado like '%{0}%'", 'p');
            }
            if (this.AnuladaChk.Checked)
            {
                criterio = String.Format("estado like '%{0}%'", 'a');
            }
            if (this.FechaVencimientoChk.Checked)
            {
                criterio = String.Format("fecha_venc = '%{0}%'", FechaVencimientoPicker.Value);
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


        private void MesChk_CheckedChanged(object sender, EventArgs e)
        {
            this.MesTxt.Enabled = this.MesChk.Checked;
        }


        private void FechaVencimientoChk_CheckedChanged(object sender, EventArgs e)
        {
            this.FechaPagoChk.Enabled = this.FechaPagoChk.Checked;
        }

        private void FechaPagoChk_CheckedChanged(object sender, EventArgs e)
        {
            this.FechaVencimientoChk.Enabled = this.FechaVencimientoChk.Enabled;
        }

        private void FechaVencimientoPicker_ValueChanged(object sender, EventArgs e)
        {
            this.FechaVencimientoPicker.Value = FechaVencimientoPicker.Value;
        }

        private void FechaPagoPicker_ValueChanged(object sender, EventArgs e)
        {
            this.FechaPagoPicker.Value = FechaPagoPicker.Value;
        }

        private void PagaChk_CheckedChanged(object sender, EventArgs e)
        {
            this.PagaChk.Enabled = this.PagaChk.Checked;
        }

        private void ImpagaChk_CheckedChanged(object sender, EventArgs e)
        {
            this.ImpagaChk.Enabled = this.ImpagaChk.Checked;
        }

        private void AnuladaChk_CheckedChanged(object sender, EventArgs e)
        {
            this.AnuladaChk.Enabled = this.AnuladaChk.Checked;;
        }
    }
}
