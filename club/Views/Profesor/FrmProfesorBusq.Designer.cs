namespace clubApp.Views
{
    partial class FrmProfesorBusq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfesorBusq));
            this.LocalidadCbo = new System.Windows.Forms.ComboBox();
            this.LocalidadChk = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LegajoTxt = new System.Windows.Forms.TextBox();
            this.LegajoChk = new System.Windows.Forms.CheckBox();
            this.NombresTxt = new System.Windows.Forms.TextBox();
            this.NombresChk = new System.Windows.Forms.CheckBox();
            this.ApellidoTxt = new System.Windows.Forms.TextBox();
            this.ApellidoChk = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // LocalidadCbo
            // 
            this.LocalidadCbo.DisplayMember = "Nombre";
            this.LocalidadCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalidadCbo.Enabled = false;
            this.LocalidadCbo.FormattingEnabled = true;
            this.LocalidadCbo.Location = new System.Drawing.Point(354, 47);
            this.LocalidadCbo.Margin = new System.Windows.Forms.Padding(2);
            this.LocalidadCbo.Name = "LocalidadCbo";
            this.LocalidadCbo.Size = new System.Drawing.Size(182, 21);
            this.LocalidadCbo.TabIndex = 21;
            this.LocalidadCbo.ValueMember = "Id";
            // 
            // LocalidadChk
            // 
            this.LocalidadChk.AutoSize = true;
            this.LocalidadChk.Location = new System.Drawing.Point(279, 47);
            this.LocalidadChk.Margin = new System.Windows.Forms.Padding(2);
            this.LocalidadChk.Name = "LocalidadChk";
            this.LocalidadChk.Size = new System.Drawing.Size(72, 17);
            this.LocalidadChk.TabIndex = 20;
            this.LocalidadChk.Text = "Localidad";
            this.LocalidadChk.UseVisualStyleBackColor = true;
            this.LocalidadChk.CheckedChanged += new System.EventHandler(this.LocalidadChk_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(442, 98);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 27);
            this.button1.TabIndex = 19;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 98);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 27);
            this.button2.TabIndex = 18;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // LegajoTxt
            // 
            this.LegajoTxt.Enabled = false;
            this.LegajoTxt.Location = new System.Drawing.Point(76, 47);
            this.LegajoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.LegajoTxt.Name = "LegajoTxt";
            this.LegajoTxt.Size = new System.Drawing.Size(123, 20);
            this.LegajoTxt.TabIndex = 17;
            // 
            // LegajoChk
            // 
            this.LegajoChk.AutoSize = true;
            this.LegajoChk.Location = new System.Drawing.Point(11, 46);
            this.LegajoChk.Margin = new System.Windows.Forms.Padding(2);
            this.LegajoChk.Name = "LegajoChk";
            this.LegajoChk.Size = new System.Drawing.Size(58, 17);
            this.LegajoChk.TabIndex = 16;
            this.LegajoChk.Text = "Legajo";
            this.LegajoChk.UseVisualStyleBackColor = true;
            this.LegajoChk.CheckedChanged += new System.EventHandler(this.LegajoChk_CheckedChanged);
            // 
            // NombresTxt
            // 
            this.NombresTxt.Enabled = false;
            this.NombresTxt.Location = new System.Drawing.Point(354, 13);
            this.NombresTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NombresTxt.Name = "NombresTxt";
            this.NombresTxt.Size = new System.Drawing.Size(182, 20);
            this.NombresTxt.TabIndex = 15;
            // 
            // NombresChk
            // 
            this.NombresChk.AutoSize = true;
            this.NombresChk.Location = new System.Drawing.Point(279, 13);
            this.NombresChk.Margin = new System.Windows.Forms.Padding(2);
            this.NombresChk.Name = "NombresChk";
            this.NombresChk.Size = new System.Drawing.Size(68, 17);
            this.NombresChk.TabIndex = 14;
            this.NombresChk.Text = "Nombres";
            this.NombresChk.UseVisualStyleBackColor = true;
            this.NombresChk.CheckedChanged += new System.EventHandler(this.NombresChk_CheckedChanged);
            // 
            // ApellidoTxt
            // 
            this.ApellidoTxt.Enabled = false;
            this.ApellidoTxt.Location = new System.Drawing.Point(76, 11);
            this.ApellidoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.ApellidoTxt.Name = "ApellidoTxt";
            this.ApellidoTxt.Size = new System.Drawing.Size(188, 20);
            this.ApellidoTxt.TabIndex = 13;
            // 
            // ApellidoChk
            // 
            this.ApellidoChk.AutoSize = true;
            this.ApellidoChk.Location = new System.Drawing.Point(11, 11);
            this.ApellidoChk.Margin = new System.Windows.Forms.Padding(2);
            this.ApellidoChk.Name = "ApellidoChk";
            this.ApellidoChk.Size = new System.Drawing.Size(63, 17);
            this.ApellidoChk.TabIndex = 12;
            this.ApellidoChk.Text = "Apellido";
            this.ApellidoChk.UseVisualStyleBackColor = true;
            this.ApellidoChk.CheckedChanged += new System.EventHandler(this.ApellidoChk_CheckedChanged);
            // 
            // FrmProfesorBusq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 140);
            this.Controls.Add(this.LocalidadCbo);
            this.Controls.Add(this.LocalidadChk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LegajoTxt);
            this.Controls.Add(this.LegajoChk);
            this.Controls.Add(this.NombresTxt);
            this.Controls.Add(this.NombresChk);
            this.Controls.Add(this.ApellidoTxt);
            this.Controls.Add(this.ApellidoChk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProfesorBusq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de Profesores...";
            this.Load += new System.EventHandler(this.FrmProfesorBusq_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox LocalidadCbo;
        private System.Windows.Forms.CheckBox LocalidadChk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox LegajoTxt;
        private System.Windows.Forms.CheckBox LegajoChk;
        private System.Windows.Forms.TextBox NombresTxt;
        private System.Windows.Forms.CheckBox NombresChk;
        private System.Windows.Forms.TextBox ApellidoTxt;
        private System.Windows.Forms.CheckBox ApellidoChk;


    }
}