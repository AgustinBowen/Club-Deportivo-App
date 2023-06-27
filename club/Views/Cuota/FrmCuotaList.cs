using clubApp.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

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

        private void CuotasGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CerrarBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
