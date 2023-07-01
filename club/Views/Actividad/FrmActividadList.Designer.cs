namespace clubApp.Views
{
    partial class FrmActividadList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActividadList));
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.actividadGrd = new System.Windows.Forms.DataGridView();
            this.CodTipoActividadCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDesdeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHastaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actividadGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(709, 297);
            this.CerrarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(54, 27);
            this.CerrarBtn.TabIndex = 11;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.actividadGrd);
            this.groupBox1.Location = new System.Drawing.Point(11, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(752, 266);
            this.groupBox1.TabIndex = 10;
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
            this.CodTipoActividadCol,
            this.FechaDesdeCol,
            this.Legajo,
            this.FechaHastaCol});
            this.actividadGrd.Location = new System.Drawing.Point(4, 17);
            this.actividadGrd.Margin = new System.Windows.Forms.Padding(2);
            this.actividadGrd.MultiSelect = false;
            this.actividadGrd.Name = "actividadGrd";
            this.actividadGrd.ReadOnly = true;
            this.actividadGrd.RowTemplate.Height = 24;
            this.actividadGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.actividadGrd.Size = new System.Drawing.Size(743, 237);
            this.actividadGrd.TabIndex = 0;
            // 
            // CodTipoActividadCol
            // 
            this.CodTipoActividadCol.DataPropertyName = "CodTipoActividad";
            this.CodTipoActividadCol.HeaderText = "Codigo Tipo Actividad";
            this.CodTipoActividadCol.Name = "CodTipoActividadCol";
            this.CodTipoActividadCol.ReadOnly = true;
            this.CodTipoActividadCol.Width = 130;
            // 
            // FechaDesdeCol
            // 
            this.FechaDesdeCol.DataPropertyName = "FechaDesde";
            this.FechaDesdeCol.HeaderText = "Fecha Inicio";
            this.FechaDesdeCol.Name = "FechaDesdeCol";
            this.FechaDesdeCol.ReadOnly = true;
            this.FechaDesdeCol.Width = 130;
            // 
            // Legajo
            // 
            this.Legajo.DataPropertyName = "LegajoProfe";
            this.Legajo.HeaderText = "Legajo Del Profesor";
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            this.Legajo.Width = 80;
            // 
            // FechaHastaCol
            // 
            this.FechaHastaCol.DataPropertyName = "FechaHasta";
            this.FechaHastaCol.HeaderText = "Fecha Finalizacion";
            this.FechaHastaCol.Name = "FechaHastaCol";
            this.FechaHastaCol.ReadOnly = true;
            this.FechaHastaCol.Width = 140;
            // 
            // FrmActividadList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 335);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmActividadList";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmActividadList_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.actividadGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView actividadGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodTipoActividadCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDesdeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFinCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHastaCol;
    }
}