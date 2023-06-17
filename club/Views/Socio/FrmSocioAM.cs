using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clubApp.db;
using Newtonsoft;

namespace clubApp.Views
{
    [Permiso(ClaseBaseForm="Socio", FuncionPermiso = "AltaSocio,ModificaSocio,ConsultaSocio", RolUsuario = "administrador,operadorSocio,operadorTurno,consulta,operador")]
    public partial class FrmSocioAM : FormBase
    {
        // Requerida override para poder agregarle un handler
        public override event FormEvent DoCompleteOperationForm;
        private Socio _Socio_modif = null;
        private string SocioLog = "";
        public FrmSocioAM()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {
            if (perm != null)
            {
                this.GuardarBtn.Enabled = perm.HasAddPerm || perm.HasUpdPerm;
                if (!this.GuardarBtn.Enabled && perm.HasViewPerm)
                {
                    this.GuardarBtn.Visible = false;
                    FormBase.SoloConsulta(this);
                    OperacionForm = FrmOperacion.frmConsulta;
                }
            }
        }
        private void FrmpSocioAM_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadCombos()
        {
            this.LocalidadCbo.DataSource =  Localidad.FindAllStatic(null, (loc1, loc2) => loc1.Nombre.CompareTo(loc2.Nombre));

            //this.LocalidadCbo.DataSource = ORMDB<Localidad>.FindAll(null);
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
                    this.Text = "Ingreso de nuevo Socio...";
                    this.LocalidadCbo.SelectedIndex = -1;
                }
                if (value == FrmOperacion.frmModificacion)
                {
                    this.Text = "Actualizacion de datos de Socio...";
                }
                if (value == FrmOperacion.frmConsulta)
                {
                    this.Text = "Consulta de datos de Socio...";
                    this.GuardarBtn.Visible = false;
                }
            }
        }
        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            Socio Socio = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog="";
            MainView.Instance.Cursor = Cursors.WaitCursor;
                       
            
            if (ApellidoTxt.Text == "")
            {
                MessageBox.Show("Ingrese apellido", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ApellidoTxt.Focus();
                return;
            }
            // validar...
            //.....
            //....
            if (OperacionForm == FrmOperacion.frmAlta)
            {
                Socio = new Socio();
                operacionLog = "ALTA";
                // cargar la info de la Socio antes de dar de alta.
            }
            
            if (OperacionForm == FrmOperacion.frmModificacion)
            {
                operacionLog = "MODIFICACION";
                Socio = _Socio_modif;
                detalleLog = "OBJ-Antes:" + SocioLog + " - OBJ-MOD";
            }
            if (OperacionForm == FrmOperacion.frmConsulta)
            {
                operacionLog = "CONSULTA";
            }

            // SET CAMPOS DE LOS CONTROLES A LOS ATRIBUTOS
            Socio.Apellido = ApellidoTxt.Text;
            Socio.Nombres = NombresTxt.Text;
            Socio.NroDocumento = Convert.ToInt32(DniTxt.Text);
            Socio.Domicilio = DomicilioTxt.Text;
            Socio.CodPostal = Convert.ToInt32(LocalidadCbo.SelectedValue);
            Socio.Observaciones = ObservacionesTxt.Text;
            Socio.Telefono = TelefonoTxt.Text;
            detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(Socio);
            // intentar guardar en la Base de datos.
            try
            {
                Socio.SaveObj();
                Logger.SaveLog(operacionLog, this.getPermisoObj.ClaseBaseForm, detalleLog);
            }
            catch (Exception ex)
            {
                errMsj = "Error: " + ex.Message;
            }
            // si esta configurado, al form invoker enviarle evento de operacion completa
            if (DoCompleteOperationForm != null)
            {
                if (errMsj == "")
                    DoCompleteOperationForm(Socio, new EventArgDom { ObjProcess = Socio, Status = TipoOperacionStatus.stOK });
                else
                    DoCompleteOperationForm(Socio, new EventArgDom { ObjProcess = Socio, Mensaje = errMsj, Status = TipoOperacionStatus.stError });
            }

            if (this.InvokerForm != null)
            {
                InvokerForm.Reload();
            }
            MainView.Instance.Cursor = Cursors.Default;
            this.Close();
        }
        // Notificara al Invocador que recargue algun cambio de datos.
        public void ShowModificarSocio(FormBase Invoker, Socio Pac_modif)
        {
            ShowInfoSocioInForm(Pac_modif, Invoker);
        }
        public void ShowModificarSocio(Socio Pac_modif)
        {
            ShowInfoSocioInForm(Pac_modif, null);
        }
        private void ShowInfoSocioInForm(Socio Cli_modif, FormBase Invoker)
        {
            this.OperacionForm = FrmOperacion.frmModificacion;
            _Socio_modif = Cli_modif;
            SocioLog = Newtonsoft.Json.JsonConvert.SerializeObject(_Socio_modif);
            // cargar cada control con informacion del Socio....
            //this.ApellidoTxt.Text = Pac_modif.Apellido;
            FormBase.ShowDataFromModel(this, Cli_modif);
            this.InvokerForm = Invoker;
            this.CancelarBtn.Click+=new EventHandler(CancelarBtn_Click);
            this.ShowDialog();
        }
        public void ShowIngresoSocio(FormBase Invoker)
        {
            this.InvokerForm = Invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }
        public void ShowIngresoSocio()
        {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        private void FrmSocioAM_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;   
        }

        private void DniTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }            
        }

        private void ApellidoTxt_TextChanged(object sender, EventArgs e)
        {
            if(!this.ApellidoTxt.Text.All(c=>  Char.IsLetter(c) || Char.IsWhiteSpace(c)))
            {
             
            }
        }   

        private void ActividadesBtn_Click(object sender, EventArgs e)
        {

        }

    }
}
