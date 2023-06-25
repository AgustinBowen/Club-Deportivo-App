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
    public partial class FrmListadoCuotas : FormBase
    {
        string criterio = null;
        public FrmListadoCuotas()
        {
            InitializeComponent();
        }

        private void AnioChk_CheckedChanged(object sender, EventArgs e)
        {
            this.AnioChk.Enabled = AnioChk.Checked;
        }

        private void PagaChk_CheckedChanged(object sender, EventArgs e)
        {
            this.PagaChk.Enabled = PagaChk.Checked;
        }

        private void ImpagaChk_CheckedChanged(object sender, EventArgs e)
        {
            this.ImpagaChk.Enabled = ImpagaChk.Checked; 
        }

        private void FechaVencimientoChk_CheckedChanged(object sender, EventArgs e)
        {
            this.FechaVencimientoChk.Enabled = FechaVencimientoChk.Checked;
        }

        private void FechaPagoChk_CheckedChanged(object sender, EventArgs e)
        {
            this.FechaPagoChk.Enabled= FechaPagoChk.Checked;
        }

        private void ImporteChk_CheckedChanged(object sender, EventArgs e)
        {
            this.ImporteChk.Enabled= ImporteChk.Checked;
        }

        private void MesChk_CheckedChanged(object sender, EventArgs e)
        {
            this.MesChk.Enabled = MesChk.Checked;   
        }

        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            // verificar si hay multiples opciones a usar como filtro que elija alguna, si son dos campos, no hace falta.            
            string criterio = null;
            if (this.AnioChk.Checked)
            {
                int.Parse(this.AnioTxt.Text);
                criterio = String.Format("anio = {0}", AnioTxt.Text);
            }

            if (this.MesChk.Checked)
            {
                criterio = String.Format("mes = {0} ", MesTxt.Text);
            }
            if (this.PagaChk.Checked)
            {
                criterio = String.Format("estado like 'paga'");
            }
            if (this.ImpagaChk.Checked)
            {
                criterio = String.Format("estado like 'impaga'");
            }
            if (this.ImporteChk.Checked)
            {
                int.Parse(this.ImporteTxt.Text);
                criterio = String.Format("anio = {0}", ImporteTxt.Text);
            }
            if (this.FechaVencimientoChk.Checked)
            {
                Convert.ToDateTime(this.FechaVencimientoPicker.Text);
                criterio = String.Format("fecha_venc = {0}", FechaVencimientoPicker.Text);
            }
            if (this.FechaVencimientoChk.Checked)
            {
                Convert.ToDateTime(this.FechaPagoPicker.Text);
                criterio = String.Format("fecha_pago = {0}", FechaPagoPicker.Text);
            }

            this.CuotasGrd.DataSource = Cuota.FindAllStatic(criterio, (c1, c2) => (c1.Anio).CompareTo(c2.Anio));
        }

        private void FechaVencimientoPicker_ValueChanged(object sender, EventArgs e)
        {
            this.FechaVencimientoPicker.Value = FechaVencimientoPicker.Value;
        }

        private void CuotasGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CuotasGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow rw in this.CuotasGrd.Rows)
            {
                //rw.Cells[4].Value = (rw.DataBoundItem as Profesor).LocalidadProfesor.Nombre;
                //rw.Cells[5].Value = (rw.DataBoundItem as Profesor).ListadoEspecialidades;
                //rw.Cells[4].Value = (rw.DataBoundItem as Profesor).LocalidadProfesor.Nombre;
            }
        }

        public void ShowListar()
        {
            this.Show();
        }

        private void ExportarBtn_Click(object sender, EventArgs e)
        {
            FrmExportarArchivo frm = new FrmExportarArchivo();
            List<Cuota> listaCuotas = Cuota.FindAllStatic(criterio, null);
            frm.ShowExportar(listaCuotas);
        }
        private void FrmListadoCuotas_Load(object sender, EventArgs e)
        {
            this.CuotasGrd.AutoGenerateColumns = false;
            this.CuotasGrd.DataSource = Cuota.FindAllStatic(null, (c1, c2) => (c1.Anio).CompareTo(c2.Anio));
        }
    }
}
