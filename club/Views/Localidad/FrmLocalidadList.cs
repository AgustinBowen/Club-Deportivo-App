using clubApp.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace clubApp.Views
{
    public partial class FrmLocalidadList : FormBase
    {
        private string _criterio = null;
        private List<Localidad> _listado;
        public FrmLocalidadList()
        {
            InitializeComponent();
        }
        public void ShowListado(List<Localidad> listado, FormBase Invoker, string criterio)
        {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.LocalidadGrd.AutoGenerateColumns = false;
            var bindingList = new BindingList<Localidad>(listado);
            var source = new BindingSource(bindingList, null);
            this.LocalidadGrd.DataSource = source;
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
