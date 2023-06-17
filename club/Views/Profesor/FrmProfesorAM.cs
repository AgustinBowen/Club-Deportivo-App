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

    [Permiso(ClaseBaseForm = "Profesor", FuncionPermiso = "AltaProfesor,ModificaProfesor,ConsultaProfesor", RolUsuario = "administrador,operadorProfesor,consulta,operador")]
    public partial class FrmProfesorAM : FormBase
    {
        public override event FormEvent DoCompleteOperationForm;
        private Profesor _Profesor_modif = null;
        private string ProfesorLog = "";

        public FrmProfesorAM()
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
        
        public override FrmOperacion OperacionForm
        {
            get
            {
                return base.OperacionForm;
            }
            set
            {
                base.OperacionForm = value;
                
                if (value == FrmOperacion.frmAlta)
                {
                    this.Text = "Ingreso de nuevo Profesor...";
                }
                if (value == FrmOperacion.frmModificacion)
                {
                    this.Text = "Actualizacion de datos de Profesor...";
                }
                if (value == FrmOperacion.frmConsulta)
                {
                    this.Text = "Consulta de datos de Profesor...";
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
            Profesor profesor = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog = "";
            MainView.Instance.Cursor = Cursors.WaitCursor;

            if (OperacionForm == FrmOperacion.frmAlta)
            {
                profesor = new Profesor();
                operacionLog = "ALTA";
                // cargar la info de la Socio antes de dar de alta.
            }
            if (OperacionForm == FrmOperacion.frmModificacion)
            {
                operacionLog = "MODIFICACION";
                profesor = _Profesor_modif;
                detalleLog = "OBJ-Antes:" + ProfesorLog + " - OBJ-MOD";
            }

            if (ApellidoTxt.Text == "")
            {
                MessageBox.Show("Ingrese apellido", "Dato(s) faltante(s)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ApellidoTxt.Focus();
                return;
            }

            if (NombresTxt.Text == "")
            {
                MessageBox.Show("Ingrese nombre", "Dato(s) faltante(s)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NombresTxt.Focus();
                return;
            }

            if (LegajoTxt.Text == "")
            {
                MessageBox.Show("Ingrese matrícula", "Dato(s) faltante(s)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LegajoTxt.Focus();
                return;
            }

            if (DniTxt.Text == "")
            {
                MessageBox.Show("Ingrese DNI", "Dato(s) faltante(s)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DniTxt.Focus();
                return;
            }

            if (DomicilioTxt.Text == "")
            {
                MessageBox.Show("Ingrese domicilio", "Dato(s) faltante(s)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DomicilioTxt.Focus();
                return;
            }

            if (TelefonoTxt.Text == "")
            {
                MessageBox.Show("Ingrese teléfono", "Dato(s) faltante(s)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TelefonoTxt.Focus();
                return;
            }
                        
            profesor = new Profesor();
            profesor.Apellido = ApellidoTxt.Text;
            profesor.Nombres = NombresTxt.Text;
            profesor.Legajo = Int32.Parse(LegajoTxt.Text);
            profesor.NroDocumento = Int32.Parse(DniTxt.Text);
            profesor.Domicilio = DomicilioTxt.Text;
            profesor.Telefono = TelefonoTxt.Text;            
            

            detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(profesor);
            // intentar guardar en la Base de datos.
            try
            {
                profesor.SaveObj();
                Logger.SaveLog(operacionLog, this.getPermisoObj.ClaseBaseForm, detalleLog);
            }
            catch (Exception ex)
            {
                if (Profesor.ExisteProfesor(profesor.NroDocumento))       // TODO excepción "backend sent unrecognized response type r"
                {
                    errMsj = "ya se encuentra registrado un Profesor con el DNI ingresado";
                }
                else
                {
                    errMsj = "Error: " + ex.Message;
                }
            }
            // si esta configurado, al form invoker enviarle evento de operacion completa
            if (DoCompleteOperationForm != null)
            {
                if (errMsj == "")
                    DoCompleteOperationForm(profesor, new EventArgDom { ObjProcess = profesor, Status = TipoOperacionStatus.stOK });
                else
                    DoCompleteOperationForm(profesor, new EventArgDom { ObjProcess = profesor, Mensaje = errMsj, Status = TipoOperacionStatus.stError });
            }

            if (this.InvokerForm != null)
            {
                InvokerForm.Reload();
            }
            MainView.Instance.Cursor = Cursors.Default;
            this.Close();
        }

        public void ShowModificarProfesor(FormBase Invoker, Profesor Profesor_modif)
        {
            ShowInfoProfesorInForm(Profesor_modif, Invoker);
        }

        public void ShowModificarProfesor(Profesor Profesor_modif)
        {
            ShowInfoProfesorInForm(Profesor_modif, null);
        }

        private void ShowInfoProfesorInForm(Profesor Profesor_modif, FormBase Invoker)
        {
            this.OperacionForm = FrmOperacion.frmModificacion;
            _Profesor_modif = Profesor_modif;
            ProfesorLog = Newtonsoft.Json.JsonConvert.SerializeObject(_Profesor_modif);
            // cargar cada control con informacion del Profesor....
            FormBase.ShowDataFromModel(this, Profesor_modif);
            this.InvokerForm = Invoker;
            this.ShowDialog();

        }

        public void ShowIngresoProfesor(FormBase Invoker)
        {
            this.InvokerForm = Invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        public void ShowIngresoProfesor()
        {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }


        private void FrmProfesorAM_Load(object sender, EventArgs e)
        {

        }

        private void DniTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TelefonoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

    }
}
