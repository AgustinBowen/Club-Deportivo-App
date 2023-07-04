﻿namespace clubApp.Views
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Socios_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.SocioAM_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarSocioMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.Profesors_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfesorAM_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarProfesor_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.TipoActividad_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.TipoActivAM_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarTipoAct_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.Localidades_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.LocalidadAM_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarLocalidad_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.Actividad_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.ActividadAM_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarActividad_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.Cuotas_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.CuotaAM_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarCuota_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.generarCutoasMensualesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagarCuotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImporteActiv_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.ImporteActivAM_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarImporteActiv_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.HorarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Listados_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.SociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfesorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localidadesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ActividadesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.HorariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CuotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TipoActividadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Estadisticas_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfesorsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.centroAtencionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AcercaDe_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.StatusInfoUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CancionBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Socios_mnu_top,
            this.Profesors_mnu_top,
            this.TipoActividad_mnu_top,
            this.Localidades_mnu_top,
            this.Actividad_mnu_top,
            this.Cuotas_mnu_top,
            this.ImporteActiv_mnu_top,
            this.HorarioToolStripMenuItem,
            this.Listados_mnu_top,
            this.Estadisticas_mnu_top,
            this.AcercaDe_mnu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1119, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Socios_mnu_top
            // 
            this.Socios_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SocioAM_mnu,
            this.BuscarSocioMnu});
            this.Socios_mnu_top.Name = "Socios_mnu_top";
            this.Socios_mnu_top.Size = new System.Drawing.Size(53, 20);
            this.Socios_mnu_top.Tag = "AltaSocio,ModificaSocio,ConsultaSocio";
            this.Socios_mnu_top.Text = "Socios";
            // 
            // SocioAM_mnu
            // 
            this.SocioAM_mnu.Name = "SocioAM_mnu";
            this.SocioAM_mnu.Size = new System.Drawing.Size(118, 22);
            this.SocioAM_mnu.Tag = "AltaSocio";
            this.SocioAM_mnu.Text = "Ingreso";
            this.SocioAM_mnu.Click += new System.EventHandler(this.IngresoSocioMnu_Click);
            // 
            // BuscarSocioMnu
            // 
            this.BuscarSocioMnu.Name = "BuscarSocioMnu";
            this.BuscarSocioMnu.Size = new System.Drawing.Size(118, 22);
            this.BuscarSocioMnu.Tag = "ModificaSocio,ConsultaSocio";
            this.BuscarSocioMnu.Text = "Buscar...";
            this.BuscarSocioMnu.Click += new System.EventHandler(this.BuscarSocioMnu_Click);
            // 
            // Profesors_mnu_top
            // 
            this.Profesors_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProfesorAM_mnu,
            this.BuscarProfesor_mnu});
            this.Profesors_mnu_top.Name = "Profesors_mnu_top";
            this.Profesors_mnu_top.Size = new System.Drawing.Size(74, 20);
            this.Profesors_mnu_top.Tag = "AltaProfesor,ModificaProfesor,ConsultaProfesor";
            this.Profesors_mnu_top.Text = "Profesores";
            // 
            // ProfesorAM_mnu
            // 
            this.ProfesorAM_mnu.Name = "ProfesorAM_mnu";
            this.ProfesorAM_mnu.Size = new System.Drawing.Size(113, 22);
            this.ProfesorAM_mnu.Tag = "AltaProfesor";
            this.ProfesorAM_mnu.Text = "Ingreso";
            this.ProfesorAM_mnu.Click += new System.EventHandler(this.IngresoProfesor_Click);
            // 
            // BuscarProfesor_mnu
            // 
            this.BuscarProfesor_mnu.Name = "BuscarProfesor_mnu";
            this.BuscarProfesor_mnu.Size = new System.Drawing.Size(113, 22);
            this.BuscarProfesor_mnu.Tag = "ModificaProfesor,ConsultaProfesor";
            this.BuscarProfesor_mnu.Text = "Buscar";
            this.BuscarProfesor_mnu.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // TipoActividad_mnu_top
            // 
            this.TipoActividad_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TipoActivAM_mnu,
            this.BuscarTipoAct_mnu});
            this.TipoActividad_mnu_top.Name = "TipoActividad_mnu_top";
            this.TipoActividad_mnu_top.Size = new System.Drawing.Size(111, 20);
            this.TipoActividad_mnu_top.Tag = "AltaTipoActividad,ModificaTipoActividad,ConsultaTipoActividad";
            this.TipoActividad_mnu_top.Text = "Tipos Actividades";
            // 
            // TipoActivAM_mnu
            // 
            this.TipoActivAM_mnu.Name = "TipoActivAM_mnu";
            this.TipoActivAM_mnu.Size = new System.Drawing.Size(113, 22);
            this.TipoActivAM_mnu.Tag = "AltaTipoActividad";
            this.TipoActivAM_mnu.Text = "Ingreso";
            this.TipoActivAM_mnu.Click += new System.EventHandler(this.TipoActivAM_mnu_Click);
            // 
            // BuscarTipoAct_mnu
            // 
            this.BuscarTipoAct_mnu.Name = "BuscarTipoAct_mnu";
            this.BuscarTipoAct_mnu.Size = new System.Drawing.Size(113, 22);
            this.BuscarTipoAct_mnu.Tag = "ModificaTipoActividad,ConsultaTipoActividad";
            this.BuscarTipoAct_mnu.Text = "Buscar";
            this.BuscarTipoAct_mnu.Click += new System.EventHandler(this.BuscarTipoAct_mnu_Click);
            // 
            // Localidades_mnu_top
            // 
            this.Localidades_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LocalidadAM_mnu,
            this.BuscarLocalidad_mnu});
            this.Localidades_mnu_top.Name = "Localidades_mnu_top";
            this.Localidades_mnu_top.Size = new System.Drawing.Size(81, 20);
            this.Localidades_mnu_top.Tag = "AltaLocalidad,ModificaLocalidad,ConsultaLocalidad";
            this.Localidades_mnu_top.Text = "Localidades";
            // 
            // LocalidadAM_mnu
            // 
            this.LocalidadAM_mnu.Name = "LocalidadAM_mnu";
            this.LocalidadAM_mnu.Size = new System.Drawing.Size(113, 22);
            this.LocalidadAM_mnu.Tag = "AltaLocalidad";
            this.LocalidadAM_mnu.Text = "Ingreso";
            this.LocalidadAM_mnu.Click += new System.EventHandler(this.LocalidadAM_mnu_Click);
            // 
            // BuscarLocalidad_mnu
            // 
            this.BuscarLocalidad_mnu.Name = "BuscarLocalidad_mnu";
            this.BuscarLocalidad_mnu.Size = new System.Drawing.Size(113, 22);
            this.BuscarLocalidad_mnu.Tag = "ModificaLocalidad,ConsultaLocalidad";
            this.BuscarLocalidad_mnu.Text = "Buscar";
            this.BuscarLocalidad_mnu.Click += new System.EventHandler(this.BuscarLocalidad_mnu_Click);
            // 
            // Actividad_mnu_top
            // 
            this.Actividad_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActividadAM_mnu,
            this.BuscarActividad_mnu});
            this.Actividad_mnu_top.Name = "Actividad_mnu_top";
            this.Actividad_mnu_top.Size = new System.Drawing.Size(80, 20);
            this.Actividad_mnu_top.Tag = "AltaActividad,ModificaActividad,ConsultaActividad";
            this.Actividad_mnu_top.Text = "Actividades";
            // 
            // ActividadAM_mnu
            // 
            this.ActividadAM_mnu.Name = "ActividadAM_mnu";
            this.ActividadAM_mnu.Size = new System.Drawing.Size(113, 22);
            this.ActividadAM_mnu.Tag = "AltaActividad";
            this.ActividadAM_mnu.Text = "Ingreso";
            this.ActividadAM_mnu.Click += new System.EventHandler(this.ActividadAM_mnu_Click);
            // 
            // BuscarActividad_mnu
            // 
            this.BuscarActividad_mnu.Name = "BuscarActividad_mnu";
            this.BuscarActividad_mnu.Size = new System.Drawing.Size(113, 22);
            this.BuscarActividad_mnu.Tag = "ModificaActividad,ConsultaActividad";
            this.BuscarActividad_mnu.Text = "Buscar";
            this.BuscarActividad_mnu.Click += new System.EventHandler(this.BuscarActividad_mnu_Click);
            // 
            // Cuotas_mnu_top
            // 
            this.Cuotas_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CuotaAM_mnu,
            this.BuscarCuota_mnu,
            this.generarCutoasMensualesToolStripMenuItem,
            this.pagarCuotaToolStripMenuItem});
            this.Cuotas_mnu_top.Name = "Cuotas_mnu_top";
            this.Cuotas_mnu_top.Size = new System.Drawing.Size(56, 20);
            this.Cuotas_mnu_top.Tag = "AltaCuota,ModificaCuota,ConsultaCuota";
            this.Cuotas_mnu_top.Text = "Cuotas";
            this.Cuotas_mnu_top.Click += new System.EventHandler(this.Cuotas_mnu_top_Click);
            // 
            // CuotaAM_mnu
            // 
            this.CuotaAM_mnu.Name = "CuotaAM_mnu";
            this.CuotaAM_mnu.Size = new System.Drawing.Size(214, 22);
            this.CuotaAM_mnu.Tag = "AltaCuota";
            this.CuotaAM_mnu.Text = "Ingreso";
            this.CuotaAM_mnu.Click += new System.EventHandler(this.CuotaAM_mnu_Click);
            // 
            // BuscarCuota_mnu
            // 
            this.BuscarCuota_mnu.Name = "BuscarCuota_mnu";
            this.BuscarCuota_mnu.Size = new System.Drawing.Size(214, 22);
            this.BuscarCuota_mnu.Tag = "ModificaCuota,ConsultaCuota";
            this.BuscarCuota_mnu.Text = "Buscar";
            this.BuscarCuota_mnu.Click += new System.EventHandler(this.BuscarCuota_mnu_Click);
            // 
            // generarCutoasMensualesToolStripMenuItem
            // 
            this.generarCutoasMensualesToolStripMenuItem.Name = "generarCutoasMensualesToolStripMenuItem";
            this.generarCutoasMensualesToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.generarCutoasMensualesToolStripMenuItem.Tag = "AltaCuota";
            this.generarCutoasMensualesToolStripMenuItem.Text = "Generar Cutoas Mensuales";
            this.generarCutoasMensualesToolStripMenuItem.Click += new System.EventHandler(this.generarCutoasMensualesToolStripMenuItem_Click);
            // 
            // pagarCuotaToolStripMenuItem
            // 
            this.pagarCuotaToolStripMenuItem.Name = "pagarCuotaToolStripMenuItem";
            this.pagarCuotaToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.pagarCuotaToolStripMenuItem.Tag = "AltaCuota";
            this.pagarCuotaToolStripMenuItem.Text = "Pagar Cuota";
            this.pagarCuotaToolStripMenuItem.Click += new System.EventHandler(this.pagarCuotaToolStripMenuItem_Click);
            // 
            // ImporteActiv_mnu_top
            // 
            this.ImporteActiv_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImporteActivAM_mnu,
            this.BuscarImporteActiv_mnu});
            this.ImporteActiv_mnu_top.Name = "ImporteActiv_mnu_top";
            this.ImporteActiv_mnu_top.Size = new System.Drawing.Size(114, 20);
            this.ImporteActiv_mnu_top.Tag = "AltaImporteActividad,ModificaImporteActividad,ConsultaImporteActividad";
            this.ImporteActiv_mnu_top.Text = "Importe Actividad";
            // 
            // ImporteActivAM_mnu
            // 
            this.ImporteActivAM_mnu.Name = "ImporteActivAM_mnu";
            this.ImporteActivAM_mnu.Size = new System.Drawing.Size(113, 22);
            this.ImporteActivAM_mnu.Tag = "AltaImporteActividad";
            this.ImporteActivAM_mnu.Text = "Ingreso";
            // 
            // BuscarImporteActiv_mnu
            // 
            this.BuscarImporteActiv_mnu.Name = "BuscarImporteActiv_mnu";
            this.BuscarImporteActiv_mnu.Size = new System.Drawing.Size(113, 22);
            this.BuscarImporteActiv_mnu.Tag = "ModificaImporteActividad,ConsultaImporteActividad";
            this.BuscarImporteActiv_mnu.Text = "Buscar";
            // 
            // HorarioToolStripMenuItem
            // 
            this.HorarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoToolStripMenuItem,
            this.buscarToolStripMenuItem});
            this.HorarioToolStripMenuItem.Name = "HorarioToolStripMenuItem";
            this.HorarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.HorarioToolStripMenuItem.Tag = "AltaHorario,ModificaHorario,ConsultaHorario";
            this.HorarioToolStripMenuItem.Text = "Horario";
            // 
            // ingresoToolStripMenuItem
            // 
            this.ingresoToolStripMenuItem.Name = "ingresoToolStripMenuItem";
            this.ingresoToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.ingresoToolStripMenuItem.Tag = "AltaHorario";
            this.ingresoToolStripMenuItem.Text = "Ingreso";
            this.ingresoToolStripMenuItem.Click += new System.EventHandler(this.ingresoToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.buscarToolStripMenuItem.Tag = "ModificaHorario,ConsultaHorario";
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click_1);
            // 
            // Listados_mnu_top
            // 
            this.Listados_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SociosToolStripMenuItem,
            this.ProfesorsToolStripMenuItem,
            this.localidadesToolStripMenuItem1,
            this.ActividadesToolStripMenuItem1,
            this.HorariosToolStripMenuItem,
            this.auditoriaToolStripMenuItem,
            this.CuotaToolStripMenuItem,
            this.TipoActividadToolStripMenuItem1});
            this.Listados_mnu_top.Name = "Listados_mnu_top";
            this.Listados_mnu_top.Size = new System.Drawing.Size(62, 20);
            this.Listados_mnu_top.Tag = "Listados";
            this.Listados_mnu_top.Text = "Listados";
            // 
            // SociosToolStripMenuItem
            // 
            this.SociosToolStripMenuItem.Name = "SociosToolStripMenuItem";
            this.SociosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.SociosToolStripMenuItem.Tag = "ConsultaSocio";
            this.SociosToolStripMenuItem.Text = "Socios";
            this.SociosToolStripMenuItem.Click += new System.EventHandler(this.ListadoSocioMnu_Click);
            // 
            // ProfesorsToolStripMenuItem
            // 
            this.ProfesorsToolStripMenuItem.Name = "ProfesorsToolStripMenuItem";
            this.ProfesorsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.ProfesorsToolStripMenuItem.Tag = "ConsultaProfesor";
            this.ProfesorsToolStripMenuItem.Text = "Profesor";
            this.ProfesorsToolStripMenuItem.Click += new System.EventHandler(this.ListadoProfesors_Click);
            // 
            // localidadesToolStripMenuItem1
            // 
            this.localidadesToolStripMenuItem1.Name = "localidadesToolStripMenuItem1";
            this.localidadesToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.localidadesToolStripMenuItem1.Tag = "ConsultaLocalidad";
            this.localidadesToolStripMenuItem1.Text = "Localidades";
            this.localidadesToolStripMenuItem1.Click += new System.EventHandler(this.localidadesToolStripMenuItem1_Click);
            // 
            // ActividadesToolStripMenuItem1
            // 
            this.ActividadesToolStripMenuItem1.Name = "ActividadesToolStripMenuItem1";
            this.ActividadesToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.ActividadesToolStripMenuItem1.Tag = "ConsultaActividad";
            this.ActividadesToolStripMenuItem1.Text = "Actividades";
            this.ActividadesToolStripMenuItem1.Click += new System.EventHandler(this.ActividadesToolStripMenuItem1_Click);
            // 
            // HorariosToolStripMenuItem
            // 
            this.HorariosToolStripMenuItem.Name = "HorariosToolStripMenuItem";
            this.HorariosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.HorariosToolStripMenuItem.Tag = "ConsultaHorario";
            this.HorariosToolStripMenuItem.Text = "Horarios";
            this.HorariosToolStripMenuItem.Click += new System.EventHandler(this.HorariosToolStripMenuItem_Click);
            // 
            // auditoriaToolStripMenuItem
            // 
            this.auditoriaToolStripMenuItem.Name = "auditoriaToolStripMenuItem";
            this.auditoriaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.auditoriaToolStripMenuItem.Tag = "ConsultaAuditoria";
            this.auditoriaToolStripMenuItem.Text = "Auditoria";
            // 
            // CuotaToolStripMenuItem
            // 
            this.CuotaToolStripMenuItem.Name = "CuotaToolStripMenuItem";
            this.CuotaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.CuotaToolStripMenuItem.Tag = "ConsultaCuota";
            this.CuotaToolStripMenuItem.Text = "Cuota";
            this.CuotaToolStripMenuItem.Click += new System.EventHandler(this.CuotaToolStripMenuItem_Click);
            // 
            // TipoActividadToolStripMenuItem1
            // 
            this.TipoActividadToolStripMenuItem1.Name = "TipoActividadToolStripMenuItem1";
            this.TipoActividadToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.TipoActividadToolStripMenuItem1.Tag = "ConsultaTipoActividad";
            this.TipoActividadToolStripMenuItem1.Text = "Tipo Actividad";
            // 
            // Estadisticas_mnu_top
            // 
            this.Estadisticas_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProfesorsToolStripMenuItem1,
            this.centroAtencionToolStripMenuItem1});
            this.Estadisticas_mnu_top.Name = "Estadisticas_mnu_top";
            this.Estadisticas_mnu_top.Size = new System.Drawing.Size(79, 20);
            this.Estadisticas_mnu_top.Tag = "Estadisticas";
            this.Estadisticas_mnu_top.Text = "Estadísticas";
            this.Estadisticas_mnu_top.Visible = false;
            // 
            // ProfesorsToolStripMenuItem1
            // 
            this.ProfesorsToolStripMenuItem1.Name = "ProfesorsToolStripMenuItem1";
            this.ProfesorsToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.ProfesorsToolStripMenuItem1.Tag = "ConsultaMascota";
            this.ProfesorsToolStripMenuItem1.Text = "Mascotas";
            // 
            // centroAtencionToolStripMenuItem1
            // 
            this.centroAtencionToolStripMenuItem1.Name = "centroAtencionToolStripMenuItem1";
            this.centroAtencionToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.centroAtencionToolStripMenuItem1.Tag = "ConsultaCentroAtencion";
            this.centroAtencionToolStripMenuItem1.Text = "Centro Atencion";
            // 
            // AcercaDe_mnu
            // 
            this.AcercaDe_mnu.Name = "AcercaDe_mnu";
            this.AcercaDe_mnu.Size = new System.Drawing.Size(80, 20);
            this.AcercaDe_mnu.Text = "Acerca de...";
            this.AcercaDe_mnu.Click += new System.EventHandler(this.AcercaDe_mnu_Click);
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusInfoUser});
            this.status.Location = new System.Drawing.Point(0, 634);
            this.status.Name = "status";
            this.status.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.status.Size = new System.Drawing.Size(1119, 22);
            this.status.TabIndex = 1;
            this.status.Text = "statusStrip1";
            // 
            // StatusInfoUser
            // 
            this.StatusInfoUser.Name = "StatusInfoUser";
            this.StatusInfoUser.Size = new System.Drawing.Size(0, 17);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::clubApp.Properties.Resources.mainMaradona;
            this.pictureBox1.Location = new System.Drawing.Point(818, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::clubApp.Properties.Resources.firmaMarado;
            this.pictureBox2.Location = new System.Drawing.Point(935, 307);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // CancionBtn
            // 
            this.CancionBtn.Location = new System.Drawing.Point(170, 565);
            this.CancionBtn.Name = "CancionBtn";
            this.CancionBtn.Size = new System.Drawing.Size(152, 47);
            this.CancionBtn.TabIndex = 7;
            this.CancionBtn.Text = "Parar reproduccion";
            this.CancionBtn.UseVisualStyleBackColor = true;
            this.CancionBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "Reproducir cancion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1119, 656);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CancionBtn);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClubApp: Registro de información";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.Load += new System.EventHandler(this.MainView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripMenuItem Socios_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem SocioAM_mnu;
        private System.Windows.Forms.ToolStripMenuItem BuscarSocioMnu;
        private System.Windows.Forms.ToolStripMenuItem Profesors_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem ProfesorAM_mnu;
        private System.Windows.Forms.ToolStripMenuItem BuscarProfesor_mnu;
        private System.Windows.Forms.ToolStripMenuItem TipoActividad_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem Localidades_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem Cuotas_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem ImporteActiv_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem TipoActivAM_mnu;
        private System.Windows.Forms.ToolStripMenuItem LocalidadAM_mnu;
        private System.Windows.Forms.ToolStripMenuItem CuotaAM_mnu;
        private System.Windows.Forms.ToolStripMenuItem ImporteActivAM_mnu;
        private System.Windows.Forms.ToolStripMenuItem Listados_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem SociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProfesorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BuscarTipoAct_mnu;
        private System.Windows.Forms.ToolStripMenuItem localidadesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ActividadesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem HorariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Estadisticas_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem ProfesorsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel StatusInfoUser;
        private System.Windows.Forms.ToolStripMenuItem CuotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BuscarLocalidad_mnu;
        private System.Windows.Forms.ToolStripMenuItem Actividad_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem ActividadAM_mnu;
        private System.Windows.Forms.ToolStripMenuItem BuscarActividad_mnu;
        private System.Windows.Forms.ToolStripMenuItem BuscarCuota_mnu;
        private System.Windows.Forms.ToolStripMenuItem BuscarImporteActiv_mnu;
        private System.Windows.Forms.ToolStripMenuItem centroAtencionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AcercaDe_mnu;
        private System.Windows.Forms.ToolStripMenuItem HorarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TipoActividadToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem generarCutoasMensualesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagarCuotaToolStripMenuItem;
        private System.Windows.Forms.Button CancionBtn;
        private System.Windows.Forms.Button button1;
    }
}