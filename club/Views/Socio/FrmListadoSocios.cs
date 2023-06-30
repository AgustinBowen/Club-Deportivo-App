using clubApp.db;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace clubApp.Views
{
    public partial class FrmListadoSocios : FormBase

    {
        string criterio = null;
        public FrmListadoSocios()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {

        }

        private void ApellidoChk_CheckedChanged(object sender, EventArgs e)
        {
            this.ApellidoTxt.Enabled = this.ApellidoChk.Checked;
        }

        private void FrmListadoSocios_Load(object sender, EventArgs e)
        {
            LoadComboBox(Localidad.FindAllStatic(null, (l1, l2) => l1.Nombre.CompareTo(l2.Nombre)), this.LocalidadCbo, addSeleccion: true);

            this.SociosGrd.AutoGenerateColumns = false;
            this.SociosGrd.DataSource = Socio.FindAllStatic(null, (p1, p2) => (p1.Apellido + p1.Nombres).CompareTo(p2.Apellido + p2.Nombres));
        }

        private void LocalidadChk_CheckedChanged(object sender, EventArgs e)
        {
            this.LocalidadCbo.Enabled = LocalidadChk.Checked;
        }

        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            //

            if (this.LocalidadChk.Checked && this.LocalidadCbo.SelectedIndex != -1)
            {
                if (criterio != null)
                {
                    criterio += " and cod_postal= " + LocalidadCbo.SelectedValue;
                }
                else
                    criterio = "cod_postal= " + LocalidadCbo.SelectedValue;
            }
            this.SociosGrd.DataSource = Socio.FindAllStatic(criterio, (p1, p2) => (p1.Apellido + p1.Nombres).CompareTo(p2.Apellido + p2.Nombres));
        }

        private void SociosGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow rw in this.SociosGrd.Rows)
            {
                rw.Cells[3].Value = (rw.DataBoundItem as Socio).LocalidadSocio.Nombre;
            }
        }

        private void SociosGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SociosGrd_DoubleClick(object sender, EventArgs e)
        {
            FrmSocioAM frmpac = new FrmSocioAM();
            Socio pac = (this.SociosGrd.SelectedRows[0].DataBoundItem as Socio);
            frmpac.ShowModificarSocio(pac);
        }

        private void ExportarBtn_Click(object sender, EventArgs e)
        {
            FrmExportarArchivo frm = new FrmExportarArchivo();
            List<Socio> listaSocio = Socio.FindAllStatic(criterio, null);
            frm.ShowExportar(listaSocio);
        }
        private void SociosGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {/*
            DataGridViewColumn newColumn = SociosGrd.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = SociosGrd.SortedColumn;
            ListSortDirection direction;
            List<Socio> listaAux = new List<Socio>();
            listaAux = Socio.FindAllStatic(null, (p1, p2) => (p1.Apellido + p1.Nombres).CompareTo(p2.Apellido + p2.Nombres));
            var binding = new BindingList<Socio>(listaAux);
            var source = new BindingSource(binding, null);
            this.SociosGrd.DataSource = source;
            this.SociosGrd.AllowUserToOrderColumns = true;


            // If oldColumn is null, then the DataGridView is not sorted.
            if (oldColumn != null)
            {
                // Sort the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    SociosGrd.SortOrder == SortOrder.Ascending)
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
            SociosGrd.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;*/
        }

        private void ActivoChk_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MorosoChk_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
