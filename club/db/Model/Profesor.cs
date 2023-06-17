using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clubApp.db
{
    [Table(Name = "profesor")]
    public partial class Profesor
    {
        #region variables locales        
        private int _legajo;
        private int _dni;
        private string _apellido;
        private string _nombres;
        private string _domicilio;
        private string _telefono;                                   
           
        
        #endregion        

        #region propiedades publicas

        [Propiedad(Name = "dni", Tipo = typeof(int))]
        public int NroDocumento
        {
            get { return _dni; }
            set { _dni = value; }
        }

        [Propiedad(Name = "legajo", Tipo = typeof(int), EsAutoGenerado = true, EsClave = true)]
        public int Legajo
        {
            get { return _legajo; }
            set { _legajo = value; }
        }

        [Propiedad(Name = "apellido", Tipo = typeof(string), Longitud = 90)]
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        [Propiedad(Name = "nombres", Tipo = typeof(string), Longitud = 80)]
        public string Nombres
        {
            get { return _nombres; }
            set { _nombres = value; }
        }

        [Propiedad(Name = "domicilio", Tipo = typeof(string), Longitud = 120)]
        public string Domicilio
        {
            get { return _domicilio; }
            set { _domicilio= value; }
        }

        [Propiedad(Name = "telefono", Tipo = typeof(string), Longitud = 20)]        
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
    

       
        #endregion  

       
    }
}
