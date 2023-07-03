using clubApp.db;
using System;
using System.Windows.Forms;

namespace clubApp.Views

{
    public partial class FrmActividadBusq : FormBase
    {
        public FrmActividadBusq()
        {
            InitializeComponent();
        }


        private void LoadCombos()
        {
            this.comboCodTipoActividad.DataSource = TipoActividad.FindAllStatic(null, (loc1, loc2) => loc1.Nombre.CompareTo(loc2.Nombre));
            this.comboProfesor.DataSource = Profesor.FindAllStatic(null, null);
            //this.LocalidadCbo.DataSource = ORMDB<Localidad>.FindAll(null);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmActividadBusq_Load(object sender, EventArgs e)
        {
            LoadCombos();
            this.comboProfesor.Enabled = false;
            this.comboCodTipoActividad.Enabled = false;
        }


        private void buscar_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            // verificar si hay multiples opciones a usar como filtro que elija alguna, si son dos campos, no hace falta.            
            string criterio = null;
            if (this.tipoActividadCHK.Checked)
            {
                criterio = String.Format("cod_tipo_act = {0}", (this.comboCodTipoActividad.SelectedItem as TipoActividad).Id);
            }

            if (this.profesorCHK.Checked)
            {
                if (criterio == null)
                {
                    criterio = String.Format("legajo_profe = {0}", (this.comboProfesor.SelectedItem as Profesor).Legajo);
                }
                else
                {
                    criterio += String.Format(" and legajo_profe = {0}", (this.comboProfesor.SelectedItem as Profesor).Legajo);
                }
            }

            try
            {
                var lista = Actividad.FindAllStatic(criterio, null);
                MainView.Instance.Cursor = Cursors.Default;

                if (lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados con criterio ingresado", "Sin resultados...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // invocar Formulario de Listado.
                FrmActividadList frm = new FrmActividadList();
                frm.ShowListado(lista, this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CodTipoActividad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tipoActividadCHK_CheckedChanged(object sender, EventArgs e)
        {
            this.comboCodTipoActividad.Enabled = this.tipoActividadCHK.Checked;
        }

        private void profesorCHK_CheckedChanged(object sender, EventArgs e)
        {
            this.comboProfesor.Enabled = this.profesorCHK.Checked;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
