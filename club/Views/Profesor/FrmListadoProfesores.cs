using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clubApp.db;

namespace clubApp.Views
{
    public partial class FrmListadoProfesores : Form
    {
        public FrmListadoProfesores()
        {
            InitializeComponent();
        }

        private void ApellidoChk_CheckedChanged(object sender, EventArgs e)
        {
            this.ApellidoTxt.Enabled = this.ApellidoChk.Checked;
        }

        private void FrmListadoProfesors_Load(object sender, EventArgs e)
        {
            this.ProfesoresGrd.AutoGenerateColumns = false;
            this.ProfesoresGrd.DataSource = ORMDB<Profesor>.FindAll(null);
            
        }
                
        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            //
            string criterio = null;
            
            this.ProfesoresGrd.AutoGenerateColumns = false;
            this.ProfesoresGrd.DataSource = ORMDB<Profesor>.FindAll(criterio);
        }

        private void ProfesoresGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow rw in this.ProfesoresGrd.Rows)
            {
                //rw.Cells[4].Value = (rw.DataBoundItem as Profesor).LocalidadProfesor.Nombre;
                //rw.Cells[5].Value = (rw.DataBoundItem as Profesor).ListadoEspecialidades;
               //rw.Cells[4].Value = (rw.DataBoundItem as Profesor).LocalidadProfesor.Nombre;
            }
        }

        public void ShowListar()
        {
            this.Show();
        }

        private void ProfesoresGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }       

    }
}
