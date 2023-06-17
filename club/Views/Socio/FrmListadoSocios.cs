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
    public partial class FrmListadoSocios : FormBase
    {
        public FrmListadoSocios()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {
            this.ExportarBtn.Enabled = Usuario.HasPermiso("Exportar");
        }

        private void ApellidoChk_CheckedChanged(object sender, EventArgs e)
        {
            this.ApellidoTxt.Enabled = this.ApellidoChk.Checked;
        }

        private void FrmListadoSocios_Load(object sender, EventArgs e)
        {            
            LoadComboBox( Localidad.FindAllStatic(null , (l1,l2)=> l1.Nombre.CompareTo(l2.Nombre)) , this.LocalidadCbo, addSeleccion: true);
                                    
            this.SociosGrd.AutoGenerateColumns = false;
            this.SociosGrd.DataSource = Socio.FindAllStatic (null, (p1,p2)=> (p1.Apellido + p1.Nombres).CompareTo(p2.Apellido+p2.Nombres));
        }

        private void LocalidadChk_CheckedChanged(object sender, EventArgs e)
        {
            this.LocalidadCbo.Enabled = LocalidadChk.Checked;
        }

        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            //
            string criterio = null;
            
            if (this.LocalidadChk.Checked && this.LocalidadCbo.SelectedIndex != -1)
            {
                if (criterio != null)
                {
                    criterio += " and cod_postal= " + LocalidadCbo.SelectedValue;
                }
                else
                    criterio = "cod_postal= " + LocalidadCbo.SelectedValue;
            }
            this.SociosGrd.DataSource = Socio.FindAllStatic(criterio, (p1, p2) => (p1.Apellido + p1.Nombres).CompareTo(p2.Apellido + p2.Nombres));            
        }

        private void SociosGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow rw in this.SociosGrd.Rows)
            {                
                rw.Cells[3].Value = (rw.DataBoundItem as Socio).LocalidadSocio.Nombre;
            }
        }

        private void SociosGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SociosGrd_DoubleClick(object sender, EventArgs e)
        {
            FrmSocioAM frmpac = new FrmSocioAM();
            Socio pac  =  (this.SociosGrd.SelectedRows[0].DataBoundItem as Socio);
            frmpac.ShowModificarSocio(pac);
        }

        private void ExportarBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Implementar funcionalidad...!", "falta...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
