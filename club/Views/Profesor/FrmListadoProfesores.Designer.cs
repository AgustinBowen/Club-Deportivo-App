namespace clubApp.Views
{
    partial class FrmListadoProfesores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoProfesores));
            this.FiltroBtn = new System.Windows.Forms.Button();
            this.NombreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DniCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfesoresGrd = new System.Windows.Forms.DataGridView();
            this.ApellidoChk = new System.Windows.Forms.CheckBox();
            this.ApellidoTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.legajoChk = new System.Windows.Forms.CheckBox();
            this.legajoTxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dniChk = new System.Windows.Forms.CheckBox();
            this.dniTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ExportarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProfesoresGrd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FiltroBtn
            // 
            this.FiltroBtn.Location = new System.Drawing.Point(737, 19);
            this.FiltroBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FiltroBtn.Name = "FiltroBtn";
            this.FiltroBtn.Size = new System.Drawing.Size(76, 32);
            this.FiltroBtn.TabIndex = 7;
            this.FiltroBtn.Text = "Filtrar";
            this.FiltroBtn.UseVisualStyleBackColor = true;
            this.FiltroBtn.Click += new System.EventHandler(this.FiltroBtn_Click);
            // 
            // NombreCol
            // 
            this.NombreCol.DataPropertyName = "Nombres";
            this.NombreCol.HeaderText = "Nombres";
            this.NombreCol.Name = "NombreCol";
            this.NombreCol.ReadOnly = true;
            this.NombreCol.Width = 190;
            // 
            // ApellidoCol
            // 
            this.ApellidoCol.DataPropertyName = "Apellido";
            this.ApellidoCol.HeaderText = "Apellido";
            this.ApellidoCol.Name = "ApellidoCol";
            this.ApellidoCol.ReadOnly = true;
            this.ApellidoCol.Width = 190;
            // 
            // DniCol
            // 
            this.DniCol.DataPropertyName = "NroDocumento";
            this.DniCol.HeaderText = "Dni";
            this.DniCol.Name = "DniCol";
            this.DniCol.ReadOnly = true;
            // 
            // Legajo
            // 
            this.Legajo.DataPropertyName = "Legajo";
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            // 
            // ProfesoresGrd
            // 
            this.ProfesoresGrd.AllowUserToAddRows = false;
            this.ProfesoresGrd.AllowUserToDeleteRows = false;
            this.ProfesoresGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProfesoresGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Legajo,
            this.DniCol,
            this.ApellidoCol,
            this.NombreCol});
            this.ProfesoresGrd.Location = new System.Drawing.Point(9, 55);
            this.ProfesoresGrd.Margin = new System.Windows.Forms.Padding(2);
            this.ProfesoresGrd.MultiSelect = false;
            this.ProfesoresGrd.Name = "ProfesoresGrd";
            this.ProfesoresGrd.ReadOnly = true;
            this.ProfesoresGrd.RowTemplate.Height = 24;
            this.ProfesoresGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProfesoresGrd.Size = new System.Drawing.Size(826, 352);
            this.ProfesoresGrd.TabIndex = 5;
            this.ProfesoresGrd.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ProfesoresGrd_ColumnHeaderMouseClick_1);
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
            // ApellidoTxt
            // 
            this.ApellidoTxt.Enabled = false;
            this.ApellidoTxt.Location = new System.Drawing.Point(69, 15);
            this.ApellidoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.ApellidoTxt.Name = "ApellidoTxt";
            this.ApellidoTxt.Size = new System.Drawing.Size(146, 20);
            this.ApellidoTxt.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ApellidoTxt);
            this.groupBox1.Controls.Add(this.ApellidoChk);
            this.groupBox1.Location = new System.Drawing.Point(487, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(227, 42);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // legajoChk
            // 
            this.legajoChk.AutoSize = true;
            this.legajoChk.Location = new System.Drawing.Point(4, 17);
            this.legajoChk.Margin = new System.Windows.Forms.Padding(2);
            this.legajoChk.Name = "legajoChk";
            this.legajoChk.Size = new System.Drawing.Size(58, 17);
            this.legajoChk.TabIndex = 0;
            this.legajoChk.Text = "Legajo";
            this.legajoChk.UseVisualStyleBackColor = true;
            this.legajoChk.CheckedChanged += new System.EventHandler(this.legajoChk_CheckedChanged);
            // 
            // legajoTxt
            // 
            this.legajoTxt.Enabled = false;
            this.legajoTxt.Location = new System.Drawing.Point(69, 15);
            this.legajoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.legajoTxt.Name = "legajoTxt";
            this.legajoTxt.Size = new System.Drawing.Size(146, 20);
            this.legajoTxt.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.legajoTxt);
            this.groupBox3.Controls.Add(this.legajoChk);
            this.groupBox3.Location = new System.Drawing.Point(9, 9);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(227, 42);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // dniChk
            // 
            this.dniChk.AutoSize = true;
            this.dniChk.Location = new System.Drawing.Point(4, 17);
            this.dniChk.Margin = new System.Windows.Forms.Padding(2);
            this.dniChk.Name = "dniChk";
            this.dniChk.Size = new System.Drawing.Size(42, 17);
            this.dniChk.TabIndex = 0;
            this.dniChk.Text = "Dni";
            this.dniChk.UseVisualStyleBackColor = true;
            this.dniChk.CheckedChanged += new System.EventHandler(this.dniChk_CheckedChanged);
            // 
            // dniTxt
            // 
            this.dniTxt.Enabled = false;
            this.dniTxt.Location = new System.Drawing.Point(69, 15);
            this.dniTxt.Margin = new System.Windows.Forms.Padding(2);
            this.dniTxt.Name = "dniTxt";
            this.dniTxt.Size = new System.Drawing.Size(146, 20);
            this.dniTxt.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dniTxt);
            this.groupBox2.Controls.Add(this.dniChk);
            this.groupBox2.Location = new System.Drawing.Point(240, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(227, 42);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // ExportarBtn
            // 
            this.ExportarBtn.Location = new System.Drawing.Point(750, 425);
            this.ExportarBtn.Name = "ExportarBtn";
            this.ExportarBtn.Size = new System.Drawing.Size(84, 26);
            this.ExportarBtn.TabIndex = 9;
            this.ExportarBtn.Text = "Exportar";
            this.ExportarBtn.UseVisualStyleBackColor = false;
            this.ExportarBtn.Click += new System.EventHandler(this.ExportarBtn_Click);
            // 
            // FrmListadoProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 472);
            this.Controls.Add(this.ExportarBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.FiltroBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ProfesoresGrd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmListadoProfesores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Profesores";
            this.Load += new System.EventHandler(this.FrmListadoProfesores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProfesoresGrd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FiltroBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridView ProfesoresGrd;
        private System.Windows.Forms.CheckBox ApellidoChk;
        private System.Windows.Forms.TextBox ApellidoTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox legajoChk;
        private System.Windows.Forms.TextBox legajoTxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox dniChk;
        private System.Windows.Forms.TextBox dniTxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ExportarBtn;
    }
}