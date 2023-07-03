namespace clubApp.Views
{
    partial class FrmListadoActividades
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoActividades));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.actividadGrd = new System.Windows.Forms.DataGridView();
            this.CodActividadCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodTipoActCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LegajoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDesdeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHastaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportarBtn = new System.Windows.Forms.Button();
            this.FiltroBtn = new System.Windows.Forms.Button();
            this.FechaHastaPicker = new System.Windows.Forms.DateTimePicker();
            this.FechaDesdePicker = new System.Windows.Forms.DateTimePicker();
            this.FechaFinChk = new System.Windows.Forms.CheckBox();
            this.FechaInicioChk = new System.Windows.Forms.CheckBox();
            this.profesorCHK = new System.Windows.Forms.CheckBox();
            this.tipoActividadCHK = new System.Windows.Forms.CheckBox();
            this.comboProfesor = new System.Windows.Forms.ComboBox();
            this.comboCodTipoActividad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actividadGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.actividadGrd);
            this.groupBox1.Location = new System.Drawing.Point(11, 85);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(581, 266);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // actividadGrd
            // 
            this.actividadGrd.AllowUserToAddRows = false;
            this.actividadGrd.AllowUserToDeleteRows = false;
            this.actividadGrd.AllowUserToResizeColumns = false;
            this.actividadGrd.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.actividadGrd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.actividadGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actividadGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodActividadCol,
            this.CodTipoActCol,
            this.LegajoCol,
            this.FechaDesdeCol,
            this.FechaHastaCol});
            this.actividadGrd.Location = new System.Drawing.Point(4, 17);
            this.actividadGrd.Margin = new System.Windows.Forms.Padding(2);
            this.actividadGrd.MultiSelect = false;
            this.actividadGrd.Name = "actividadGrd";
            this.actividadGrd.ReadOnly = true;
            this.actividadGrd.RowTemplate.Height = 24;
            this.actividadGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.actividadGrd.Size = new System.Drawing.Size(561, 237);
            this.actividadGrd.TabIndex = 0;
            this.actividadGrd.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.actividadGrd_CellContentDoubleClick);
            this.actividadGrd.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.actividadGrd_ColumnHeaderMouseClick);
            // 
            // CodActividadCol
            // 
            this.CodActividadCol.DataPropertyName = "Id";
            this.CodActividadCol.HeaderText = "Codigo actividad";
            this.CodActividadCol.Name = "CodActividadCol";
            this.CodActividadCol.ReadOnly = true;
            // 
            // CodTipoActCol
            // 
            this.CodTipoActCol.DataPropertyName = "CodTipoActividad";
            this.CodTipoActCol.HeaderText = "Codigo tipo actividad";
            this.CodTipoActCol.Name = "CodTipoActCol";
            this.CodTipoActCol.ReadOnly = true;
            // 
            // LegajoCol
            // 
            this.LegajoCol.DataPropertyName = "LegajoProfe";
            this.LegajoCol.HeaderText = "Legajo profeosor";
            this.LegajoCol.Name = "LegajoCol";
            this.LegajoCol.ReadOnly = true;
            // 
            // FechaDesdeCol
            // 
            this.FechaDesdeCol.DataPropertyName = "FechaDesde";
            this.FechaDesdeCol.HeaderText = "Fecha desde";
            this.FechaDesdeCol.Name = "FechaDesdeCol";
            this.FechaDesdeCol.ReadOnly = true;
            // 
            // FechaHastaCol
            // 
            this.FechaHastaCol.DataPropertyName = "FechaHasta";
            this.FechaHastaCol.HeaderText = "Fecha hasta";
            this.FechaHastaCol.Name = "FechaHastaCol";
            this.FechaHastaCol.ReadOnly = true;
            // 
            // ExportarBtn
            // 
            this.ExportarBtn.Location = new System.Drawing.Point(630, 318);
            this.ExportarBtn.Name = "ExportarBtn";
            this.ExportarBtn.Size = new System.Drawing.Size(76, 33);
            this.ExportarBtn.TabIndex = 15;
            this.ExportarBtn.Text = "Exportar";
            this.ExportarBtn.UseVisualStyleBackColor = false;
            this.ExportarBtn.Click += new System.EventHandler(this.ExportarBtn_Click);
            // 
            // FiltroBtn
            // 
            this.FiltroBtn.Location = new System.Drawing.Point(632, 11);
            this.FiltroBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FiltroBtn.Name = "FiltroBtn";
            this.FiltroBtn.Size = new System.Drawing.Size(76, 32);
            this.FiltroBtn.TabIndex = 20;
            this.FiltroBtn.Text = "Filtrar";
            this.FiltroBtn.UseVisualStyleBackColor = true;
            this.FiltroBtn.Click += new System.EventHandler(this.FiltroBtn_Click);
            // 
            // FechaHastaPicker
            // 
            this.FechaHastaPicker.Enabled = false;
            this.FechaHastaPicker.Location = new System.Drawing.Point(108, 52);
            this.FechaHastaPicker.Name = "FechaHastaPicker";
            this.FechaHastaPicker.Size = new System.Drawing.Size(200, 20);
            this.FechaHastaPicker.TabIndex = 19;
            // 
            // FechaDesdePicker
            // 
            this.FechaDesdePicker.Enabled = false;
            this.FechaDesdePicker.Location = new System.Drawing.Point(108, 11);
            this.FechaDesdePicker.Name = "FechaDesdePicker";
            this.FechaDesdePicker.Size = new System.Drawing.Size(200, 20);
            this.FechaDesdePicker.TabIndex = 18;
            // 
            // FechaFinChk
            // 
            this.FechaFinChk.AutoSize = true;
            this.FechaFinChk.Location = new System.Drawing.Point(15, 52);
            this.FechaFinChk.Margin = new System.Windows.Forms.Padding(2);
            this.FechaFinChk.Name = "FechaFinChk";
            this.FechaFinChk.Size = new System.Drawing.Size(85, 17);
            this.FechaFinChk.TabIndex = 17;
            this.FechaFinChk.Text = "Fecha hasta";
            this.FechaFinChk.UseVisualStyleBackColor = true;
            this.FechaFinChk.CheckedChanged += new System.EventHandler(this.FechaFinChk_CheckedChanged);
            // 
            // FechaInicioChk
            // 
            this.FechaInicioChk.AutoSize = true;
            this.FechaInicioChk.Location = new System.Drawing.Point(15, 14);
            this.FechaInicioChk.Margin = new System.Windows.Forms.Padding(2);
            this.FechaInicioChk.Name = "FechaInicioChk";
            this.FechaInicioChk.Size = new System.Drawing.Size(88, 17);
            this.FechaInicioChk.TabIndex = 16;
            this.FechaInicioChk.Text = "Fecha desde";
            this.FechaInicioChk.UseVisualStyleBackColor = true;
            this.FechaInicioChk.CheckedChanged += new System.EventHandler(this.FechaInicioChk_CheckedChanged);
            // 
            // profesorCHK
            // 
            this.profesorCHK.AutoSize = true;
            this.profesorCHK.Location = new System.Drawing.Point(321, 54);
            this.profesorCHK.Name = "profesorCHK";
            this.profesorCHK.Size = new System.Drawing.Size(15, 14);
            this.profesorCHK.TabIndex = 35;
            this.profesorCHK.UseVisualStyleBackColor = true;
            this.profesorCHK.CheckedChanged += new System.EventHandler(this.profesorCHK_CheckedChanged);
            // 
            // tipoActividadCHK
            // 
            this.tipoActividadCHK.AutoSize = true;
            this.tipoActividadCHK.Location = new System.Drawing.Point(321, 16);
            this.tipoActividadCHK.Name = "tipoActividadCHK";
            this.tipoActividadCHK.Size = new System.Drawing.Size(15, 14);
            this.tipoActividadCHK.TabIndex = 34;
            this.tipoActividadCHK.UseVisualStyleBackColor = true;
            this.tipoActividadCHK.CheckedChanged += new System.EventHandler(this.tipoActividadCHK_CheckedChanged);
            // 
            // comboProfesor
            // 
            this.comboProfesor.DisplayMember = "Nombre";
            this.comboProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProfesor.FormattingEnabled = true;
            this.comboProfesor.Location = new System.Drawing.Point(422, 51);
            this.comboProfesor.Margin = new System.Windows.Forms.Padding(2);
            this.comboProfesor.Name = "comboProfesor";
            this.comboProfesor.Size = new System.Drawing.Size(200, 21);
            this.comboProfesor.TabIndex = 33;
            this.comboProfesor.Tag = "CodTipoActividad";
            this.comboProfesor.ValueMember = "Id";
            // 
            // comboCodTipoActividad
            // 
            this.comboCodTipoActividad.DisplayMember = "Nombre";
            this.comboCodTipoActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCodTipoActividad.FormattingEnabled = true;
            this.comboCodTipoActividad.Location = new System.Drawing.Point(422, 13);
            this.comboCodTipoActividad.Margin = new System.Windows.Forms.Padding(2);
            this.comboCodTipoActividad.Name = "comboCodTipoActividad";
            this.comboCodTipoActividad.Size = new System.Drawing.Size(200, 21);
            this.comboCodTipoActividad.TabIndex = 32;
            this.comboCodTipoActividad.Tag = "CodTipoActividad";
            this.comboCodTipoActividad.ValueMember = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Profesor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tipo Actividad";
            // 
            // FrmListadoActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 359);
            this.Controls.Add(this.profesorCHK);
            this.Controls.Add(this.tipoActividadCHK);
            this.Controls.Add(this.comboProfesor);
            this.Controls.Add(this.comboCodTipoActividad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FiltroBtn);
            this.Controls.Add(this.FechaHastaPicker);
            this.Controls.Add(this.FechaDesdePicker);
            this.Controls.Add(this.FechaFinChk);
            this.Controls.Add(this.FechaInicioChk);
            this.Controls.Add(this.ExportarBtn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListadoActividades";
            this.Text = "FrmListadoActividades";
            this.Load += new System.EventHandler(this.FrmListadoActividades_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.actividadGrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView actividadGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodActividadCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodTipoActividadCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LegajoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDesdeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHastaCol;
        private System.Windows.Forms.Button ExportarBtn;
        private System.Windows.Forms.Button FiltroBtn;
        private System.Windows.Forms.DateTimePicker FechaHastaPicker;
        private System.Windows.Forms.DateTimePicker FechaDesdePicker;
        private System.Windows.Forms.CheckBox FechaFinChk;
        private System.Windows.Forms.CheckBox FechaInicioChk;
        private System.Windows.Forms.CheckBox profesorCHK;
        private System.Windows.Forms.CheckBox tipoActividadCHK;
        private System.Windows.Forms.ComboBox comboProfesor;
        private System.Windows.Forms.ComboBox comboCodTipoActividad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodTipoActCol;
    }
}