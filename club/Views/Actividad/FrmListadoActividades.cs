using clubApp.db;
using System;
using System.Windows.Forms;

namespace clubApp.Views
{
    public partial class FrmListadoActividades : FormBase
    {
        string criterio = null;
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


            this.actividadGrd.DataSource = Actividad.FindAllStatic(criterio, (c1, c2) => (c1.Id).CompareTo(c2.Id));
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
    }
}
