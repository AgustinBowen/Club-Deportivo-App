namespace clubApp.Views
{
    partial class FrmCuotaList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCuotaList));
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CuotasGrd = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodActSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVenc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CuotasGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(815, 297);
            this.CerrarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(54, 27);
            this.CerrarBtn.TabIndex = 9;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CuotasGrd);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(858, 282);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado...";
            // 
            // CuotasGrd
            // 
            this.CuotasGrd.AllowUserToAddRows = false;
            this.CuotasGrd.AllowUserToDeleteRows = false;
            this.CuotasGrd.AllowUserToResizeColumns = false;
            this.CuotasGrd.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CuotasGrd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CuotasGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CuotasGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CodActSocio,
            this.Estado,
            this.Anio,
            this.Mes,
            this.Importe,
            this.FechaVenc,
            this.FechaPago});
            this.CuotasGrd.Location = new System.Drawing.Point(5, 17);
            this.CuotasGrd.Margin = new System.Windows.Forms.Padding(2);
            this.CuotasGrd.MultiSelect = false;
            this.CuotasGrd.Name = "CuotasGrd";
            this.CuotasGrd.ReadOnly = true;
            this.CuotasGrd.RowTemplate.Height = 24;
            this.CuotasGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CuotasGrd.Size = new System.Drawing.Size(844, 253);
            this.CuotasGrd.TabIndex = 0;
            this.CuotasGrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CuotasGrd_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Codigo cuota";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // CodActSocio
            // 
            this.CodActSocio.DataPropertyName = "CodActSocio";
            this.CodActSocio.HeaderText = "Actividad socio";
            this.CodActSocio.Name = "CodActSocio";
            this.CodActSocio.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Estado.Width = 130;
            // 
            // Anio
            // 
            this.Anio.DataPropertyName = "Anio";
            this.Anio.HeaderText = "Año";
            this.Anio.Name = "Anio";
            this.Anio.ReadOnly = true;
            this.Anio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Anio.Width = 130;
            // 
            // Mes
            // 
            this.Mes.DataPropertyName = "Mes";
            this.Mes.HeaderText = "Mes";
            this.Mes.Name = "Mes";
            this.Mes.ReadOnly = true;
            this.Mes.Width = 80;
            // 
            // Importe
            // 
            this.Importe.DataPropertyName = "Importe";
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 80;
            // 
            // FechaVenc
            // 
            this.FechaVenc.DataPropertyName = "FechaVenc";
            this.FechaVenc.HeaderText = "Fecha vencimiento";
            this.FechaVenc.Name = "FechaVenc";
            this.FechaVenc.ReadOnly = true;
            this.FechaVenc.Width = 80;
            // 
            // FechaPago
            // 
            this.FechaPago.DataPropertyName = "FechaPago";
            this.FechaPago.HeaderText = "Fecha Pago";
            this.FechaPago.Name = "FechaPago";
            this.FechaPago.ReadOnly = true;
            this.FechaPago.Width = 101;
            // 
            // FrmCuotaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 339);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCuotaList";
            this.Text = "FrmCuotaList";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CuotasGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView CuotasGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActividadSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodActSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVenc;
    }
}