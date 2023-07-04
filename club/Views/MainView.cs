using clubApp.db; // incluir libreria para poder acceder a los objetos de negocios.
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace clubApp.Views
{
    public partial class MainView : FormBase
    {
        private Usuario _usuarioActual = null;
        private SoundPlayer reproductor;
        public Usuario UsuarioActual
        {
            get { return _usuarioActual; }
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {

        }

        public void ShowUsuario()
        {
            _usuarioActual = Usuario.UsuarioSys;
            StatusInfoUser.Text = String.Format("Usuario: {0} - {1}", _usuarioActual.UsuarioName, _usuarioActual.FechaLogin); ;
            // mostrar los permisos del usuario en base a los roles, leer cada permiso.
            // Recorrer cada item de Menu, para verificar primero los grupos  y luego cada opcion.
            var list = this.menuStrip1.Items.Cast<ToolStripMenuItem>().ToList().Where(t => t.Name.IndexOf("mnu_top") != -1);
            List<Funcion> listFuncUser = UsuarioActual.ListadoFunciones;
            bool prmOK = false;
            foreach (var item in list)
            {
                // verificar el permiso puede incluir listado hacer split.
                prmOK = false;
                string perm = item.Tag.ToString();
                string[] listFunciones = perm.Split(',');
                for (int i = 0; i < listFunciones.Length; i++)
                {
                    prmOK = prmOK || listFuncUser.Find(ff => ff.Nombre == listFunciones[i]) != null;
                }
                item.Enabled = prmOK;
                //por cada ItemPrincipal, verificar los SubItems por debajo si tiene permiso.

                var list_subitm = item.DropDownItems.Cast<ToolStripMenuItem>().ToList();

                foreach (var subitm in list_subitm)
                {
                    prmOK = false;
                    string permsub = subitm.Tag.ToString();
                    string[] listFuncionesSub = permsub.Split(',');
                    for (int i = 0; i < listFuncionesSub.Length; i++)
                    {
                        prmOK = prmOK || listFuncUser.Find(ff => ff.Nombre == listFuncionesSub[i]) != null;
                    }
                    subitm.Enabled = prmOK;
                }
            }
            // aplicar permiso a cada submenu.

            this.Visible = true;
        }
        private static readonly MainView instance = new MainView();
        static MainView()
        {

        }
        private MainView()
        {
            InitializeComponent();
        }
        // Implementacion de Patron Singleton
        public static MainView Instance
        {
            get
            {
                return instance;
            }
        }

        public void ShowMain(FrmLogin loginFrm, Usuario user)
        {
            loginFrm.Dispose();
            loginFrm = null;
            _usuarioActual = user;
            this.Show();
        }
        private void MainView_Load(object sender, EventArgs e)
        {
            FrmLogin frmLogin;
            if (_usuarioActual == null)
            {
                this.Visible = false;
                frmLogin = new FrmLogin();
                frmLogin.ShowDialog();
                if (_usuarioActual == null)
                {
                    Application.Exit();
                    return;
                }
                this.Visible = true;
                string rutaCancion =Environment.CurrentDirectory + "/cancionMarado8bits.wav";
                reproductor = new SoundPlayer(rutaCancion);
            }
        }

        private void IngresoEspecialidadMnu_Click(object sender, EventArgs e)
        {

        }

        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                MessageBox.Show("Operacion realizada correctamente ", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Verificar si hay Form de Listado para poder actualizar la lista de datos..
            }
            else
            {
                MessageBox.Show("Ocurrio un error: " + ev.Mensaje, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IngresoSocioMnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmSocioAM frm = new FrmSocioAM();
            frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
            frm.ShowIngresoSocio(this);
        }

        private void BuscarSocioMnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmSocioBusq frm = new FrmSocioBusq();
            frm.ShowBuscar();
        }

        private void ListadoSocioMnu_Click(object sender, EventArgs e)
        {
            FrmListadoSocios frmListPac = new FrmListadoSocios();
            frmListPac.Show();
        }

        private void ListadoProfesors_Click(object sender, EventArgs e)
        {
            FrmListadoProfesores frm = new FrmListadoProfesores();
            frm.Show();
        }

        private void IngresoProfesor_Click(object sender, EventArgs e)
        {
            FrmProfesorAM frm = new FrmProfesorAM();
            frm.ShowIngresoProfesor();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProfesorBusq frm = new FrmProfesorBusq();
            frm.ShowBuscar();
        }


        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            string rutaCancion = Environment.CurrentDirectory + "/grandeDiegoSonido.wav";
            reproductor = new SoundPlayer(rutaCancion);
            reproductor.Play();
            if (MessageBox.Show("Desea salir del sistema?", "salida..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
                return;
            }
            e.Cancel = true;
        }

        public void ShowBuscar()
        {

        }

        private void LocalidadAM_mnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmLocalidadAM frm = new FrmLocalidadAM();
            frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
            frm.ShowIngresoLocalidad(this);
        }

        private void BuscarLocalidad_mnu_Click(object sender, EventArgs e)
        {
            FrmLocalidadBusq f = new FrmLocalidadBusq();
            f.ShowBuscar();
        }

        private void localidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmListadoLocalidad f = new FrmListadoLocalidad();
            f.Show();
        }

        private void ingresoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buscarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void HorariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoCuotas f = new FrmListadoCuotas();
            f.Show();
        }

        private void BuscarCuota_mnu_Click(object sender, EventArgs e)
        {
            FrmCuotaBusq f = new FrmCuotaBusq();
            f.ShowBuscar();
        }

        private void CuotaAM_mnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmCuotaAM frm = new FrmCuotaAM();
            frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
            frm.ShowIngresoCuota(this);
        }

        private void CuotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoCuotas f = new FrmListadoCuotas();
            f.Show();
        }

        private void ActividadAM_mnu_Click(object sender, EventArgs e)
        {
            FrmActividadAM f = new FrmActividadAM();
            f.Show();
        }

        private void BuscarActividad_mnu_Click(object sender, EventArgs e)
        {
            FrmActividadBusq f = new FrmActividadBusq();
            f.Show();
        }

        private void BuscarTipoAct_mnu_Click(object sender, EventArgs e)
        {

        }

        private void TipoActivAM_mnu_Click(object sender, EventArgs e)
        {

        }

        private void Cuotas_mnu_top_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void generarCutoasMensualesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Cuota> listaCuotasExistentes = Cuota.FindAllStatic(null, null);
            List<Cuota> listaCuotasCreadas = new List<Cuota>();
            List<Socio> listaSocios = Socio.FindAllStatic("activo = true", null);
            foreach (Socio socAux in listaSocios)
            {
                string criterio = string.Format("nro_socio = {0} and fecha_fin < fecha_inicio ", socAux.NroSocio);
                List<ActividadSocio> listaActividades = ActividadSocio.FindAllStatic(criterio, null);
                if (listaActividades.Count > 0)
                {
                    foreach (ActividadSocio actSocAux in listaActividades)
                    {
                        criterio = string.Format("cod_tipo_act = {0}", actSocAux.ActividadObj.CodTipoActividad);
                        //float importe = ImporteActividad.FindAllStatic(criterio, null)[0].Importe;
                        Cuota cuotaAux = new Cuota();
                        cuotaAux.Importe = new Random().Next(100,2000);
                        cuotaAux.Anio = DateTime.Now.Year;
                        cuotaAux.Mes = DateTime.Now.Month;
                        cuotaAux.CodActSocio = actSocAux.Id;
                        cuotaAux.Estado = "i";
                        cuotaAux.FechaVenc = DateTime.Now.AddMonths(1);
                        if (!listaCuotasExistentes.Contains(cuotaAux))
                        {
                            listaCuotasCreadas.Add(cuotaAux);
                        }
                    }
                }

            }
            MessageBox.Show(string.Format("Se crearon {0} cuotas", listaCuotasCreadas.Count), "Cuotas Procesadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            foreach (Cuota aux in listaCuotasCreadas)
            {
                aux.SaveObj();
            }
        }

        private void ActividadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmListadoActividades().Show();
        }

        private void AcercaDe_mnu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Agustin Coronel\n Agustin Bowen \n Adrian Griffiths", "Creadores",MessageBoxButtons.OK);
            Form1 f = new Form1();
            f.Show();
        }

        private void pagarCuotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione la Cuota que desea Pagar","Pagar Cuota",MessageBoxButtons.OK);
            new FrmListadoCuotas().ShowListar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reproductor.Stop();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string rutaCancion = Environment.CurrentDirectory + "/cancionMarado8bits.wav";
            reproductor = new SoundPlayer(rutaCancion);
            reproductor.PlayLooping();
        }
    }
}
