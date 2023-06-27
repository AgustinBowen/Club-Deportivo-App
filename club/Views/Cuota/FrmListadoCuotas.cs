using clubApp.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            this.FechaPagoChk.Enabled = FechaPagoChk.Checked;
        }

        private void ImporteChk_CheckedChanged(object sender, EventArgs e)
        {
            this.ImporteChk.Enabled = ImporteChk.Checked;
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
            this.CuotasGrd.DataSource = Cuota.FindAllStatic(criterio, (c1, c2) => (c1.Id).CompareTo(c2.Id));
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

        private void AnuladaChk_CheckedChanged(object sender, EventArgs e)
        {
            this.AnuladaChk.Enabled = this.AnuladaChk.Checked;
        }

        private void CuotasGrd_DoubleClick(object sender, EventArgs e)
        {
            FrmCuotaAM frmpac = new FrmCuotaAM();
            Cuota pac = (this.CuotasGrd.SelectedRows[0].DataBoundItem as Cuota);
            frmpac.ShowModificarCuota(pac);
        }

        private void CuotasGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = CuotasGrd.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = CuotasGrd.SortedColumn;
            ListSortDirection direction;
            List<Cuota> listaAux = new List<Cuota>();
            listaAux = Cuota.FindAllStatic(null, (c1, c2) => (c1.Anio).CompareTo(c2.Anio));
            var binding = new BindingList<Cuota>(listaAux);
            var source = new BindingSource(binding, null);
            this.CuotasGrd.DataSource = source;
            this.CuotasGrd.AllowUserToOrderColumns = true;

            // If oldColumn is null, then the DataGridView is not sorted.
            if (oldColumn != null)
            {
                // Sort the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    CuotasGrd.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    // Sort a new column and remove the old SortGlyph.
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            // Sort the selected column.
            CuotasGrd.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;
        }
    }
}
