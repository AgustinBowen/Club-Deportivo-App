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
            LoadCombos();
        }
        public override FrmOperacion OperacionForm
        {
            get
            {
                return base.OperacionForm;
            }
            set
            {
                base.OperacionForm = value;
                LoadCombos();
                if (value == FrmOperacion.frmAlta)
                {
                    this.Text = "Ingreso de nueva Actividad...";
                    this.CodTipoActividad.SelectedIndex = -1;
                }
                if (value == FrmOperacion.frmModificacion)
                {
                    this.Text = "Actualizacion de datos de Actividad...";
                }
                if (value == FrmOperacion.frmConsulta)
                {
                    this.Text = "Consulta de datos de Actividad...";
                    this.GuardarBtn.Visible = false;
                }

            }
        }
        private void LoadCombos()
        {
            this.CodTipoActividad.DataSource = TipoActividad.FindAllStatic(null, (loc1, loc2) => loc1.Nombre.CompareTo(loc2.Nombre));
            this.ProfesorCbo.DataSource = Profesor.FindAllStatic(null, (p1, p2) => p1.Legajo.CompareTo(p2.Legajo));
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

            actividad = new Actividad();
            actividad.CodTipoActividad = (this.CodTipoActividad.SelectedItem as TipoActividad).Id;
            actividad.LegajoProfe = (this.ProfesorCbo.SelectedItem as Profesor).Legajo;
            actividad.FechaDesde = DateTimeInicio.Value;
            detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(actividad);
            // intentar guardar en la Base de datos.
            try
            {
                actividad.SaveObj();
                Logger.SaveLog(operacionLog, this.getPermisoObj.ClaseBaseForm, detalleLog);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
        private void ShowInfoActividadInForm(Actividad Act_modif, FormBase Invoker)
        {
            this.OperacionForm = FrmOperacion.frmModificacion;
            _actividad_modif = Act_modif;
            actividadLog = Newtonsoft.Json.JsonConvert.SerializeObject(_actividad_modif);
            _actividad_modif.Id = Act_modif.Id;
            // cargar cada control con informacion de la cuota....
            FormBase.ShowDataFromModel(this, Act_modif);
            this.InvokerForm = Invoker;
            this.CancelarBtn.Click += new EventHandler(CancelarBtn_Click);
            this.ShowDialog();
        }

        public void ShowModificarActividad(FormBase Invoker, Actividad Pac_modif)
        {
            ShowInfoActividadInForm(Pac_modif, Invoker);
        }
        public void ShowModificarActividad(Actividad Pac_modif)
        {
            ShowInfoActividadInForm(Pac_modif, null);
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

