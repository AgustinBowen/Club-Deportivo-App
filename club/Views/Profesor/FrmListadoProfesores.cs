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
    public partial class FrmListadoProfesores : FormBase
    {
        public FrmListadoProfesores()
        {
            InitializeComponent();
        }

        private void ApellidoChk_CheckedChanged(object sender, EventArgs e)
        {
            this.ApellidoTxt.Enabled = this.ApellidoChk.Checked;
        }

   
                
        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            
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

        

        private void FrmListadoProfesores_Load(object sender, EventArgs e)
        {
            this.ProfesoresGrd.AutoGenerateColumns = false;
            this.ProfesoresGrd.DataSource = Profesor.FindAllStatic(null, (p1, p2) => (p1.Apellido + p1.Nombres).CompareTo(p2.Apellido + p2.Nombres));
        }       

    }
}
