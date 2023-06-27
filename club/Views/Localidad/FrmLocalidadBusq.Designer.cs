namespace clubApp.Views
{
    partial class FrmLocalidadBusq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLocalidadBusq));
            this.CodPostalTxt = new System.Windows.Forms.TextBox();
            this.CodPostalChk = new System.Windows.Forms.CheckBox();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.NombreChk = new System.Windows.Forms.CheckBox();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CodPostalTxt
            // 
            this.CodPostalTxt.BackColor = System.Drawing.Color.White;
            this.CodPostalTxt.Enabled = false;
            this.CodPostalTxt.Location = new System.Drawing.Point(98, 59);
            this.CodPostalTxt.Margin = new System.Windows.Forms.Padding(2);
            this.CodPostalTxt.Name = "CodPostalTxt";
            this.CodPostalTxt.Size = new System.Drawing.Size(123, 20);
            this.CodPostalTxt.TabIndex = 21;
            this.CodPostalTxt.Tag = "CodPostal";
            this.CodPostalTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodPostalTxt_KeyPress);
            // 
            // CodPostalChk
            // 
            this.CodPostalChk.AutoSize = true;
            this.CodPostalChk.Location = new System.Drawing.Point(20, 59);
            this.CodPostalChk.Margin = new System.Windows.Forms.Padding(2);
            this.CodPostalChk.Name = "CodPostalChk";
            this.CodPostalChk.Size = new System.Drawing.Size(74, 17);
            this.CodPostalChk.TabIndex = 20;
            this.CodPostalChk.Tag = "CodPostal";
            this.CodPostalChk.Text = "CodPostal";
            this.CodPostalChk.UseVisualStyleBackColor = true;
            this.CodPostalChk.CheckedChanged += new System.EventHandler(this.CodPostalChk_CheckedChanged);
            // 
            // NombreTxt
            // 
            this.NombreTxt.Enabled = false;
            this.NombreTxt.Location = new System.Drawing.Point(98, 22);
            this.NombreTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(188, 20);
            this.NombreTxt.TabIndex = 19;
            this.NombreTxt.Tag = "Nombre";
            // 
            // NombreChk
            // 
            this.NombreChk.AutoSize = true;
            this.NombreChk.Location = new System.Drawing.Point(20, 24);
            this.NombreChk.Margin = new System.Windows.Forms.Padding(2);
            this.NombreChk.Name = "NombreChk";
            this.NombreChk.Size = new System.Drawing.Size(63, 17);
            this.NombreChk.TabIndex = 18;
            this.NombreChk.Tag = "Nombre";
            this.NombreChk.Text = "Nombre";
            this.NombreChk.UseVisualStyleBackColor = true;
            this.NombreChk.CheckedChanged += new System.EventHandler(this.NombreChk_CheckedChanged);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(228, 113);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(58, 27);
            this.CancelarBtn.TabIndex = 23;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(140, 113);
            this.BuscarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(58, 27);
            this.BuscarBtn.TabIndex = 22;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // FrmLocalidadBusq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 151);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.CodPostalTxt);
            this.Controls.Add(this.CodPostalChk);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.NombreChk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLocalidadBusq";
            this.Text = "FrmLocalidadBusq";
            this.Activated += new System.EventHandler(this.FrmLocalidadBusq_Activated_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CodPostalTxt;
        private System.Windows.Forms.CheckBox CodPostalChk;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.CheckBox NombreChk;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button BuscarBtn;
    }
}