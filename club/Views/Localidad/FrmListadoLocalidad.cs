using clubApp.db;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Windows.Forms;

namespace clubApp.Views
{
    public partial class FrmListadoLocalidad : FormBase

    {
        BindingList<Localidad> bindingList;
        BindingSource bindingSource;
        string criterio = null;
        bool acendente;
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
            bindingList = new BindingList<Localidad>(Localidad.FindAllStatic(criterio, (p1, p2) => (p1.Nombre).CompareTo(p2.Nombre)));
            bindingSource = new BindingSource(bindingList,null);
            this.LocalidadGrd.DataSource = bindingSource;
        }

        private void ExportarBtn_Click(object sender, EventArgs e)
        {
            FrmExportarArchivo frm = new FrmExportarArchivo();
            List<Localidad> listaLocalidad = bindingList.ToList();
            frm.ShowExportar(listaLocalidad);
        }

        private void LocalidadGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Comparison<Localidad> comparacion = (p1, p2) => (p1.Nombre).CompareTo(p2.Nombre);
            if (acendente)
            {
                switch ((sender as DataGridView).Columns[e.ColumnIndex].DataPropertyName)
                {
                    case "id":
                        comparacion = (p1, p2) => (p2.Id).CompareTo(p1.Id);
                        break;
                    case "Nombre":
                        comparacion = (p1, p2) => (p2.Nombre).CompareTo(p1.Nombre);
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
                    case "id":
                        comparacion = (p1, p2) => (p1.Id).CompareTo(p2.Id);
                        break;
                    case "Nombre":
                        comparacion = (p1, p2) => (p1.Nombre).CompareTo(p2.Nombre);
                        break;
                    default:
                        break;
                }
                acendente = true;
            }
            List<Localidad> listAux = bindingList.ToList();
            listAux.Sort(comparacion);
            bindingList = new BindingList<Localidad>(listAux);
            bindingSource = new BindingSource(bindingList, null);
            LocalidadGrd.DataSource = bindingSource;
        }

        private void FrmListadoLocalidad_Load(object sender, EventArgs e)
        {
            bindingList = new BindingList<Localidad>(Localidad.FindAllStatic(criterio, (p1, p2) => (p1.Nombre).CompareTo(p2.Nombre)));
            bindingSource = new BindingSource(bindingList, null);
            this.LocalidadGrd.DataSource = bindingSource;
        }

        private void LocalidadGrd_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmLocalidadAM frmpac = new FrmLocalidadAM();
            Localidad pac = (this.LocalidadGrd.SelectedRows[0].DataBoundItem as Localidad);
            frmpac.ShowModificarLocalidad(pac);
        }
    }
}
