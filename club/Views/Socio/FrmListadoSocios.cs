using clubApp.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace clubApp.Views
{
    public partial class FrmListadoSocios : FormBase

    {
        BindingList<Socio> bindingList;
        BindingSource bindingSource;
        string criterio = null;
        bool acendente;
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
            bindingList = new BindingList<Socio>(Socio.FindAllStatic(criterio, (p1, p2) => (p1.Nombres).CompareTo(p2.Nombres)));
            bindingSource = new BindingSource(bindingList, null);
            this.SociosGrd.DataSource = bindingSource;
        }

        private void LocalidadChk_CheckedChanged(object sender, EventArgs e)
        {
            this.LocalidadCbo.Enabled = LocalidadChk.Checked;
        }

        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            //
            criterio = null;
            if (this.LocalidadChk.Checked && this.LocalidadCbo.SelectedIndex != -1)
            {
                if (criterio != null)
                {
                    criterio += " and cod_postal= " + LocalidadCbo.SelectedValue;
                }
                else
                    criterio = "cod_postal= " + LocalidadCbo.SelectedValue;
            }
            if (this.MorosoChk.Checked)
            {
                if (criterio != null)
                {
                    criterio += " and moroso is true";
                }
                else
                    criterio = "moroso is true ";
            }
            if (this.ActivoChk.Checked)
            {
                if (criterio != null)
                {
                    criterio += " and activo is true";
                }
                else
                    criterio = "activo is true ";
            }
            if (this.ApellidoChk.Checked)
            {
                if (criterio != null)
                {
                    criterio += string.Format("and Apellido like '%{0}%'",this.ApellidoTxt);
                }
                else
                    criterio = string.Format("Apellido like '%{0}%'", this.ApellidoTxt);
            }


            bindingList = new BindingList<Socio>(Socio.FindAllStatic(criterio, (p1, p2) => (p1.Nombres).CompareTo(p2.Nombres)));
            bindingSource = new BindingSource(bindingList, null);
            this.SociosGrd.DataSource = bindingSource;
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
            List<Socio> listaSocio = bindingList.ToList();
            frm.ShowExportar(listaSocio);
        }
        private void SociosGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           Comparison<Socio> comparacion = (p1, p2) => (p1.NroDocumento).CompareTo(p2.NroDocumento);
                if (acendente)
                {
                    switch ((sender as DataGridView).Columns[e.ColumnIndex].DataPropertyName)
                    {
                        case "NroDocumento":
                            comparacion = (p1, p2) => (p1.NroDocumento).CompareTo(p2.NroDocumento);
                            break;
                        case "Apellido":
                            comparacion = (p1, p2) => (p1.Apellido).CompareTo(p2.Apellido);
                            break;
                         case "Nombres":
                            comparacion = (p1, p2) => (p1.Nombres).CompareTo(p2.Nombres);
                            break;
                    case "Telefono":
                        comparacion = (p1, p2) => (p1.Telefono).CompareTo(p2.Telefono);
                        break;
                    case "CodPostal":
                        comparacion = (p1, p2) => (p1.CodPostal).CompareTo(p2.CodPostal);
                        break;
                    case "Activo":
                        comparacion = (p1, p2) => (p1.Activo).CompareTo(p2.Activo);
                        break;
                    case "Moroso":
                        comparacion = (p1, p2) => (p1.Moroso).CompareTo(p2.Moroso);
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
                        case "NroDocumento":
                            comparacion = (p1, p2) => (p2.NroDocumento).CompareTo(p1.NroDocumento);
                            break;
                        case "Apellido":
                            comparacion = (p1, p2) => (p2.Apellido).CompareTo(p1.Apellido);
                            break;
                        break;
                    case "Nombres":
                        comparacion = (p1, p2) => (p2.Nombres).CompareTo(p1.Nombres);
                        break;
                    case "Telefono":
                        comparacion = (p1, p2) => (p2.Telefono).CompareTo(p1.Telefono);
                        break;
                    case "CodPostal":
                        comparacion = (p1, p2) => (p2.CodPostal).CompareTo(p1.CodPostal);
                        break;
                    case "Activo":
                        comparacion = (p1, p2) => (p2.Activo).CompareTo(p1.Activo);
                        break;
                    case "Moroso":
                        comparacion = (p1, p2) => (p2.Moroso).CompareTo(p1.Moroso);
                        break;
                    default:
                            break;

                    }
                    acendente = true;
                }
                List<Socio> listAux = bindingList.ToList();
                listAux.Sort(comparacion);
                bindingList = new BindingList<Socio>(listAux);
                bindingSource = new BindingSource(bindingList, null);
                SociosGrd.DataSource = bindingSource;
        }
        
        private void ActivoChk_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MorosoChk_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
