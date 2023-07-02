using clubApp.db;
using System;
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
                try
                {
                    int.Parse(this.AnioTxt.Text);
                    if (criterio == null)
                    {
                        criterio = string.Format("anio = {0}", this.AnioTxt.Text);
                    }
                    else
                    {
                        criterio += string.Format(" and anio = {0}", this.AnioTxt.Text);
                    }
                }
                catch (FormatException r)
                {

                }
            }
            if (this.MesChk.Checked)
            {
                if (criterio == null)
                {
                    criterio = string.Format("mes = {0}", this.MesTxt.Text);
                }
                else
                {
                    criterio += string.Format(" and mes = {0}", this.MesTxt.Text);
                }
            }
            if (this.ImpagaChk.Checked)
            {
                ImpagaChk.Text = "i";
                if (criterio == null)
                {
                    criterio = string.Format("estado like '%{0}%'", this.ImpagaChk.Text);
                }
                else
                {
                    criterio += string.Format(" and estado like '%{0}%'", this.ImpagaChk.Text);
                }
            }
            if (this.PagaChk.Checked)
            {
                PagaChk.Text = "p";
                if (criterio == null)
                {
                    criterio = string.Format("estado like '%{0}%'", this.PagaChk.Text);
                }
                else
                {
                    criterio += string.Format(" and estado like '%{0}%'", this.PagaChk.Text);
                }
            }
            if (this.AnuladaChk.Checked)
            {
                AnuladaChk.Text = "a";
                if (criterio == null)
                {
                    criterio = string.Format("estado like '%{0}%'", this.AnuladaChk.Text);
                }
                else
                {
                    criterio += string.Format(" and estado like '%{0}%'", this.AnuladaChk.Text);
                }
            }
            if (this.AnuladaChk.Checked)
            {
                AnuladaChk.Text = "a";
                if (criterio == null)
                {
                    criterio = string.Format("estado like '%{0}%'", this.AnuladaChk.Text);
                }
                else
                {
                    criterio += string.Format(" and estado like '%{0}%'", this.AnuladaChk.Text);
                }
            }
            if (this.FechaPagoChk.Checked)
            {
                if (criterio == null)
                {
                    criterio = string.Format("fecha_pago = '%{0}%'", this.FechaPagoPicker.Value);
                }
                else
                {
                    criterio += string.Format(" and fecha_pago = '%{0}%'", this.FechaPagoPicker.Value);
                }
            }
            if (this.FechaVencimientoChk.Checked)
            {
                if (criterio == null)
                {
                    criterio = string.Format("fecha_venc = '%{0}%'", this.FechaVencimientoPicker.Value);
                }
                else
                {
                    criterio += string.Format(" and fecha_venc = '%{0}%'", this.FechaVencimientoPicker.Value);
                }
            }

            if (this.ImporteChk.Checked)
            {
                try
                {
                    int.Parse(this.ImporteTxt.Text);
                    if (criterio == null)
                    {
                        criterio = string.Format("importe = {0}", this.ImporteTxt.Text);
                    }
                    else
                    {
                        criterio += string.Format(" and importe = {0}", this.ImporteTxt.Text);
                    }
                }
                catch (FormatException r)
                {

                }
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
            this.FechaVencimientoPicker.Enabled = this.FechaVencimientoChk.Checked;
        }

        private void FechaPagoChk_CheckedChanged(object sender, EventArgs e)
        {
            this.FechaPagoPicker.Enabled = this.FechaPagoChk.Checked;
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

        }

        private void ImpagaChk_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AnuladaChk_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ImporteChk_CheckedChanged(object sender, EventArgs e)
        {
            this.ImporteTxt.Enabled = this.ImporteChk.Checked;
        }
    }
}
