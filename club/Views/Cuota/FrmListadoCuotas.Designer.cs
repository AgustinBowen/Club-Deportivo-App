namespace clubApp.Views
{
    partial class FrmListadoCuotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoCuotas));
            this.ExportarBtn = new System.Windows.Forms.Button();
            this.PagaChk = new System.Windows.Forms.CheckBox();
            this.ImpagaChk = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FechaPagoPicker = new System.Windows.Forms.DateTimePicker();
            this.FechaVencimientoPicker = new System.Windows.Forms.DateTimePicker();
            this.FechaPagoChk = new System.Windows.Forms.CheckBox();
            this.FechaVencimientoChk = new System.Windows.Forms.CheckBox();
            this.FiltroBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AnioTxt = new System.Windows.Forms.TextBox();
            this.AnioChk = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MesTxt = new System.Windows.Forms.TextBox();
            this.MesChk = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ImporteTxt = new System.Windows.Forms.TextBox();
            this.ImporteChk = new System.Windows.Forms.CheckBox();
            this.AnuladaChk = new System.Windows.Forms.CheckBox();
            this.CuotasGrd = new System.Windows.Forms.DataGridView();
            this.IdCuotaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodActSocioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimientoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPagoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PagarBtn = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CuotasGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // ExportarBtn
            // 
            this.ExportarBtn.Location = new System.Drawing.Point(739, 458);
            this.ExportarBtn.Name = "ExportarBtn";
            this.ExportarBtn.Size = new System.Drawing.Size(84, 26);
            this.ExportarBtn.TabIndex = 14;
            this.ExportarBtn.Text = "Exportar";
            this.ExportarBtn.UseVisualStyleBackColor = false;
            this.ExportarBtn.Click += new System.EventHandler(this.ExportarBtn_Click);
            // 
            // PagaChk
            // 
            this.PagaChk.AutoSize = true;
            this.PagaChk.Location = new System.Drawing.Point(601, 67);
            this.PagaChk.Name = "PagaChk";
            this.PagaChk.Size = new System.Drawing.Size(51, 17);
            this.PagaChk.TabIndex = 13;
            this.PagaChk.Text = "Paga";
            this.PagaChk.UseVisualStyleBackColor = true;
            this.PagaChk.CheckedChanged += new System.EventHandler(this.PagaChk_CheckedChanged);
            // 
            // ImpagaChk
            // 
            this.ImpagaChk.AutoSize = true;
            this.ImpagaChk.Location = new System.Drawing.Point(666, 67);
            this.ImpagaChk.Name = "ImpagaChk";
            this.ImpagaChk.Size = new System.Drawing.Size(61, 17);
            this.ImpagaChk.TabIndex = 12;
            this.ImpagaChk.Text = "Impaga";
            this.ImpagaChk.UseVisualStyleBackColor = true;
            this.ImpagaChk.CheckedChanged += new System.EventHandler(this.ImpagaChk_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FechaPagoPicker);
            this.groupBox3.Controls.Add(this.FechaVencimientoPicker);
            this.groupBox3.Controls.Add(this.FechaPagoChk);
            this.groupBox3.Controls.Add(this.FechaVencimientoChk);
            this.groupBox3.Location = new System.Drawing.Point(23, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(330, 81);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // FechaPagoPicker
            // 
            this.FechaPagoPicker.Enabled = false;
            this.FechaPagoPicker.Location = new System.Drawing.Point(125, 53);
            this.FechaPagoPicker.Name = "FechaPagoPicker";
            this.FechaPagoPicker.Size = new System.Drawing.Size(200, 20);
            this.FechaPagoPicker.TabIndex = 4;
            // 
            // FechaVencimientoPicker
            // 
            this.FechaVencimientoPicker.Enabled = false;
            this.FechaVencimientoPicker.Location = new System.Drawing.Point(124, 15);
            this.FechaVencimientoPicker.Name = "FechaVencimientoPicker";
            this.FechaVencimientoPicker.Size = new System.Drawing.Size(200, 20);
            this.FechaVencimientoPicker.TabIndex = 3;
            this.FechaVencimientoPicker.ValueChanged += new System.EventHandler(this.FechaVencimientoPicker_ValueChanged);
            // 
            // FechaPagoChk
            // 
            this.FechaPagoChk.AutoSize = true;
            this.FechaPagoChk.Location = new System.Drawing.Point(10, 47);
            this.FechaPagoChk.Margin = new System.Windows.Forms.Padding(2);
            this.FechaPagoChk.Name = "FechaPagoChk";
            this.FechaPagoChk.Size = new System.Drawing.Size(83, 17);
            this.FechaPagoChk.TabIndex = 2;
            this.FechaPagoChk.Text = "Fecha pago";
            this.FechaPagoChk.UseVisualStyleBackColor = true;
            this.FechaPagoChk.CheckedChanged += new System.EventHandler(this.FechaPagoChk_CheckedChanged);
            // 
            // FechaVencimientoChk
            // 
            this.FechaVencimientoChk.AutoSize = true;
            this.FechaVencimientoChk.Location = new System.Drawing.Point(10, 15);
            this.FechaVencimientoChk.Margin = new System.Windows.Forms.Padding(2);
            this.FechaVencimientoChk.Name = "FechaVencimientoChk";
            this.FechaVencimientoChk.Size = new System.Drawing.Size(116, 17);
            this.FechaVencimientoChk.TabIndex = 0;
            this.FechaVencimientoChk.Text = "Fecha vencimiento";
            this.FechaVencimientoChk.UseVisualStyleBackColor = true;
            this.FechaVencimientoChk.CheckedChanged += new System.EventHandler(this.FechaVencimientoChk_CheckedChanged);
            // 
            // FiltroBtn
            // 
            this.FiltroBtn.Location = new System.Drawing.Point(747, 19);
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
            this.groupBox1.Controls.Add(this.AnioTxt);
            this.groupBox1.Controls.Add(this.AnioChk);
            this.groupBox1.Location = new System.Drawing.Point(366, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(227, 42);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // AnioTxt
            // 
            this.AnioTxt.Enabled = false;
            this.AnioTxt.Location = new System.Drawing.Point(69, 15);
            this.AnioTxt.Margin = new System.Windows.Forms.Padding(2);
            this.AnioTxt.Name = "AnioTxt";
            this.AnioTxt.Size = new System.Drawing.Size(146, 20);
            this.AnioTxt.TabIndex = 1;
            // 
            // AnioChk
            // 
            this.AnioChk.AutoSize = true;
            this.AnioChk.Location = new System.Drawing.Point(4, 17);
            this.AnioChk.Margin = new System.Windows.Forms.Padding(2);
            this.AnioChk.Name = "AnioChk";
            this.AnioChk.Size = new System.Drawing.Size(45, 17);
            this.AnioChk.TabIndex = 0;
            this.AnioChk.Text = "Año";
            this.AnioChk.UseVisualStyleBackColor = true;
            this.AnioChk.CheckedChanged += new System.EventHandler(this.AnioChk_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MesTxt);
            this.groupBox2.Controls.Add(this.MesChk);
            this.groupBox2.Location = new System.Drawing.Point(366, 50);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(227, 42);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // MesTxt
            // 
            this.MesTxt.Enabled = false;
            this.MesTxt.Location = new System.Drawing.Point(69, 15);
            this.MesTxt.Margin = new System.Windows.Forms.Padding(2);
            this.MesTxt.Name = "MesTxt";
            this.MesTxt.Size = new System.Drawing.Size(146, 20);
            this.MesTxt.TabIndex = 1;
            // 
            // MesChk
            // 
            this.MesChk.AutoSize = true;
            this.MesChk.Location = new System.Drawing.Point(4, 17);
            this.MesChk.Margin = new System.Windows.Forms.Padding(2);
            this.MesChk.Name = "MesChk";
            this.MesChk.Size = new System.Drawing.Size(46, 17);
            this.MesChk.TabIndex = 0;
            this.MesChk.Text = "Mes";
            this.MesChk.UseVisualStyleBackColor = true;
            this.MesChk.CheckedChanged += new System.EventHandler(this.MesChk_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ImporteTxt);
            this.groupBox4.Controls.Add(this.ImporteChk);
            this.groupBox4.Location = new System.Drawing.Point(597, 11);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(137, 42);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // ImporteTxt
            // 
            this.ImporteTxt.Enabled = false;
            this.ImporteTxt.Location = new System.Drawing.Point(69, 15);
            this.ImporteTxt.Margin = new System.Windows.Forms.Padding(2);
            this.ImporteTxt.Name = "ImporteTxt";
            this.ImporteTxt.Size = new System.Drawing.Size(58, 20);
            this.ImporteTxt.TabIndex = 1;
            // 
            // ImporteChk
            // 
            this.ImporteChk.AutoSize = true;
            this.ImporteChk.Location = new System.Drawing.Point(4, 17);
            this.ImporteChk.Margin = new System.Windows.Forms.Padding(2);
            this.ImporteChk.Name = "ImporteChk";
            this.ImporteChk.Size = new System.Drawing.Size(61, 17);
            this.ImporteChk.TabIndex = 0;
            this.ImporteChk.Text = "Importe";
            this.ImporteChk.UseVisualStyleBackColor = true;
            this.ImporteChk.CheckedChanged += new System.EventHandler(this.ImporteChk_CheckedChanged);
            // 
            // AnuladaChk
            // 
            this.AnuladaChk.AutoSize = true;
            this.AnuladaChk.Location = new System.Drawing.Point(733, 67);
            this.AnuladaChk.Name = "AnuladaChk";
            this.AnuladaChk.Size = new System.Drawing.Size(65, 17);
            this.AnuladaChk.TabIndex = 15;
            this.AnuladaChk.Text = "Anulada";
            this.AnuladaChk.UseVisualStyleBackColor = true;
            this.AnuladaChk.CheckedChanged += new System.EventHandler(this.AnuladaChk_CheckedChanged);
            // 
            // CuotasGrd
            // 
            this.CuotasGrd.AllowUserToAddRows = false;
            this.CuotasGrd.AllowUserToDeleteRows = false;
            this.CuotasGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CuotasGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCuotaCol,
            this.CodActSocioCol,
            this.AnioCol,
            this.MesCol,
            this.EstadoCol,
            this.ImporteCol,
            this.FechaVencimientoCol,
            this.FechaPagoCol});
            this.CuotasGrd.Location = new System.Drawing.Point(23, 106);
            this.CuotasGrd.Margin = new System.Windows.Forms.Padding(2);
            this.CuotasGrd.MultiSelect = false;
            this.CuotasGrd.Name = "CuotasGrd";
            this.CuotasGrd.ReadOnly = true;
            this.CuotasGrd.RowTemplate.Height = 24;
            this.CuotasGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CuotasGrd.ShowEditingIcon = false;
            this.CuotasGrd.Size = new System.Drawing.Size(800, 347);
            this.CuotasGrd.TabIndex = 0;
            this.CuotasGrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CuotasGrd_CellContentClick);
            this.CuotasGrd.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CuotasGrd_ColumnHeaderMouseClick);
            this.CuotasGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.CuotasGrd_DataBindingComplete);
            this.CuotasGrd.DoubleClick += new System.EventHandler(this.CuotasGrd_DoubleClick);
            // 
            // IdCuotaCol
            // 
            this.IdCuotaCol.DataPropertyName = "Id";
            this.IdCuotaCol.HeaderText = "ID Cuota";
            this.IdCuotaCol.Name = "IdCuotaCol";
            this.IdCuotaCol.ReadOnly = true;
            // 
            // CodActSocioCol
            // 
            this.CodActSocioCol.DataPropertyName = "CodActSocio";
            this.CodActSocioCol.HeaderText = "Actividad socio";
            this.CodActSocioCol.Name = "CodActSocioCol";
            this.CodActSocioCol.ReadOnly = true;
            // 
            // AnioCol
            // 
            this.AnioCol.DataPropertyName = "Anio";
            this.AnioCol.HeaderText = "Año";
            this.AnioCol.Name = "AnioCol";
            this.AnioCol.ReadOnly = true;
            // 
            // MesCol
            // 
            this.MesCol.DataPropertyName = "Mes";
            this.MesCol.HeaderText = "Mes";
            this.MesCol.Name = "MesCol";
            this.MesCol.ReadOnly = true;
            // 
            // EstadoCol
            // 
            this.EstadoCol.DataPropertyName = "Estado";
            this.EstadoCol.HeaderText = "Estado";
            this.EstadoCol.Name = "EstadoCol";
            this.EstadoCol.ReadOnly = true;
            // 
            // ImporteCol
            // 
            this.ImporteCol.DataPropertyName = "Importe";
            this.ImporteCol.HeaderText = "Importe";
            this.ImporteCol.Name = "ImporteCol";
            this.ImporteCol.ReadOnly = true;
            // 
            // FechaVencimientoCol
            // 
            this.FechaVencimientoCol.DataPropertyName = "FechaVenc";
            this.FechaVencimientoCol.HeaderText = "Fecha vencimiento";
            this.FechaVencimientoCol.Name = "FechaVencimientoCol";
            this.FechaVencimientoCol.ReadOnly = true;
            // 
            // FechaPagoCol
            // 
            this.FechaPagoCol.DataPropertyName = "FechaPago";
            this.FechaPagoCol.HeaderText = "Fecha pago";
            this.FechaPagoCol.Name = "FechaPagoCol";
            this.FechaPagoCol.ReadOnly = true;
            // 
            // PagarBtn
            // 
            this.PagarBtn.Location = new System.Drawing.Point(652, 461);
            this.PagarBtn.Name = "PagarBtn";
            this.PagarBtn.Size = new System.Drawing.Size(75, 23);
            this.PagarBtn.TabIndex = 16;
            this.PagarBtn.Text = "Pagar Cuota";
            this.PagarBtn.UseVisualStyleBackColor = true;
            this.PagarBtn.Click += new System.EventHandler(this.PagarBtn_Click);
            // 
            // FrmListadoCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 492);
            this.Controls.Add(this.PagarBtn);
            this.Controls.Add(this.CuotasGrd);
            this.Controls.Add(this.AnuladaChk);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ExportarBtn);
            this.Controls.Add(this.PagaChk);
            this.Controls.Add(this.ImpagaChk);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.FiltroBtn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListadoCuotas";
            this.Text = "FrmListadoCuotas";
            this.Load += new System.EventHandler(this.FrmListadoCuotas_Load_1);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CuotasGrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExportarBtn;
        private System.Windows.Forms.CheckBox PagaChk;
        private System.Windows.Forms.CheckBox ImpagaChk;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox FechaVencimientoChk;
        private System.Windows.Forms.Button FiltroBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox AnioTxt;
        private System.Windows.Forms.CheckBox AnioChk;
        private System.Windows.Forms.DateTimePicker FechaPagoPicker;
        private System.Windows.Forms.DateTimePicker FechaVencimientoPicker;
        private System.Windows.Forms.CheckBox FechaPagoChk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox MesTxt;
        private System.Windows.Forms.CheckBox MesChk;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox ImporteTxt;
        private System.Windows.Forms.CheckBox ImporteChk;
        private System.Windows.Forms.CheckBox AnuladaChk;
        private System.Windows.Forms.DataGridView CuotasGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCuotaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MesCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPagoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodActSocioCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimientoCol;
        private System.Windows.Forms.Button PagarBtn;
    }
}