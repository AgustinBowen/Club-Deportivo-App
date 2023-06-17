using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace clubApp.db
{
    [Table(Name = "localidad")]
    public partial class Localidad
    {
        #region variables locales
        private int _id;
        private string _nombre;
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "cod_postal", Tipo = typeof(int), EsAutoGenerado = false, EsClave = true)]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Propiedad(Name = "nombre", Tipo = typeof(string), Longitud = 60)]
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        #endregion        
    }

}
