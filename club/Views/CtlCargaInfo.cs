using System;
using System.Windows.Forms;

namespace clubApp.Views
{
    public partial class CtlCargaInfo : UserControl
    {
        public CtlCargaInfo()
        {
            InitializeComponent();
        }

        private void CtlCargaInfo_Load(object sender, EventArgs e)
        {

        }

        public string Etiqueta
        {
            get { return lblEtiqueta.Text; }
            set { this.lblEtiqueta.Text = value; }
        }
        public string Texto
        {
            get
            {
                return this.txtTexto.Text;
            }
            set
            {
                this.txtTexto.Text = value;
            }
        }

    }
}
