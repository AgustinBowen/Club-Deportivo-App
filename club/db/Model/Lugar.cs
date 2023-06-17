using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clubApp.db
{
    [Table(Name = "lugar")]
    public partial class Lugar
    {
        #region variables locales
        private int _codigo;
        private string _descripcion;        
        #endregion
        
        #region propiedades publicas

        [Propiedad(Name = "codigo", Tipo = typeof(int), EsAutoGenerado = true, EsClave = true)]
        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        [Propiedad(Name = "descripcion", Tipo = typeof(string),Longitud=90)]
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        #endregion  
        
      
        
    }
}
