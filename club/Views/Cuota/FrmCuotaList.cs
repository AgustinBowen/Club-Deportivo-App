﻿using System;
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
    public partial class FrmCuotaList : FormBase
    {
        private string _criterio = null;
        private List<Cuota> _listado;
        public FrmCuotaList()
        {
            InitializeComponent();
        }

        public void ShowListado(List<Cuota> listado, FormBase Invoker, string criterio)
        {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.CuotasGrd.AutoGenerateColumns = false;
            var bindingList = new BindingList<Cuota>(listado);
            var source = new BindingSource(bindingList, null);
            this.CuotasGrd.DataSource = source;
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CuotasGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
