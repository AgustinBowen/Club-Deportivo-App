using clubApp.db;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace clubApp.Views
{
    public partial class FrmExportarArchivo : Form
    {
        List<object> _lista;
        public FrmExportarArchivo()
        {
            InitializeComponent();
            ConfigGuardar();
        }

        public void ShowExportar(List<Socio> lista)
        {
            this._lista = lista.ToList<object>();
            this.Show();
        }
        public void ShowExportar(List<Profesor> lista)
        {
            this._lista = lista.ToList<object>();
            this.Show();
        }
        public void ShowExportar(List<Localidad> lista)
        {
            this._lista = lista.ToList<object>();
            this.Show();
        }
        public void ShowExportar(List<Actividad> lista)
        {
            this._lista = lista.ToList<object>();
            this.Show();
        }
        public void ShowExportar(List<Cuota> lista)
        {
            this._lista = lista.ToList<object>();
            this.Show();
        }
        public void ShowExportar(List<Horario> lista)
        {
            this._lista = lista.ToList<object>();
            this.Show();
        }
        public void ShowExportar(List<TipoActividad> lista)
        {
            this._lista = lista.ToList<object>();
            this.Show();
        }

        //Falta auditoria


        public void ConfigGuardar()
        {
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = String.Format("{0}", DateTime.Today.ToString("yyyy-MM-dd"));
            this.saveFileDialog1.Title = "Guardar Archivo";
            this.saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void FrmExportarArchivo_Load(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                MessageBox.Show(filePath);
                using (FileStream arch = File.Open(filePath, FileMode.Create))
                {
                    using (StreamWriter writer = new StreamWriter(arch))
                    {
                        foreach (object aux in _lista)
                        {
                            writer.WriteLine(aux.ToString());
                        }
                    }
                }
            }
            this.Close();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
