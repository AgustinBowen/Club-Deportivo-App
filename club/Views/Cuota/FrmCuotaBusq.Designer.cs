namespace clubApp.Views
{
    partial class FrmCuotaBusq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCuotaBusq));
            this.ActSocioCbo = new System.Windows.Forms.ComboBox();
            this.ActSocioChk = new System.Windows.Forms.CheckBox();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.MesTxt = new System.Windows.Forms.TextBox();
            this.MesChk = new System.Windows.Forms.CheckBox();
            this.EstadoTxt = new System.Windows.Forms.TextBox();
            this.EstadoChk = new System.Windows.Forms.CheckBox();
            this.AnioTxt = new System.Windows.Forms.TextBox();
            this.AnioChk = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ActSocioCbo
            // 
            this.ActSocioCbo.DisplayMember = "Nombre";
            this.ActSocioCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActSocioCbo.Enabled = false;
            this.ActSocioCbo.FormattingEnabled = true;
            this.ActSocioCbo.Location = new System.Drawing.Point(260, 47);
            this.ActSocioCbo.Margin = new System.Windows.Forms.Padding(2);
            this.ActSocioCbo.Name = "ActSocioCbo";
            this.ActSocioCbo.Size = new System.Drawing.Size(182, 21);
            this.ActSocioCbo.TabIndex = 21;
            this.ActSocioCbo.ValueMember = "Id";
            // 
            // ActSocioChk
            // 
            this.ActSocioChk.AutoSize = true;
            this.ActSocioChk.Location = new System.Drawing.Point(158, 49);
            this.ActSocioChk.Margin = new System.Windows.Forms.Padding(2);
            this.ActSocioChk.Name = "ActSocioChk";
            this.ActSocioChk.Size = new System.Drawing.Size(98, 17);
            this.ActSocioChk.TabIndex = 20;
            this.ActSocioChk.Text = "Actividad socio";
            this.ActSocioChk.UseVisualStyleBackColor = true;
            this.ActSocioChk.CheckedChanged += new System.EventHandler(this.ActSocioChk_CheckedChanged);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(442, 98);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(58, 27);
            this.CancelarBtn.TabIndex = 19;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click_1);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(354, 98);
            this.BuscarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(58, 27);
            this.BuscarBtn.TabIndex = 18;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click_1);
            // 
            // MesTxt
            // 
            this.MesTxt.Enabled = false;
            this.MesTxt.Location = new System.Drawing.Point(76, 47);
            this.MesTxt.Margin = new System.Windows.Forms.Padding(2);
            this.MesTxt.Name = "MesTxt";
            this.MesTxt.Size = new System.Drawing.Size(63, 20);
            this.MesTxt.TabIndex = 17;
            // 
            // MesChk
            // 
            this.MesChk.AutoSize = true;
            this.MesChk.Location = new System.Drawing.Point(11, 46);
            this.MesChk.Margin = new System.Windows.Forms.Padding(2);
            this.MesChk.Name = "MesChk";
            this.MesChk.Size = new System.Drawing.Size(46, 17);
            this.MesChk.TabIndex = 16;
            this.MesChk.Text = "Mes";
            this.MesChk.UseVisualStyleBackColor = true;
            this.MesChk.CheckedChanged += new System.EventHandler(this.MesChk_CheckedChanged);
            // 
            // EstadoTxt
            // 
            this.EstadoTxt.Enabled = false;
            this.EstadoTxt.Location = new System.Drawing.Point(260, 11);
            this.EstadoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.EstadoTxt.Name = "EstadoTxt";
            this.EstadoTxt.Size = new System.Drawing.Size(121, 20);
            this.EstadoTxt.TabIndex = 15;
            // 
            // EstadoChk
            // 
            this.EstadoChk.AutoSize = true;
            this.EstadoChk.Location = new System.Drawing.Point(158, 13);
            this.EstadoChk.Margin = new System.Windows.Forms.Padding(2);
            this.EstadoChk.Name = "EstadoChk";
            this.EstadoChk.Size = new System.Drawing.Size(59, 17);
            this.EstadoChk.TabIndex = 14;
            this.EstadoChk.Text = "Estado";
            this.EstadoChk.UseVisualStyleBackColor = true;
            this.EstadoChk.CheckedChanged += new System.EventHandler(this.EstadoChk_CheckedChanged);
            // 
            // AnioTxt
            // 
            this.AnioTxt.Enabled = false;
            this.AnioTxt.Location = new System.Drawing.Point(76, 11);
            this.AnioTxt.Margin = new System.Windows.Forms.Padding(2);
            this.AnioTxt.Name = "AnioTxt";
            this.AnioTxt.Size = new System.Drawing.Size(63, 20);
            this.AnioTxt.TabIndex = 13;
            // 
            // AnioChk
            // 
            this.AnioChk.AutoSize = true;
            this.AnioChk.Location = new System.Drawing.Point(11, 11);
            this.AnioChk.Margin = new System.Windows.Forms.Padding(2);
            this.AnioChk.Name = "AnioChk";
            this.AnioChk.Size = new System.Drawing.Size(45, 17);
            this.AnioChk.TabIndex = 12;
            this.AnioChk.Text = "Año";
            this.AnioChk.UseVisualStyleBackColor = true;
            this.AnioChk.CheckedChanged += new System.EventHandler(this.AnioChk_CheckedChanged);
            // 
            // FrmCuotaBusq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 140);
            this.Controls.Add(this.ActSocioCbo);
            this.Controls.Add(this.ActSocioChk);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.MesTxt);
            this.Controls.Add(this.MesChk);
            this.Controls.Add(this.EstadoTxt);
            this.Controls.Add(this.EstadoChk);
            this.Controls.Add(this.AnioTxt);
            this.Controls.Add(this.AnioChk);
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCuotaBusq";
            this.Text = "FrmCuotaBusq";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ActSocioCbo;
        private System.Windows.Forms.CheckBox ActSocioChk;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.TextBox MesTxt;
        private System.Windows.Forms.CheckBox MesChk;
        private System.Windows.Forms.TextBox EstadoTxt;
        private System.Windows.Forms.CheckBox EstadoChk;
        private System.Windows.Forms.TextBox AnioTxt;
        private System.Windows.Forms.CheckBox AnioChk;
    }
}