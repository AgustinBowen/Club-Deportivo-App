using clubApp.db;
using System;
using System.Windows.Forms;

namespace clubApp.Views
{
    public partial class FrmActividadAM : FormBase

    {
        public override event FormEvent DoCompleteOperationForm;
        private Actividad _actividad_modif = null;
        private string actividadLog = "";
        public FrmActividadAM()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmActividadAM_Load(object sender, EventArgs e)
        {

        }
        private void LoadCombos()
        {
            this.CodTipoActividad.DataSource = TipoActividad.FindAllStatic(null, (loc1, loc2) => loc1.Nombre.CompareTo(loc2.Nombre));

            //this.LocalidadCbo.DataSource = ORMDB<Localidad>.FindAll(null);
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            Actividad actividad = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog = "";
            MainView.Instance.Cursor = Cursors.WaitCursor;

            if (OperacionForm == FrmOperacion.frmAlta)
            {
                actividad = new Actividad();
                operacionLog = "ALTA";
                // cargar la info de la Socio antes de dar de alta.
            }
            if (OperacionForm == FrmOperacion.frmModificacion)
            {
                operacionLog = "MODIFICACION";
                actividad = _actividad_modif;
                detalleLog = "OBJ-Antes:" + actividadLog + " - OBJ-MOD";
            }


            if (DateTimeInicio.Text == "")
            {
                MessageBox.Show("Ingrese fecha Inicio", "Dato(s) faltante(s)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DateTimeInicio.Focus();
                return;
            }

            if (ObservacionesTxt.Text == "")
            {
                MessageBox.Show("Ingrese Observacion", "Dato(s) faltante(s)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ObservacionesTxt.Focus();
                return;
            }

            actividad = new Actividad();


            actividad.FechaDesde = DateTimeInicio.Value;
            actividad.FechaHasta = DateTimePicker1.Value;


            detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(actividad);
            // intentar guardar en la Base de datos.
            try
            {
                actividad.SaveObj();
                Logger.SaveLog(operacionLog, this.getPermisoObj.ClaseBaseForm, detalleLog);
            }
            catch (Exception ex)
            {
                /* if (Actividad.ExisteActividad(actividad.Id))       // TODO excepción "backend sent unrecognized response type r"
                 {
                     errMsj = "ya se encuentra registrado un Profesor con el DNI ingresado";
                 }
                 else
                 {
                     errMsj = "Error: " + ex.Message;
                 }*/
            }
            // si esta configurado, al form invoker enviarle evento de operacion completa
            if (DoCompleteOperationForm != null)
            {
                if (errMsj == "")
                    DoCompleteOperationForm(actividad, new EventArgDom { ObjProcess = actividad, Status = TipoOperacionStatus.stOK });
                else
                    DoCompleteOperationForm(actividad, new EventArgDom { ObjProcess = actividad, Mensaje = errMsj, Status = TipoOperacionStatus.stError });
            }

            if (this.InvokerForm != null)
            {
                InvokerForm.Reload();
            }
            MainView.Instance.Cursor = Cursors.Default;
            this.Close();
        }

        private void CodTipoActividad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

