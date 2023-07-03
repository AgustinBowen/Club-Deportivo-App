using clubApp.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace clubApp.Views
{
    public partial class FrmListadoProfesores : FormBase
    {
        BindingList<Profesor> bindingList;
        BindingSource bindingSource;
        string criterio = null;
        bool acendente;
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
            if (this.dniChk.Checked)
            {
                try
                {
                    int.Parse(this.dniTxt.Text);
                    criterio = string.Format("dni = {0}", this.dniTxt.Text);
                }
                catch (FormatException r)
                {
                    MessageBox.Show("Formato erroneo ingrese dni en numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (this.ApellidoChk.Checked)
            {
                if (criterio == null)
                {
                    criterio = string.Format("apellido like '%{0}%'", this.ApellidoTxt.Text);
                }
                else
                {
                    criterio += string.Format(" and apellido like '%{0}%'", this.ApellidoTxt.Text);
                }
            }
            if (this.legajoChk.Checked)
            {
                try
                {
                    int.Parse(this.legajoTxt.Text);
                    if (criterio == null)
                    {
                        criterio = string.Format("legajo = {0}", this.legajoTxt.Text);
                    }
                    else
                    {
                        criterio = string.Format(" and legajo = {0}", this.legajoTxt.Text);
                    }
                }
                catch (FormatException r)
                {
                    MessageBox.Show("Formato erroneo ingrese un legajo en numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.ProfesoresGrd.DataSource = Profesor.FindAllStatic(criterio, (p1, p2) => (p1.Apellido + p1.Nombres).CompareTo(p2.Apellido + p2.Nombres));
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
            bindingList = new BindingList<Profesor>(Profesor.FindAllStatic(criterio, (p1, p2) => (p1.Legajo).CompareTo(p2.Legajo)));
            bindingSource = new BindingSource(bindingList, null);
            this.ProfesoresGrd.DataSource = bindingSource;
        }

        private void legajoChk_CheckedChanged(object sender, EventArgs e)
        {
            this.legajoTxt.Enabled = this.legajoChk.Checked;
        }

        private void dniChk_CheckedChanged(object sender, EventArgs e)
        {
            this.dniTxt.Enabled = this.dniChk.Checked;
        }

        private void ExportarBtn_Click(object sender, EventArgs e)
        {
            FrmExportarArchivo frm = new FrmExportarArchivo();
            List<Profesor> listaProfesor = bindingList.ToList();
            frm.ShowExportar(listaProfesor);
        }
        private void ProfesoresGrd_ColumnHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            Comparison<Profesor> comparacion = (p1, p2) => (p1.Legajo).CompareTo(p2.Legajo);
            if (acendente)
            {
                switch ((sender as DataGridView).Columns[e.ColumnIndex].DataPropertyName)
                {
                    case "Legajo":
                        comparacion = (p1, p2) => (p2.Legajo).CompareTo(p1.Legajo);
                        break;
                    case "Nombres":
                        comparacion = (p1, p2) => (p2.Nombres).CompareTo(p1.Nombres);
                        break;
                    case "NroDocumento":
                        comparacion = (p1, p2) => (p2.NroDocumento).CompareTo(p1.NroDocumento);
                        break;
                    case "Apellido":
                        comparacion = (p1, p2) => (p2.Apellido).CompareTo(p1.Apellido);
                        break;
                    case "Domicilio":
                        comparacion = (p1, p2) => (p2.Domicilio).CompareTo(p1.Domicilio);
                        break;
                    case "Telefono":
                        comparacion = (p1, p2) => (p2.Telefono).CompareTo(p1.Telefono);
                        break;
                    default:
                        break;
                }
                acendente = false;
            }
            else
            {
                switch ((sender as DataGridView).Columns[e.ColumnIndex].DataPropertyName)
                {
                    case "Legajo":
                        comparacion = (p1, p2) => (p1.Legajo).CompareTo(p2.Legajo);
                        break;
                    case "Nombres":
                        comparacion = (p1, p2) => (p1.Nombres).CompareTo(p2.Nombres);
                        break;
                    case "NroDocumento":
                        comparacion = (p1, p2) => (p1.NroDocumento).CompareTo(p2.NroDocumento);
                        break;
                    case "Apellido":
                        comparacion = (p1, p2) => (p1.Apellido).CompareTo(p2.Apellido);
                        break;
                    case "Domicilio":
                        comparacion = (p1, p2) => (p1.Domicilio).CompareTo(p2.Domicilio);
                        break;
                    case "Telefono":
                        comparacion = (p1, p2) => (p1.Telefono).CompareTo(p2.Telefono);
                        break;
                    default:
                        break;
                }
                acendente = true;
            }
            List<Profesor> listAux = bindingList.ToList();
            listAux.Sort(comparacion);
            bindingList = new BindingList<Profesor>(listAux);
            bindingSource = new BindingSource(bindingList, null);
            ProfesoresGrd.DataSource = bindingSource;
        }
    }
}
