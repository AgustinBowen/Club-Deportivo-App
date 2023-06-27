using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clubApp.db
{
    [Table(Name = "socio")]
    public partial class Socio:IComparable
    {
        #region variables locales
        private int _nroDocumento;
        private int _nroSocio;
        private string _apellido;
        private string _nombres;
        private string _domicilio;
        private string _telefono;
        private int _cod_postal;
        private string _observaciones;
        private bool _activo;
        private bool _moroso;
        // usado para relacion con la clase Localidad, carga Lazy
        private Localidad _localidad = null;        
        #endregion        

        #region propiedades publicas

        [Propiedad(Name = "dni", Tipo = typeof(int))]
        public int NroDocumento
        {
            get { return _nroDocumento; }
            set { _nroDocumento = value; }
        }
        
        [Propiedad(Name = "nro_socio", Tipo = typeof(int), EsAutoGenerado = true, EsClave = true) ]
        public int NroSocio
        {
            get { return _nroSocio; }
            set { _nroSocio = value; }
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
        
        [Propiedad(Name = "cod_postal", Tipo = typeof(int))]
        public int CodPostal
        {
            get { return _cod_postal; }
            set {
                if (value != _cod_postal && value > 0)
                    this._localidad = null;
                _cod_postal = value;
            }
        }

        [Propiedad(Name = "observaciones", Tipo = typeof(string), Longitud = 250)]
        public string Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }
        
        [Propiedad(Name = "activo", Tipo = typeof(bool))]
        public bool Activo
        {
            get { return _activo; }
            set { _activo = value; }
        }
        [Propiedad(Name = "moroso", Tipo = typeof(bool))]
        public bool Moroso
        {
            get { return _moroso; }
            set { _moroso = value; }
        }

        #endregion  

        #region Relaciones con otras entidades
        public Localidad LocalidadSocio
        {
            get
            {
                if (_localidad == null && this._cod_postal != 0)
                {
                    _localidad = new Localidad();
                    _localidad = Localidad.FindByKeyStatic(this._cod_postal);
                }
                return _localidad;
            }
            set { _localidad = value; }
        }        
        
        #endregion

        public int CompareTo(object obj)
        {
            return this.Apellido.CompareTo((obj as Socio).Apellido);
        }
    }
}
