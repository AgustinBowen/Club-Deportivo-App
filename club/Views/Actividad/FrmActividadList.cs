using clubApp.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace clubApp.Views
{
    public partial class FrmActividadList : FormBase
    {
        List<Actividad> _listado;
        string _criterio;

        public FrmActividadList()
        {
            InitializeComponent();
        }
        public void ShowListado(List<Actividad> listado, FormBase Invoker, string criterio)
        {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.actividadGrd.AutoGenerateColumns = false;
            var bindingList = new BindingList<Actividad>(listado);
            var source = new BindingSource(bindingList, null);
            this.actividadGrd.DataSource = source;
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }
        private void FrmActividadList_Load(object sender, EventArgs e)
        {

        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
