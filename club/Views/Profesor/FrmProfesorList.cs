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
    public partial class FrmProfesorList : FormBase
    {
        private string _criterio = null;
        private List<Profesor> _listado;
        public FrmProfesorList()
        {
            InitializeComponent();
        }
        public void ShowListado(List<Profesor> listado, FormBase Invoker, string criterio)
        {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.ProfesorGrd.AutoGenerateColumns = false;
            var bindingList = new BindingList<Profesor>(listado);
            var source = new BindingSource(bindingList, null);
            this.ProfesorGrd.DataSource = source;
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }
    }
}
