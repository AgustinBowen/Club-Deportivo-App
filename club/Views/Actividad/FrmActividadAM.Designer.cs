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
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ObservacionesTxt = new System.Windows.Forms.TextBox();
            this.DateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.CodTipoActividad = new System.Windows.Forms.ComboBox();
            this.DateTimeFin = new System.Windows.Forms.Label();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(279, 381);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(59, 27);
            this.CancelarBtn.TabIndex = 12;
            this.CancelarBtn.Text = "&Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(197, 381);
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
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.DateTimePicker1);
            this.groupBox1.Controls.Add(this.DateTimeInicio);
            this.groupBox1.Controls.Add(this.DateTimeFin);
            this.groupBox1.Controls.Add(this.CodTipoActividad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ObservacionesTxt);
            this.groupBox1.Location = new System.Drawing.Point(59, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 349);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Profesor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Observaciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Fecha Inicio";
            // 
            // ObservacionesTxt
            // 
            this.ObservacionesTxt.Location = new System.Drawing.Point(114, 292);
            this.ObservacionesTxt.Name = "ObservacionesTxt";
            this.ObservacionesTxt.Size = new System.Drawing.Size(100, 20);
            this.ObservacionesTxt.TabIndex = 15;
            // 
            // DateTimeInicio
            // 
            this.DateTimeInicio.Location = new System.Drawing.Point(98, 190);
            this.DateTimeInicio.Name = "DateTimeInicio";
            this.DateTimeInicio.Size = new System.Drawing.Size(200, 20);
            this.DateTimeInicio.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tipo Actividad";
            // 
            // CodTipoActividad
            // 
            this.CodTipoActividad.DisplayMember = "Nombre";
            this.CodTipoActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CodTipoActividad.FormattingEnabled = true;
            this.CodTipoActividad.Location = new System.Drawing.Point(107, 73);
            this.CodTipoActividad.Margin = new System.Windows.Forms.Padding(2);
            this.CodTipoActividad.Name = "CodTipoActividad";
            this.CodTipoActividad.Size = new System.Drawing.Size(157, 21);
            this.CodTipoActividad.TabIndex = 20;
            this.CodTipoActividad.Tag = "CodTipoActividad";
            this.CodTipoActividad.ValueMember = "Id";
            this.CodTipoActividad.SelectedIndexChanged += new System.EventHandler(this.CodTipoActividad_SelectedIndexChanged);
            // 
            // DateTimeFin
            // 
            this.DateTimeFin.AutoSize = true;
            this.DateTimeFin.Location = new System.Drawing.Point(27, 241);
            this.DateTimeFin.Name = "DateTimeFin";
            this.DateTimeFin.Size = new System.Drawing.Size(54, 13);
            this.DateTimeFin.TabIndex = 21;
            this.DateTimeFin.Text = "Fecha Fin";
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Location = new System.Drawing.Point(98, 241);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.DateTimePicker1.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Nombre";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(107, 133);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 21);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.Tag = "CodTipoActividad";
            this.comboBox1.ValueMember = "Id";
            // 
            // FrmActividadAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ObservacionesTxt;
        private System.Windows.Forms.DateTimePicker DateTimeInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CodTipoActividad;
        private System.Windows.Forms.DateTimePicker DateTimePicker1;
        private System.Windows.Forms.Label DateTimeFin;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}