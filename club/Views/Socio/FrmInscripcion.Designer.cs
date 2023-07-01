namespace clubApp.Views
{
    partial class FrmInscripcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInscripcion));
            this.InscribirBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LocalidadCbo = new System.Windows.Forms.ComboBox();
            this.LocalidadChk = new System.Windows.Forms.CheckBox();
            this.FiltroBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ApellidoTxt = new System.Windows.Forms.TextBox();
            this.ApellidoChk = new System.Windows.Forms.CheckBox();
            this.SociosGrd = new System.Windows.Forms.DataGridView();
            this.DniCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Moroso = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CboTipoActividad = new System.Windows.Forms.ComboBox();
            this.TipoActiviadLbl = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CboActividad = new System.Windows.Forms.ComboBox();
            this.ActividadLbl = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SociosGrd)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // InscribirBtn
            // 
            this.InscribirBtn.Location = new System.Drawing.Point(452, 340);
            this.InscribirBtn.Name = "InscribirBtn";
            this.InscribirBtn.Size = new System.Drawing.Size(84, 26);
            this.InscribirBtn.TabIndex = 14;
            this.InscribirBtn.Text = "Inscribir";
            this.InscribirBtn.UseVisualStyleBackColor = false;
            this.InscribirBtn.Click += new System.EventHandler(this.InscribirBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LocalidadCbo);
            this.groupBox3.Controls.Add(this.LocalidadChk);
            this.groupBox3.Location = new System.Drawing.Point(242, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(225, 41);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // LocalidadCbo
            // 
            this.LocalidadCbo.DisplayMember = "Id";
            this.LocalidadCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalidadCbo.Enabled = false;
            this.LocalidadCbo.FormattingEnabled = true;
            this.LocalidadCbo.Location = new System.Drawing.Point(90, 12);
            this.LocalidadCbo.Margin = new System.Windows.Forms.Padding(2);
            this.LocalidadCbo.Name = "LocalidadCbo";
            this.LocalidadCbo.Size = new System.Drawing.Size(115, 21);
            this.LocalidadCbo.TabIndex = 1;
            this.LocalidadCbo.ValueMember = "Nombre";
            // 
            // LocalidadChk
            // 
            this.LocalidadChk.AutoSize = true;
            this.LocalidadChk.Location = new System.Drawing.Point(10, 15);
            this.LocalidadChk.Margin = new System.Windows.Forms.Padding(2);
            this.LocalidadChk.Name = "LocalidadChk";
            this.LocalidadChk.Size = new System.Drawing.Size(72, 17);
            this.LocalidadChk.TabIndex = 0;
            this.LocalidadChk.Text = "Localidad";
            this.LocalidadChk.UseVisualStyleBackColor = true;
            this.LocalidadChk.CheckedChanged += new System.EventHandler(this.LocalidadChk_CheckedChanged);
            // 
            // FiltroBtn
            // 
            this.FiltroBtn.Location = new System.Drawing.Point(483, 20);
            this.FiltroBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FiltroBtn.Name = "FiltroBtn";
            this.FiltroBtn.Size = new System.Drawing.Size(76, 32);
            this.FiltroBtn.TabIndex = 10;
            this.FiltroBtn.Text = "Filtrar";
            this.FiltroBtn.UseVisualStyleBackColor = true;
            this.FiltroBtn.Click += new System.EventHandler(this.FiltroBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ApellidoTxt);
            this.groupBox1.Controls.Add(this.ApellidoChk);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(227, 42);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // ApellidoTxt
            // 
            this.ApellidoTxt.Enabled = false;
            this.ApellidoTxt.Location = new System.Drawing.Point(69, 15);
            this.ApellidoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.ApellidoTxt.Name = "ApellidoTxt";
            this.ApellidoTxt.Size = new System.Drawing.Size(146, 20);
            this.ApellidoTxt.TabIndex = 1;
            // 
            // ApellidoChk
            // 
            this.ApellidoChk.AutoSize = true;
            this.ApellidoChk.Location = new System.Drawing.Point(4, 17);
            this.ApellidoChk.Margin = new System.Windows.Forms.Padding(2);
            this.ApellidoChk.Name = "ApellidoChk";
            this.ApellidoChk.Size = new System.Drawing.Size(63, 17);
            this.ApellidoChk.TabIndex = 0;
            this.ApellidoChk.Text = "Apellido";
            this.ApellidoChk.UseVisualStyleBackColor = true;
            this.ApellidoChk.CheckedChanged += new System.EventHandler(this.ApellidoChk_CheckedChanged);
            // 
            // SociosGrd
            // 
            this.SociosGrd.AllowUserToAddRows = false;
            this.SociosGrd.AllowUserToDeleteRows = false;
            this.SociosGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SociosGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DniCol,
            this.ApellidoCol,
            this.NombreCol,
            this.LocCol,
            this.Activo,
            this.Moroso});
            this.SociosGrd.Location = new System.Drawing.Point(11, 70);
            this.SociosGrd.Margin = new System.Windows.Forms.Padding(2);
            this.SociosGrd.MultiSelect = false;
            this.SociosGrd.Name = "SociosGrd";
            this.SociosGrd.ReadOnly = true;
            this.SociosGrd.RowTemplate.Height = 24;
            this.SociosGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SociosGrd.ShowEditingIcon = false;
            this.SociosGrd.Size = new System.Drawing.Size(548, 230);
            this.SociosGrd.TabIndex = 8;
            this.SociosGrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SociosGrd_CellContentClick);
            // 
            // DniCol
            // 
            this.DniCol.DataPropertyName = "NroDocumento";
            this.DniCol.HeaderText = "Dni";
            this.DniCol.Name = "DniCol";
            this.DniCol.ReadOnly = true;
            // 
            // ApellidoCol
            // 
            this.ApellidoCol.DataPropertyName = "Apellido";
            this.ApellidoCol.HeaderText = "Apellido";
            this.ApellidoCol.Name = "ApellidoCol";
            this.ApellidoCol.ReadOnly = true;
            this.ApellidoCol.Width = 150;
            // 
            // NombreCol
            // 
            this.NombreCol.DataPropertyName = "Nombres";
            this.NombreCol.HeaderText = "Nombres";
            this.NombreCol.Name = "NombreCol";
            this.NombreCol.ReadOnly = true;
            this.NombreCol.Width = 150;
            // 
            // LocCol
            // 
            this.LocCol.HeaderText = "Localidad";
            this.LocCol.Name = "LocCol";
            this.LocCol.ReadOnly = true;
            // 
            // Activo
            // 
            this.Activo.DataPropertyName = "Activo";
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Activo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Moroso
            // 
            this.Moroso.DataPropertyName = "Moroso";
            this.Moroso.HeaderText = "Moroso";
            this.Moroso.Name = "Moroso";
            this.Moroso.ReadOnly = true;
            this.Moroso.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Moroso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CboTipoActividad);
            this.groupBox2.Controls.Add(this.TipoActiviadLbl);
            this.groupBox2.Location = new System.Drawing.Point(27, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 61);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // CboTipoActividad
            // 
            this.CboTipoActividad.FormattingEnabled = true;
            this.CboTipoActividad.Location = new System.Drawing.Point(10, 30);
            this.CboTipoActividad.Name = "CboTipoActividad";
            this.CboTipoActividad.Size = new System.Drawing.Size(121, 21);
            this.CboTipoActividad.TabIndex = 1;
            this.CboTipoActividad.SelectedIndexChanged += new System.EventHandler(this.CboTipoActividad_SelectedIndexChanged);
            // 
            // TipoActiviadLbl
            // 
            this.TipoActiviadLbl.AutoSize = true;
            this.TipoActiviadLbl.Location = new System.Drawing.Point(25, 14);
            this.TipoActiviadLbl.Name = "TipoActiviadLbl";
            this.TipoActiviadLbl.Size = new System.Drawing.Size(90, 13);
            this.TipoActiviadLbl.TabIndex = 0;
            this.TipoActiviadLbl.Text = "Tipo de Actividad";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CboActividad);
            this.groupBox4.Controls.Add(this.ActividadLbl);
            this.groupBox4.Location = new System.Drawing.Point(252, 315);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(144, 61);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            // 
            // CboActividad
            // 
            this.CboActividad.Enabled = false;
            this.CboActividad.FormattingEnabled = true;
            this.CboActividad.Location = new System.Drawing.Point(10, 30);
            this.CboActividad.Name = "CboActividad";
            this.CboActividad.Size = new System.Drawing.Size(121, 21);
            this.CboActividad.TabIndex = 1;
            this.CboActividad.SelectedIndexChanged += new System.EventHandler(this.CboActividad_SelectedIndexChanged);
            // 
            // ActividadLbl
            // 
            this.ActividadLbl.AutoSize = true;
            this.ActividadLbl.Location = new System.Drawing.Point(44, 14);
            this.ActividadLbl.Name = "ActividadLbl";
            this.ActividadLbl.Size = new System.Drawing.Size(51, 13);
            this.ActividadLbl.TabIndex = 0;
            this.ActividadLbl.Text = "Actividad";
            // 
            // FrmInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 388);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.InscribirBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.FiltroBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SociosGrd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInscripcion";
            this.Text = "FrmInscripcion";
            this.Load += new System.EventHandler(this.FrmInscripcion_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SociosGrd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InscribirBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox LocalidadCbo;
        private System.Windows.Forms.CheckBox LocalidadChk;
        private System.Windows.Forms.Button FiltroBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ApellidoTxt;
        private System.Windows.Forms.CheckBox ApellidoChk;
        private System.Windows.Forms.DataGridView SociosGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Moroso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CboTipoActividad;
        private System.Windows.Forms.Label TipoActiviadLbl;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox CboActividad;
        private System.Windows.Forms.Label ActividadLbl;
    }
}