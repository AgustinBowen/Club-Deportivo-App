﻿using clubApp.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clubApp.Views
{
    [Permiso(ClaseBaseForm = "Cuota", FuncionPermiso = "AltaCuota,ModificarCuota,ConsultaCuota", RolUsuario = "administrador,operadorConsulta,consulta,operador")]
    public partial class FrmCuotaAM : FormBase
    {
        public override event FormEvent DoCompleteOperationForm;
        private Cuota _Cuota_modif = null;
        private string CuotaLog = "";
        public FrmCuotaAM()
        {
            InitializeComponent();
        }

        public void ShowBuscar()
        {
            this.Show();
        }

        private void LoadCombos()
        {

            var listaActividades = ActividadSocio.FindAllStatic(null, (act1, act2) => act1.NroSocio.CompareTo(act2.NroSocio));

            this.ActSocioCbo.DataSource = ActividadSocio.FindAllStatic(null, (act1, act2) => act1.NroSocio.CompareTo(act2.NroSocio));

            //this.ActSocioCbo.DataSource = ORMDB<ActividadSocio>.FindAll(null);
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
                LoadCombos();
                if (value == FrmOperacion.frmAlta)
                {
                    this.Text = "Ingreso de nueva Cuota...";
                }
                if (value == FrmOperacion.frmModificacion)
                {
                    this.Text = "Actualizacion de datos de Cuota...";
                }
                if (value == FrmOperacion.frmConsulta)
                {
                    this.Text = "Consulta de datos de Cuota...";
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
            Cuota cuota = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog = "";
            MainView.Instance.Cursor = Cursors.WaitCursor;

            if (OperacionForm == FrmOperacion.frmAlta)
            {
                cuota = new Cuota();
                operacionLog = "ALTA";
                // cargar la info de la Socio antes de dar de alta.
            }
            if (OperacionForm == FrmOperacion.frmModificacion)
            {
                operacionLog = "MODIFICACION";
                cuota = _Cuota_modif;
                detalleLog = "OBJ-Antes:" + CuotaLog + " - OBJ-MOD";
            }

            if (ImporteTxt.Text == "")
            {
                MessageBox.Show("Ingrese importe", "Dato(s) faltante(s)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ImporteTxt.Focus();
                return;
            }

            if (AnioTxt.Text == "")
            {
                MessageBox.Show("Ingrese año", "Dato(s) faltante(s)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                AnioTxt.Focus();
                return;
            }

            if (MesTxt.Text == "")
            {
                MessageBox.Show("Ingrese mes", "Dato(s) faltante(s)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MesTxt.Focus();
                return;
            }

            if (EstadoTxt.Text == "")
            {
                MessageBox.Show("Ingrese estado", "Dato(s) faltante(s)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                EstadoTxt.Focus();
                return;
            }

            if (FechaVencimientoPicker.Text == "")
            {
                MessageBox.Show("Ingrese fecha vencimiento", "Dato(s) faltante(s)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                FechaVencimientoPicker.Focus();
                return;
            }

            cuota = new Cuota();
            cuota.Estado = EstadoTxt.Text;

            try
            {
                cuota.Importe = float.Parse(ImporteTxt.Text);
                cuota.Anio = Convert.ToInt32(AnioTxt.Text);
                cuota.Mes = Convert.ToInt32(MesTxt.Text);
                cuota.FechaVenc = Convert.ToDateTime(FechaVencimientoPicker.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("error formato erroneo en importe,año,mes o fecha vencimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(cuota);
            // intentar guardar en la Base de datos.
            try
            {
                cuota.SaveObj();
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
                    DoCompleteOperationForm(cuota, new EventArgDom { ObjProcess = cuota, Status = TipoOperacionStatus.stOK });
                else
                    DoCompleteOperationForm(cuota, new EventArgDom { ObjProcess = cuota, Mensaje = errMsj, Status = TipoOperacionStatus.stError });
            }

            if (this.InvokerForm != null)
            {
                InvokerForm.Reload();
            }
            MainView.Instance.Cursor = Cursors.Default;
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.FechaVencimientoPicker.Value = FechaVencimientoPicker.Value;
        }

        public void ShowIngresoCuota(FormBase Invoker)
        {
            this.InvokerForm = Invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }
        public void ShowIngresoCuota()
        {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        public void ShowModificarCuota(FormBase Invoker, Cuota Pac_modif)
        {
            ShowInfoCuotaInForm(Pac_modif, Invoker);
        }
        public void ShowModificarSocio(Cuota Pac_modif)
        {
            ShowInfoCuotaInForm(Pac_modif, null);
        }

        private void ShowInfoCuotaInForm(Cuota Cuo_modif, FormBase Invoker)
        {
            this.OperacionForm = FrmOperacion.frmModificacion;
            _Cuota_modif = Cuo_modif;
            CuotaLog = Newtonsoft.Json.JsonConvert.SerializeObject(_Cuota_modif);
            // cargar cada control con informacion de la cuota....
            //this.ApellidoTxt.Text = Pac_modif.Apellido; //ESTO ES UN EJEMPLO NOMAS
            FormBase.ShowDataFromModel(this, Cuo_modif);
            this.InvokerForm = Invoker;
            this.CancelarBtn.Click += new EventHandler(CancelarBtn_Click);
            this.ShowDialog();
        }

        private void FrmCuotaAM_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;
        }

        private void ActSocioCbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
