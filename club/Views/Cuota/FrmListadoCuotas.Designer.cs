namespace clubApp.Views
{
    partial class FrmListadoCuotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
       /* private System.ComponentModel.IContainer components = null;

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
            /*this.ExportarBtn = new System.Windows.Forms.Button();
            this.PagaChk = new System.Windows.Forms.CheckBox();
            this.ImpagaChk = new System.Windows.Forms.CheckBox();
            this.FiltroBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AnioTxt = new System.Windows.Forms.TextBox();
            this.AnioChk = new System.Windows.Forms.CheckBox();
            this.CuotasGrd = new System.Windows.Forms.DataGridView();
            this.EstadoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimientoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPagoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impaga = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Paga = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CuotasGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // ExportarBtn
            // 
            this.ExportarBtn.Location = new System.Drawing.Point(738, 450);
            this.ExportarBtn.Name = "ExportarBtn";
            this.ExportarBtn.Size = new System.Drawing.Size(84, 26);
            this.ExportarBtn.TabIndex = 14;
            this.ExportarBtn.Text = "Exportar";
            this.ExportarBtn.UseVisualStyleBackColor = false;
            // 
            // PagaChk
            // 
            this.PagaChk.AutoSize = true;
            this.PagaChk.Location = new System.Drawing.Point(264, 18);
            this.PagaChk.Name = "PagaChk";
            this.PagaChk.Size = new System.Drawing.Size(51, 17);
            this.PagaChk.TabIndex = 13;
            this.PagaChk.Text = "Paga";
            this.PagaChk.UseVisualStyleBackColor = true;
            // 
            // ImpagaChk
            // 
            this.ImpagaChk.AutoSize = true;
            this.ImpagaChk.Location = new System.Drawing.Point(379, 18);
            this.ImpagaChk.Name = "ImpagaChk";
            this.ImpagaChk.Size = new System.Drawing.Size(61, 17);
            this.ImpagaChk.TabIndex = 12;
            this.ImpagaChk.Text = "Impaga";
            this.ImpagaChk.UseVisualStyleBackColor = true;
            // 
            // FiltroBtn
            // 
            this.FiltroBtn.Location = new System.Drawing.Point(721, 10);
            this.FiltroBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FiltroBtn.Name = "FiltroBtn";
            this.FiltroBtn.Size = new System.Drawing.Size(76, 32);
            this.FiltroBtn.TabIndex = 10;
            this.FiltroBtn.Text = "Filtrar";
            this.FiltroBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AnioTxt);
            this.groupBox1.Controls.Add(this.AnioChk);
            this.groupBox1.Location = new System.Drawing.Point(11, 2);
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
            // 
            // CuotasGrd
            // 
            this.CuotasGrd.AllowUserToAddRows = false;
            this.CuotasGrd.AllowUserToDeleteRows = false;
            this.CuotasGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CuotasGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EstadoCol,
            this.FechaPagoCol,
            this.FechaVencimientoCol,
            this.ImporteCol,
            this.Impaga,
            this.Paga});
            this.CuotasGrd.Location = new System.Drawing.Point(11, 61);
            this.CuotasGrd.Margin = new System.Windows.Forms.Padding(2);
            this.CuotasGrd.MultiSelect = false;
            this.CuotasGrd.Name = "CuotasGrd";
            this.CuotasGrd.ReadOnly = true;
            this.CuotasGrd.RowTemplate.Height = 24;
            this.CuotasGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CuotasGrd.ShowEditingIcon = false;
            this.CuotasGrd.Size = new System.Drawing.Size(826, 384);
            this.CuotasGrd.TabIndex = 8;
            /*/ /*
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
            // FrmListadoCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 484);
            this.Controls.Add(this.ExportarBtn);
            this.Controls.Add(this.PagaChk);
            this.Controls.Add(this.ImpagaChk);
            this.Controls.Add(this.FiltroBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SociosGrd);
            this.Name = "FrmListadoCuotas";
            this.Text = "FrmListadoCuotas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SociosGrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }*/

        //#endregion

        private System.Windows.Forms.Button ExportarBtn;
        private System.Windows.Forms.CheckBox PagaChk;
        private System.Windows.Forms.CheckBox ImpagaChk;
        private System.Windows.Forms.Button FiltroBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox AnioTxt;
        private System.Windows.Forms.CheckBox AnioChk;
        private System.Windows.Forms.DataGridView CuotasGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActSocioCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MesCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimientoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPagoCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Paga;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Impaga;
    }
}