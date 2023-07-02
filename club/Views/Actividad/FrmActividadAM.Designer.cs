namespace clubApp.Views
{
    partial class FrmActividadAM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActividadAM));
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProfesorCbo = new System.Windows.Forms.ComboBox();
            this.DateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.CodTipoActividad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(281, 189);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(59, 27);
            this.CancelarBtn.TabIndex = 12;
            this.CancelarBtn.Text = "&Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(218, 189);
            this.GuardarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(59, 27);
            this.GuardarBtn.TabIndex = 11;
            this.GuardarBtn.Text = "&Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProfesorCbo);
            this.groupBox1.Controls.Add(this.DateTimeInicio);
            this.groupBox1.Controls.Add(this.CodTipoActividad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 171);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // ProfesorCbo
            // 
            this.ProfesorCbo.DisplayMember = "Nombre";
            this.ProfesorCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProfesorCbo.FormattingEnabled = true;
            this.ProfesorCbo.Location = new System.Drawing.Point(87, 78);
            this.ProfesorCbo.Margin = new System.Windows.Forms.Padding(2);
            this.ProfesorCbo.Name = "ProfesorCbo";
            this.ProfesorCbo.Size = new System.Drawing.Size(200, 21);
            this.ProfesorCbo.TabIndex = 23;
            this.ProfesorCbo.Tag = "CodTipoActividad";
            this.ProfesorCbo.ValueMember = "Id";
            // 
            // DateTimeInicio
            // 
            this.DateTimeInicio.Location = new System.Drawing.Point(87, 135);
            this.DateTimeInicio.Name = "DateTimeInicio";
            this.DateTimeInicio.Size = new System.Drawing.Size(200, 20);
            this.DateTimeInicio.TabIndex = 0;
            // 
            // CodTipoActividad
            // 
            this.CodTipoActividad.DisplayMember = "Nombre";
            this.CodTipoActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CodTipoActividad.FormattingEnabled = true;
            this.CodTipoActividad.Location = new System.Drawing.Point(87, 18);
            this.CodTipoActividad.Margin = new System.Windows.Forms.Padding(2);
            this.CodTipoActividad.Name = "CodTipoActividad";
            this.CodTipoActividad.Size = new System.Drawing.Size(200, 21);
            this.CodTipoActividad.TabIndex = 20;
            this.CodTipoActividad.Tag = "CodTipoActividad";
            this.CodTipoActividad.ValueMember = "Id";
            this.CodTipoActividad.SelectedIndexChanged += new System.EventHandler(this.CodTipoActividad_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Profesor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Fecha Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tipo Actividad";
            // 
            // FrmActividadAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 227);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmActividadAM";
            this.Text = "FrmActividadAM";
            this.Load += new System.EventHandler(this.FrmActividadAM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DateTimeInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CodTipoActividad;
        private System.Windows.Forms.ComboBox ProfesorCbo;
    }
}