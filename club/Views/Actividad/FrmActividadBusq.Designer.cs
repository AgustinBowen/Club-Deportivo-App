namespace clubApp.Views
{
    partial class FrmActividadBusq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActividadBusq));
            this.cancelar = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.comboProfesor = new System.Windows.Forms.ComboBox();
            this.comboCodTipoActividad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tipoActividadCHK = new System.Windows.Forms.CheckBox();
            this.profesorCHK = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(257, 91);
            this.cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(58, 27);
            this.cancelar.TabIndex = 21;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(195, 91);
            this.buscar.Margin = new System.Windows.Forms.Padding(2);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(58, 27);
            this.buscar.TabIndex = 20;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // comboProfesor
            // 
            this.comboProfesor.DisplayMember = "Nombre";
            this.comboProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProfesor.FormattingEnabled = true;
            this.comboProfesor.Location = new System.Drawing.Point(115, 48);
            this.comboProfesor.Margin = new System.Windows.Forms.Padding(2);
            this.comboProfesor.Name = "comboProfesor";
            this.comboProfesor.Size = new System.Drawing.Size(200, 21);
            this.comboProfesor.TabIndex = 27;
            this.comboProfesor.Tag = "CodTipoActividad";
            this.comboProfesor.ValueMember = "Id";
            // 
            // comboCodTipoActividad
            // 
            this.comboCodTipoActividad.DisplayMember = "Nombre";
            this.comboCodTipoActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCodTipoActividad.FormattingEnabled = true;
            this.comboCodTipoActividad.Location = new System.Drawing.Point(115, 11);
            this.comboCodTipoActividad.Margin = new System.Windows.Forms.Padding(2);
            this.comboCodTipoActividad.Name = "comboCodTipoActividad";
            this.comboCodTipoActividad.Size = new System.Drawing.Size(200, 21);
            this.comboCodTipoActividad.TabIndex = 26;
            this.comboCodTipoActividad.Tag = "CodTipoActividad";
            this.comboCodTipoActividad.ValueMember = "Id";
            this.comboCodTipoActividad.SelectedIndexChanged += new System.EventHandler(this.CodTipoActividad_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Profesor";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tipo Actividad";
            // 
            // tipoActividadCHK
            // 
            this.tipoActividadCHK.AutoSize = true;
            this.tipoActividadCHK.Location = new System.Drawing.Point(14, 14);
            this.tipoActividadCHK.Name = "tipoActividadCHK";
            this.tipoActividadCHK.Size = new System.Drawing.Size(15, 14);
            this.tipoActividadCHK.TabIndex = 28;
            this.tipoActividadCHK.UseVisualStyleBackColor = true;
            this.tipoActividadCHK.CheckedChanged += new System.EventHandler(this.tipoActividadCHK_CheckedChanged);
            // 
            // profesorCHK
            // 
            this.profesorCHK.AutoSize = true;
            this.profesorCHK.Location = new System.Drawing.Point(14, 47);
            this.profesorCHK.Name = "profesorCHK";
            this.profesorCHK.Size = new System.Drawing.Size(15, 14);
            this.profesorCHK.TabIndex = 29;
            this.profesorCHK.UseVisualStyleBackColor = true;
            this.profesorCHK.CheckedChanged += new System.EventHandler(this.profesorCHK_CheckedChanged);
            // 
            // FrmActividadBusq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 128);
            this.Controls.Add(this.profesorCHK);
            this.Controls.Add(this.tipoActividadCHK);
            this.Controls.Add(this.comboProfesor);
            this.Controls.Add(this.comboCodTipoActividad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.buscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmActividadBusq";
            this.Text = "FrmActividadBusq";
            this.Load += new System.EventHandler(this.FrmActividadBusq_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.ComboBox comboProfesor;
        private System.Windows.Forms.ComboBox comboCodTipoActividad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox tipoActividadCHK;
        private System.Windows.Forms.CheckBox profesorCHK;
    }
}