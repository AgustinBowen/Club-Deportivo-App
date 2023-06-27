namespace clubApp.Views
{
    partial class FrmCuotaAM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCuotaAM));
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ActSocioCbo = new System.Windows.Forms.ComboBox();
            this.FechaVencimientoPicker = new System.Windows.Forms.DateTimePicker();
            this.MesTxt = new System.Windows.Forms.TextBox();
            this.MesLbl = new System.Windows.Forms.Label();
            this.FechaVencimientoLbl = new System.Windows.Forms.Label();
            this.EstadoTxt = new System.Windows.Forms.TextBox();
            this.EstadoLbl = new System.Windows.Forms.Label();
            this.ActSocioLbl = new System.Windows.Forms.Label();
            this.AnioTxt = new System.Windows.Forms.TextBox();
            this.AnioLbl = new System.Windows.Forms.Label();
            this.ImporteTxt = new System.Windows.Forms.TextBox();
            this.ImporteLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(280, 237);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(59, 27);
            this.CancelarBtn.TabIndex = 13;
            this.CancelarBtn.Text = "&Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(217, 237);
            this.GuardarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(59, 27);
            this.GuardarBtn.TabIndex = 12;
            this.GuardarBtn.Text = "&Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ActSocioCbo);
            this.groupBox1.Controls.Add(this.FechaVencimientoPicker);
            this.groupBox1.Controls.Add(this.MesTxt);
            this.groupBox1.Controls.Add(this.MesLbl);
            this.groupBox1.Controls.Add(this.FechaVencimientoLbl);
            this.groupBox1.Controls.Add(this.EstadoTxt);
            this.groupBox1.Controls.Add(this.EstadoLbl);
            this.groupBox1.Controls.Add(this.ActSocioLbl);
            this.groupBox1.Controls.Add(this.AnioTxt);
            this.groupBox1.Controls.Add(this.AnioLbl);
            this.groupBox1.Controls.Add(this.ImporteTxt);
            this.groupBox1.Controls.Add(this.ImporteLbl);
            this.groupBox1.Location = new System.Drawing.Point(9, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(330, 213);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // ActSocioCbo
            // 
            this.ActSocioCbo.DisplayMember = "Nombre";
            this.ActSocioCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActSocioCbo.FormattingEnabled = true;
            this.ActSocioCbo.Location = new System.Drawing.Point(117, 144);
            this.ActSocioCbo.Margin = new System.Windows.Forms.Padding(2);
            this.ActSocioCbo.Name = "ActSocioCbo";
            this.ActSocioCbo.Size = new System.Drawing.Size(201, 21);
            this.ActSocioCbo.TabIndex = 14;
            this.ActSocioCbo.Tag = "id";
            this.ActSocioCbo.ValueMember = "Id";
            this.ActSocioCbo.SelectedIndexChanged += new System.EventHandler(this.ActSocioCbo_SelectedIndexChanged);
            // 
            // FechaVencimientoPicker
            // 
            this.FechaVencimientoPicker.Location = new System.Drawing.Point(117, 180);
            this.FechaVencimientoPicker.Name = "FechaVencimientoPicker";
            this.FechaVencimientoPicker.Size = new System.Drawing.Size(200, 20);
            this.FechaVencimientoPicker.TabIndex = 17;
            this.FechaVencimientoPicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // MesTxt
            // 
            this.MesTxt.Location = new System.Drawing.Point(117, 80);
            this.MesTxt.Margin = new System.Windows.Forms.Padding(2);
            this.MesTxt.Name = "MesTxt";
            this.MesTxt.Size = new System.Drawing.Size(200, 20);
            this.MesTxt.TabIndex = 4;
            this.MesTxt.Tag = "Mes";
            // 
            // MesLbl
            // 
            this.MesLbl.AutoSize = true;
            this.MesLbl.Location = new System.Drawing.Point(14, 80);
            this.MesLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MesLbl.Name = "MesLbl";
            this.MesLbl.Size = new System.Drawing.Size(27, 13);
            this.MesLbl.TabIndex = 16;
            this.MesLbl.Text = "Mes";
            // 
            // FechaVencimientoLbl
            // 
            this.FechaVencimientoLbl.AutoSize = true;
            this.FechaVencimientoLbl.Location = new System.Drawing.Point(15, 180);
            this.FechaVencimientoLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FechaVencimientoLbl.Name = "FechaVencimientoLbl";
            this.FechaVencimientoLbl.Size = new System.Drawing.Size(97, 13);
            this.FechaVencimientoLbl.TabIndex = 10;
            this.FechaVencimientoLbl.Text = "Fecha vencimiento";
            // 
            // EstadoTxt
            // 
            this.EstadoTxt.Location = new System.Drawing.Point(117, 110);
            this.EstadoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.EstadoTxt.Name = "EstadoTxt";
            this.EstadoTxt.Size = new System.Drawing.Size(200, 20);
            this.EstadoTxt.TabIndex = 5;
            // 
            // EstadoLbl
            // 
            this.EstadoLbl.AutoSize = true;
            this.EstadoLbl.Location = new System.Drawing.Point(15, 110);
            this.EstadoLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EstadoLbl.Name = "EstadoLbl";
            this.EstadoLbl.Size = new System.Drawing.Size(40, 13);
            this.EstadoLbl.TabIndex = 8;
            this.EstadoLbl.Text = "Estado";
            // 
            // ActSocioLbl
            // 
            this.ActSocioLbl.AutoSize = true;
            this.ActSocioLbl.Location = new System.Drawing.Point(16, 147);
            this.ActSocioLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ActSocioLbl.Name = "ActSocioLbl";
            this.ActSocioLbl.Size = new System.Drawing.Size(81, 13);
            this.ActSocioLbl.TabIndex = 4;
            this.ActSocioLbl.Text = "Actividad Socio";
            // 
            // AnioTxt
            // 
            this.AnioTxt.Location = new System.Drawing.Point(117, 46);
            this.AnioTxt.Margin = new System.Windows.Forms.Padding(2);
            this.AnioTxt.Name = "AnioTxt";
            this.AnioTxt.Size = new System.Drawing.Size(200, 20);
            this.AnioTxt.TabIndex = 2;
            this.AnioTxt.Tag = "Año";
            // 
            // AnioLbl
            // 
            this.AnioLbl.AutoSize = true;
            this.AnioLbl.Location = new System.Drawing.Point(14, 49);
            this.AnioLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AnioLbl.Name = "AnioLbl";
            this.AnioLbl.Size = new System.Drawing.Size(26, 13);
            this.AnioLbl.TabIndex = 2;
            this.AnioLbl.Text = "Año";
            // 
            // ImporteTxt
            // 
            this.ImporteTxt.Location = new System.Drawing.Point(117, 15);
            this.ImporteTxt.Margin = new System.Windows.Forms.Padding(2);
            this.ImporteTxt.Name = "ImporteTxt";
            this.ImporteTxt.Size = new System.Drawing.Size(200, 20);
            this.ImporteTxt.TabIndex = 1;
            this.ImporteTxt.Tag = "Importe";
            // 
            // ImporteLbl
            // 
            this.ImporteLbl.AutoSize = true;
            this.ImporteLbl.Location = new System.Drawing.Point(14, 15);
            this.ImporteLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ImporteLbl.Name = "ImporteLbl";
            this.ImporteLbl.Size = new System.Drawing.Size(42, 13);
            this.ImporteLbl.TabIndex = 0;
            this.ImporteLbl.Text = "Importe";
            // 
            // FrmCuotaAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 277);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCuotaAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCuotaAM";
            this.Deactivate += new System.EventHandler(this.FrmCuotaAM_Deactivate);
            this.Load += new System.EventHandler(this.FrmpCuotaAM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox MesTxt;
        private System.Windows.Forms.Label MesLbl;
        private System.Windows.Forms.Label FechaVencimientoLbl;
        private System.Windows.Forms.TextBox EstadoTxt;
        private System.Windows.Forms.Label EstadoLbl;
        private System.Windows.Forms.Label ActSocioLbl;
        private System.Windows.Forms.TextBox AnioTxt;
        private System.Windows.Forms.Label AnioLbl;
        private System.Windows.Forms.TextBox ImporteTxt;
        private System.Windows.Forms.Label ImporteLbl;
        private System.Windows.Forms.DateTimePicker FechaVencimientoPicker;
        private System.Windows.Forms.ComboBox ActSocioCbo;
    }
}