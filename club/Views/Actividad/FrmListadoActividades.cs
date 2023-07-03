using clubApp.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace clubApp.Views
{
    public partial class FrmListadoActividades : FormBase
    {
        BindingList<Actividad> bindingList;
        BindingSource bindingSource;
        string criterio = null;
        bool acendente;
        public FrmListadoActividades()
        {
            InitializeComponent();
        }

        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            // verificar si hay multiples opciones a usar como filtro que elija alguna, si son dos campos, no hace falta.            
            criterio = null;


            if (this.FechaInicioChk.Checked)
            {
                if (criterio == null)
                {
                    criterio = string.Format("fecha_desde = '%{0}%'", this.FechaHastaPicker.Value);
                }
                else
                {
                    criterio += string.Format(" and fecha_desde = '%{0}%'", this.FechaHastaPicker.Value);
                }
            }
            if (this.FechaFinChk.Checked)
            {
                if (criterio == null)
                {
                    criterio = string.Format("fecha_fin = '%{0}%'", this.FechaDesdePicker.Value);
                }
                else
                {
                    criterio += string.Format(" and fecha_fin = '%{0}%'", this.FechaDesdePicker.Value);
                }
            }
            if (this.tipoActividadCHK.Checked)
            {
                if (criterio == null)
                {
                    criterio = string.Format("cod_tipo_act = {0}", (this.comboCodTipoActividad.SelectedItem as TipoActividad).Id);
                }
                else
                {
                    criterio += string.Format(" and cod_tipo_act = {0}", (this.comboCodTipoActividad.SelectedItem as TipoActividad).Id);
                }
            }
            if (this.profesorCHK.Checked)
            {
                if (criterio == null)
                {
                    criterio = string.Format("legajo_profe = {0}", (this.comboProfesor.SelectedItem as Profesor).Legajo);
                }
                else
                {
                    criterio += string.Format(" and legajo_profe = {0}", (this.comboProfesor.SelectedItem as Profesor).Legajo);
                }
            }


            bindingList = new BindingList<Actividad>(Actividad.FindAllStatic(criterio, (p1, p2) => (p1.Id).CompareTo(p2.Id)));
            bindingSource = new BindingSource(bindingList, null);
            this.actividadGrd.DataSource = bindingSource;
        }

        private void LoadCombos()
        {
            this.comboCodTipoActividad.DataSource = TipoActividad.FindAllStatic(null, (loc1, loc2) => loc1.Nombre.CompareTo(loc2.Nombre));
            this.comboProfesor.DataSource = Profesor.FindAllStatic(null, null);
            //this.LocalidadCbo.DataSource = ORMDB<Localidad>.FindAll(null);
        }

        private void FrmListadoActividades_Load(object sender, EventArgs e)
        {
            LoadCombos();
            this.comboProfesor.Enabled = false;
            this.comboCodTipoActividad.Enabled = false;
            this.actividadGrd.AutoGenerateColumns = false;
            bindingList = new BindingList<Actividad>(Actividad.FindAllStatic(criterio, (p1, p2) => (p1.Id).CompareTo(p2.Id)));
            bindingSource = new BindingSource(bindingList, null);
            this.actividadGrd.DataSource = bindingSource;
        }
        private void tipoActividadCHK_CheckedChanged(object sender, EventArgs e)
        {
            this.comboCodTipoActividad.Enabled = this.tipoActividadCHK.Checked;
        }

        private void profesorCHK_CheckedChanged(object sender, EventArgs e)
        {
            this.comboProfesor.Enabled = this.profesorCHK.Checked;
        }

        private void FechaInicioChk_CheckedChanged(object sender, EventArgs e)
        {
            this.FechaDesdePicker.Enabled = this.FechaInicioChk.Checked;
        }

        private void FechaFinChk_CheckedChanged(object sender, EventArgs e)
        {
            this.FechaHastaPicker.Enabled = this.FechaFinChk.Checked;
        }

     
        private void actividadGrd_DoubleClick(object sender, EventArgs e)
        {
            FrmActividadAM frmpac = new FrmActividadAM();
            Actividad pac = (this.actividadGrd.SelectedRows[0].DataBoundItem as Actividad);
            frmpac.ShowModificarActividad(pac);
        }

        private void ExportarBtn_Click(object sender, EventArgs e)
        {
            FrmExportarArchivo frm = new FrmExportarArchivo();
            List<Actividad> listaActividad = bindingList.ToList();
            frm.ShowExportar(listaActividad);
        }

        private void actividadGrd_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmActividadAM frmpac = new FrmActividadAM();
            Actividad pac = (this.actividadGrd.SelectedRows[0].DataBoundItem as Actividad);
            frmpac.ShowModificarActividad(pac);
        }

      
        private void actividadGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Comparison<Actividad> comparacion = (p1, p2) => (p1.Id).CompareTo(p2.Id);
            if (acendente)
            {
                switch ((sender as DataGridView).Columns[e.ColumnIndex].DataPropertyName)
                {
                    case "CodTipoActividad":
                        comparacion = (p1, p2) => (p1.CodTipoActividad).CompareTo(p2.CodTipoActividad);
                        break;
                    case "LegajoProfe":
                        comparacion = (p1, p2) => (p1.LegajoProfe).CompareTo(p2.LegajoProfe);
                        break;
                    case "FechaDesde": 
                        comparacion = (p1, p2) => (p1.FechaDesde).CompareTo(p2.FechaDesde);
                        break;
                    case "FechaHasta":
                        comparacion = (p1, p2) => (p1.FechaHasta).CompareTo(p2.FechaHasta);
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
                    case "CodTipoActividad":
                        comparacion = (p1, p2) => (p2.CodTipoActividad).CompareTo(p1.CodTipoActividad);
                        break;
                    case "LegajoProfe":
                        comparacion = (p1, p2) => (p2.LegajoProfe).CompareTo(p1.LegajoProfe);
                        break;
                    case "FechaDesde":
                        comparacion = (p1, p2) => (p2.FechaDesde).CompareTo(p1.FechaDesde);
                        break;
                    case "FechaHasta":
                        comparacion = (p1, p2) => (p2.FechaHasta).CompareTo(p1.FechaHasta);
                        break;
                    case "Id":
                        comparacion = (p1, p2) => (p2.Id).CompareTo(p1.Id);
                        break;
                    default:
                        break;
                    
                }
                acendente = true;
            }
            List<Actividad> listAux = bindingList.ToList();
            listAux.Sort(comparacion);
            bindingList = new BindingList<Actividad>(listAux);
            bindingSource = new BindingSource(bindingList, null);
            actividadGrd.DataSource = bindingSource;
        }

       
    }
}
