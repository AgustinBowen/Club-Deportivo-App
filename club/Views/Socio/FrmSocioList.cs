using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clubApp.db;

namespace clubApp.Views
{
    public partial class FrmSocioList : FormBase
    {
        private string _criterio = null;
        private List<Socio> _listado;
        
        public FrmSocioList()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {

        }
        
        public void ShowListado(List<Socio> listado, FormBase Invoker, string criterio)
        {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.SociosGrd.AutoGenerateColumns = false;
            var bindingList = new BindingList<Socio>(listado);
            var source = new BindingSource(bindingList, null);
            this.SociosGrd.DataSource =  source;
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }

        private void FrmSocioList_Load(object sender, EventArgs e)
        {
            
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EspecialidadesGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for( int i=0;i<this.SociosGrd.Rows.Count;++i)
            {
                DataGridViewRow item  = this.SociosGrd.Rows[i];
                item.Cells[5].Value = (item.DataBoundItem as Socio).LocalidadSocio.Nombre;
            }
        }

        private void SociosGrd_DoubleClick(object sender, EventArgs e)
        {
            if( this.SociosGrd.SelectedRows.Count>0)
            {

                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmSocioAM frm = new FrmSocioAM();
                frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                frm.ShowModificarSocio (this, (this.SociosGrd.SelectedRows[0].DataBoundItem as Socio));
            }
        }

        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            this.Cursor = Cursors.Default;
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                var selAnt = SociosGrd.SelectedRows[0].Index;
                this.SociosGrd.DataSource = Socio.FindAllStatic(_criterio, (e1, e2) => e1.NroDocumento.CompareTo(e2.NroDocumento));
                SociosGrd.Rows[selAnt].Selected = true;
                MessageBox.Show("Socio actualizado", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SociosGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = SociosGrd.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = SociosGrd.SortedColumn;
            ListSortDirection direction;

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
                SortOrder.Ascending : SortOrder.Descending;
        }
    }
}
