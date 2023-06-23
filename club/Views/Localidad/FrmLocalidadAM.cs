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
    [Permiso(ClaseBaseForm = "Socio", FuncionPermiso = "AltaSocio,ModificaSocio,ConsultaSocio", RolUsuario = "administrador,operadorSocio,operadorTurno,consulta,operador")]
    public partial class FrmLocalidadAM : Form
    {
        public FrmLocalidadAM()
        {
            InitializeComponent();
        }

        private void FrmLocalidadAM_Load(object sender, EventArgs e)
        {

        }
    }
}
