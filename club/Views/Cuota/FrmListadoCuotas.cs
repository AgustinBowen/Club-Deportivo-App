using clubApp.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace clubApp.Views
{
    public partial class FrmListadoCuotas : FormBase
    {
        BindingList<Cuota> bindingList;
        BindingSource bindingSource;
        string criterio = null;
        bool acendente;
        public FrmListadoCuotas()
        {
            InitializeComponent();
        }

        private void AnioChk_CheckedChanged(object sender, EventArgs e)
        {
            this.AnioTxt.Enabled = AnioChk.Checked;
        }

        private void PagaChk_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ImpagaChk_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FechaVencimientoChk_CheckedChanged(object sender, EventArgs e)
        {
            this.FechaVencimientoPicker.Enabled = this.FechaVencimientoChk.Checked;
        }

        private void FechaPagoChk_CheckedChanged(object sender, EventArgs e)
        {
            this.FechaPagoPicker.Enabled = this.FechaPagoChk.Checked;
        }

        private void ImporteChk_CheckedChanged(object sender, EventArgs e)
        {
            this.ImporteTxt.Enabled = ImporteChk.Checked;
        }

        private void MesChk_CheckedChanged(object sender, EventArgs e)
        {
            this.MesTxt.Enabled = MesChk.Checked;
        }

        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            // verificar si hay multiples opciones a usar como filtro que elija alguna, si son dos campos, no hace falta.            
            criterio = null;
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
                var estado = "i";
                if (criterio == null)
                {
                    criterio = string.Format("estado like '%{0}%'", estado);
                }
                else if (criterio.Contains("estado"))
                {
                    criterio += string.Format(" or estado like '%{0}%'", estado);
                }
                else
                {
                    criterio += string.Format(" and estado like '%{0}%'", estado);
                }
            }
            if (this.PagaChk.Checked)
            {
                var estado = "p";
                if (criterio == null)
                {
                    criterio = string.Format("estado like '%{0}%'", estado);
                }
                else if (criterio.Contains("estado"))
                {
                    criterio += string.Format(" or estado like '%{0}%'", estado);
                }
                else
                {
                    criterio += string.Format(" and estado like '%{0}%'", estado);
                }
            }
            if (this.AnuladaChk.Checked)
            {
                var estado = "a";
                if (criterio == null)
                {
                    criterio = string.Format("estado like '%{0}%'", estado);
                }
                else if (criterio.Contains("estado"))
                {
                    criterio += string.Format(" or estado like '%{0}%'", estado);
                }
                else
                {
                    criterio += string.Format(" and estado like '%{0}%'", estado);
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
            bindingList = new BindingList<Cuota>(Cuota.FindAllStatic(criterio, (p1, p2) => (p1.Id).CompareTo(p2.Id)));
            bindingSource = new BindingSource(bindingList, null);
            this.CuotasGrd.DataSource = bindingSource;
            
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
            List<Cuota> listaCuotas = bindingList.ToList();
            frm.ShowExportar(listaCuotas);
        }
      

        private void AnuladaChk_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CuotasGrd_DoubleClick(object sender, EventArgs e)
        {
            FrmCuotaAM frmpac = new FrmCuotaAM();
            Cuota pac = (this.CuotasGrd.SelectedRows[0].DataBoundItem as Cuota);
            frmpac.ShowModificarCuota(pac);
        }

        private void CuotasGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Comparison<Cuota> comparacion = (p1, p2) => (p1.Id).CompareTo(p2.Id);
            if (acendente)
            {
                switch ((sender as DataGridView).Columns[e.ColumnIndex].DataPropertyName)
                {
                    case "Importe":
                        comparacion = (p1, p2) => (p1.Importe).CompareTo(p2.Importe);
                        break;
                    case "FechaVenc":
                        comparacion = (p1, p2) => (p1.FechaVenc).CompareTo(p2.FechaVenc);
                        break;
                    case "FechaPago":
                        comparacion = (p1, p2) => (p1.FechaPago).CompareTo(p2.FechaPago);
                        break;
                    case "Anio":
                        comparacion = (p1, p2) => (p1.Anio).CompareTo(p2.Anio);
                        break;
                    case "Mes":
                        comparacion = (p1, p2) => (p1.Mes).CompareTo(p2.Mes);
                        break;
                    case "CodActSocio":
                        comparacion = (p1, p2) => (p1.CodActSocio).CompareTo(p2.CodActSocio);
                        break;
                    case "Id":
                        comparacion = (p1, p2) => (p1.Id).CompareTo(p2.Id);
                        break;
                    default:
                        break;
                }
                acendente = false;
            }
            else
            {
                switch ((sender as DataGridView).Columns[e.ColumnIndex].DataPropertyName)
                {
                    case "Importe":
                        comparacion = (p1, p2) => (p2.Importe).CompareTo(p1.Importe);
                        break;
                    case "FechaVenc":
                        comparacion = (p1, p2) => (p2.FechaVenc).CompareTo(p1.FechaVenc);
                        break;
                    case "FechaPago":
                        comparacion = (p1, p2) => (p2.FechaPago).CompareTo(p1.FechaPago);
                        break;
                    case "Anio":
                        comparacion = (p1, p2) => (p2.Anio).CompareTo(p1.Anio);
                        break;
                    case "Mes":
                        comparacion = (p1, p2) => (p2.Mes).CompareTo(p1.Mes);
                        break;
                    case "CodActSocio":
                        comparacion = (p1, p2) => (p2.CodActSocio).CompareTo(p1.CodActSocio);
                        break;
                    case "Id":
                        comparacion = (p1, p2) => (p2.Id).CompareTo(p1.Id);
                        break;
                    default:
                        break;
                }
                acendente = true;
            }
            List<Cuota> listAux = bindingList.ToList();
            listAux.Sort(comparacion);
            bindingList = new BindingList<Cuota>(listAux);
            bindingSource = new BindingSource(bindingList, null);
            CuotasGrd.DataSource = bindingSource;
        }

        private void FrmListadoCuotas_Load_1(object sender, EventArgs e)
        {
            bindingList = new BindingList<Cuota>(Cuota.FindAllStatic(criterio, (p1, p2) => (p1.Id).CompareTo(p2.Id)));
            bindingSource = new BindingSource(bindingList, null);
            this.CuotasGrd.DataSource = bindingSource;
        }

        private void PagarBtn_Click(object sender, EventArgs e)
        {
            Cuota cuotaAux = (CuotasGrd.SelectedRows[0].DataBoundItem as Cuota);
            cuotaAux.Estado = "p";
            cuotaAux.SaveObj();
            MessageBox.Show(string.Format("Se realizo el pago de la cuota: {0}",cuotaAux.ToString(),"Operacion Realizada",MessageBoxButtons.OK));
        }
    }
}
