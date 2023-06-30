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
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.MesTxt = new System.Windows.Forms.TextBox();
            this.MesChk = new System.Windows.Forms.CheckBox();
            this.AnioTxt = new System.Windows.Forms.TextBox();
            this.AnioChk = new System.Windows.Forms.CheckBox();
            this.FechaVencimientoPicker = new System.Windows.Forms.DateTimePicker();
            this.FechaVencimientoChk = new System.Windows.Forms.CheckBox();
            this.FechaPagoChk = new System.Windows.Forms.CheckBox();
            this.FechaPagoPicker = new System.Windows.Forms.DateTimePicker();
            this.PagaChk = new System.Windows.Forms.CheckBox();
            this.AnuladaChk = new System.Windows.Forms.CheckBox();
            this.ImpagaChk = new System.Windows.Forms.CheckBox();
            this.ImporteTxt = new System.Windows.Forms.TextBox();
            this.ImporteChk = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(423, 76);
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
            this.BuscarBtn.Location = new System.Drawing.Point(361, 76);
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
            this.MesTxt.Location = new System.Drawing.Point(70, 46);
            this.MesTxt.Margin = new System.Windows.Forms.Padding(2);
            this.MesTxt.Name = "MesTxt";
            this.MesTxt.Size = new System.Drawing.Size(63, 20);
            this.MesTxt.TabIndex = 17;
            // 
            // MesChk
            // 
            this.MesChk.AutoSize = true;
            this.MesChk.Location = new System.Drawing.Point(12, 49);
            this.MesChk.Margin = new System.Windows.Forms.Padding(2);
            this.MesChk.Name = "MesChk";
            this.MesChk.Size = new System.Drawing.Size(46, 17);
            this.MesChk.TabIndex = 16;
            this.MesChk.Text = "Mes";
            this.MesChk.UseVisualStyleBackColor = true;
            this.MesChk.CheckedChanged += new System.EventHandler(this.MesChk_CheckedChanged);
            // 
            // AnioTxt
            // 
            this.AnioTxt.Enabled = false;
            this.AnioTxt.Location = new System.Drawing.Point(70, 10);
            this.AnioTxt.Margin = new System.Windows.Forms.Padding(2);
            this.AnioTxt.Name = "AnioTxt";
            this.AnioTxt.Size = new System.Drawing.Size(63, 20);
            this.AnioTxt.TabIndex = 13;
            // 
            // AnioChk
            // 
            this.AnioChk.AutoSize = true;
            this.AnioChk.Location = new System.Drawing.Point(11, 13);
            this.AnioChk.Margin = new System.Windows.Forms.Padding(2);
            this.AnioChk.Name = "AnioChk";
            this.AnioChk.Size = new System.Drawing.Size(45, 17);
            this.AnioChk.TabIndex = 12;
            this.AnioChk.Text = "Año";
            this.AnioChk.UseVisualStyleBackColor = true;
            this.AnioChk.CheckedChanged += new System.EventHandler(this.AnioChk_CheckedChanged);
            // 
            // FechaVencimientoPicker
            // 
            this.FechaVencimientoPicker.Enabled = false;
            this.FechaVencimientoPicker.Location = new System.Drawing.Point(267, 8);
            this.FechaVencimientoPicker.Name = "FechaVencimientoPicker";
            this.FechaVencimientoPicker.Size = new System.Drawing.Size(214, 20);
            this.FechaVencimientoPicker.TabIndex = 20;
            this.FechaVencimientoPicker.ValueChanged += new System.EventHandler(this.FechaVencimientoPicker_ValueChanged);
            // 
            // FechaVencimientoChk
            // 
            this.FechaVencimientoChk.AutoSize = true;
            this.FechaVencimientoChk.Location = new System.Drawing.Point(146, 10);
            this.FechaVencimientoChk.Margin = new System.Windows.Forms.Padding(2);
            this.FechaVencimientoChk.Name = "FechaVencimientoChk";
            this.FechaVencimientoChk.Size = new System.Drawing.Size(116, 17);
            this.FechaVencimientoChk.TabIndex = 21;
            this.FechaVencimientoChk.Text = "Fecha vencimiento";
            this.FechaVencimientoChk.UseVisualStyleBackColor = true;
            this.FechaVencimientoChk.CheckedChanged += new System.EventHandler(this.FechaVencimientoChk_CheckedChanged);
            // 
            // FechaPagoChk
            // 
            this.FechaPagoChk.AutoSize = true;
            this.FechaPagoChk.Location = new System.Drawing.Point(146, 46);
            this.FechaPagoChk.Margin = new System.Windows.Forms.Padding(2);
            this.FechaPagoChk.Name = "FechaPagoChk";
            this.FechaPagoChk.Size = new System.Drawing.Size(83, 17);
            this.FechaPagoChk.TabIndex = 23;
            this.FechaPagoChk.Text = "Fecha pago";
            this.FechaPagoChk.UseVisualStyleBackColor = true;
            this.FechaPagoChk.CheckedChanged += new System.EventHandler(this.FechaPagoChk_CheckedChanged);
            // 
            // FechaPagoPicker
            // 
            this.FechaPagoPicker.Enabled = false;
            this.FechaPagoPicker.Location = new System.Drawing.Point(267, 43);
            this.FechaPagoPicker.Name = "FechaPagoPicker";
            this.FechaPagoPicker.Size = new System.Drawing.Size(214, 20);
            this.FechaPagoPicker.TabIndex = 22;
            this.FechaPagoPicker.ValueChanged += new System.EventHandler(this.FechaPagoPicker_ValueChanged);
            // 
            // PagaChk
            // 
            this.PagaChk.AutoSize = true;
            this.PagaChk.Location = new System.Drawing.Point(224, 82);
            this.PagaChk.Margin = new System.Windows.Forms.Padding(2);
            this.PagaChk.Name = "PagaChk";
            this.PagaChk.Size = new System.Drawing.Size(51, 17);
            this.PagaChk.TabIndex = 24;
            this.PagaChk.Text = "Paga";
            this.PagaChk.UseVisualStyleBackColor = true;
            this.PagaChk.CheckedChanged += new System.EventHandler(this.PagaChk_CheckedChanged);
            // 
            // AnuladaChk
            // 
            this.AnuladaChk.AutoSize = true;
            this.AnuladaChk.Location = new System.Drawing.Point(290, 83);
            this.AnuladaChk.Margin = new System.Windows.Forms.Padding(2);
            this.AnuladaChk.Name = "AnuladaChk";
            this.AnuladaChk.Size = new System.Drawing.Size(65, 17);
            this.AnuladaChk.TabIndex = 25;
            this.AnuladaChk.Text = "Anulada";
            this.AnuladaChk.UseVisualStyleBackColor = true;
            this.AnuladaChk.CheckedChanged += new System.EventHandler(this.AnuladaChk_CheckedChanged);
            // 
            // ImpagaChk
            // 
            this.ImpagaChk.AutoSize = true;
            this.ImpagaChk.Location = new System.Drawing.Point(146, 82);
            this.ImpagaChk.Margin = new System.Windows.Forms.Padding(2);
            this.ImpagaChk.Name = "ImpagaChk";
            this.ImpagaChk.Size = new System.Drawing.Size(61, 17);
            this.ImpagaChk.TabIndex = 26;
            this.ImpagaChk.Text = "Impaga";
            this.ImpagaChk.UseVisualStyleBackColor = true;
            this.ImpagaChk.CheckedChanged += new System.EventHandler(this.ImpagaChk_CheckedChanged);
            // 
            // ImporteTxt
            // 
            this.ImporteTxt.Enabled = false;
            this.ImporteTxt.Location = new System.Drawing.Point(70, 80);
            this.ImporteTxt.Margin = new System.Windows.Forms.Padding(2);
            this.ImporteTxt.Name = "ImporteTxt";
            this.ImporteTxt.Size = new System.Drawing.Size(63, 20);
            this.ImporteTxt.TabIndex = 28;
            // 
            // ImporteChk
            // 
            this.ImporteChk.AutoSize = true;
            this.ImporteChk.Location = new System.Drawing.Point(12, 83);
            this.ImporteChk.Margin = new System.Windows.Forms.Padding(2);
            this.ImporteChk.Name = "ImporteChk";
            this.ImporteChk.Size = new System.Drawing.Size(61, 17);
            this.ImporteChk.TabIndex = 27;
            this.ImporteChk.Text = "Importe";
            this.ImporteChk.UseVisualStyleBackColor = true;
            this.ImporteChk.CheckedChanged += new System.EventHandler(this.ImporteChk_CheckedChanged);
            // 
            // FrmCuotaBusq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 111);
            this.Controls.Add(this.ImporteTxt);
            this.Controls.Add(this.ImporteChk);
            this.Controls.Add(this.ImpagaChk);
            this.Controls.Add(this.AnuladaChk);
            this.Controls.Add(this.PagaChk);
            this.Controls.Add(this.FechaPagoChk);
            this.Controls.Add(this.FechaPagoPicker);
            this.Controls.Add(this.FechaVencimientoChk);
            this.Controls.Add(this.FechaVencimientoPicker);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.MesTxt);
            this.Controls.Add(this.MesChk);
            this.Controls.Add(this.AnioTxt);
            this.Controls.Add(this.AnioChk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCuotaBusq";
            this.Text = "FrmCuotaBusq";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.TextBox MesTxt;
        private System.Windows.Forms.CheckBox MesChk;
        private System.Windows.Forms.TextBox AnioTxt;
        private System.Windows.Forms.CheckBox AnioChk;
        private System.Windows.Forms.DateTimePicker FechaVencimientoPicker;
        private System.Windows.Forms.CheckBox FechaVencimientoChk;
        private System.Windows.Forms.CheckBox FechaPagoChk;
        private System.Windows.Forms.DateTimePicker FechaPagoPicker;
        private System.Windows.Forms.CheckBox PagaChk;
        private System.Windows.Forms.CheckBox AnuladaChk;
        private System.Windows.Forms.CheckBox ImpagaChk;
        private System.Windows.Forms.TextBox ImporteTxt;
        private System.Windows.Forms.CheckBox ImporteChk;
    }
}