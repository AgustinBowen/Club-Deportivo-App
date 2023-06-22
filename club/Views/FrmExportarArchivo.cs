﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using clubApp.db;

namespace clubApp.Views
{
    public partial class FrmExportarArchivo : Form
    {
        List<Socio> _lista;
        public FrmExportarArchivo()
        {
            InitializeComponent();
            ConfigGuardar();
        }

        public void ShowExportar(List<Socio> lista){
            this._lista = lista;
            this.Show();
        }


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
                        foreach (Socio socAux in _lista)
                        {
                            writer.WriteLine(socAux.ToString());
                        }
                    }
                }
            }
            this.Close();
        }
    }
}
