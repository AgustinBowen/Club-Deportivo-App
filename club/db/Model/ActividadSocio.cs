using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace clubApp.db
{
    [Table(Name = "actividad_socio")]
    public partial class ActividadSocio
    {
        #region variables locales
        private int _codigo;
        private int _nro_socio;
        private int _cod_act;
        private DateTime _fecha_inicio;
        private DateTime? _fecha_fin;

        private TipoActividad _tipo_actividad = null;
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "codigo", Tipo = typeof(int), EsAutoGenerado = true, EsClave = true)]
        public int Id
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        [Propiedad(Name = "cod_act", Tipo = typeof(int))]
        public int CodActividad
        {
            get { return _cod_act; }
            set { _cod_act = value; }
        }


        [Propiedad(Name = "nro_socio", Tipo = typeof(int))]
        public int NroSocio
        {
            get { return _nro_socio; }
            set { _nro_socio = value; }
        }

        [Propiedad(Name = "fecha_inicio", Tipo = typeof(DateTime))]
        public DateTime FechaInicio
        {
            get { return _fecha_inicio; }
            set { _fecha_inicio = value; }
        }
        [Propiedad(Name = "fecha_fin", Tipo = typeof(DateTime?))]
        public DateTime? FechaFin
        {
            get { return _fecha_fin; }
            set { _fecha_fin = value; }
        }

        #endregion
        // -- TODO --
        #region Relaciones con otras entidades

        // implementar TipoActividad

        #endregion
    }

}
