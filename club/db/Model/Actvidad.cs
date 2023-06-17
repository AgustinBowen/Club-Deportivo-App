using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clubApp.db
{
    [Table(Name = "actividad")]
    public partial class Actividad
    {
        #region variables locales
        private int _codigo;
        private int _cod_tipo_act;
        private int _legajo_profe;
        private DateTime _fecha_desde;
        private DateTime? _fecha_hasta;

        private TipoActividad _tipo_actividad = null;
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "codigo", Tipo = typeof(int), EsAutoGenerado = true, EsClave = true)]
        public int Id
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        [Propiedad(Name = "legajo_profe", Tipo = typeof(int))]
        public int LegajoProfe
        {
            get { return _legajo_profe; }
            set { _legajo_profe = value; }
        }

       
        [Propiedad(Name = "cod_tipo_act", Tipo = typeof(int))]
        public int CodTipoActividad
        {
            get { return _cod_tipo_act; }
            set { _cod_tipo_act = value; }
        }
        public DateTime FechaDesde
        {
            get { return _fecha_desde; }
            set { _fecha_desde = value; }
        }
        public DateTime? FechaHasta
        {
            get { return _fecha_hasta; }
            set { _fecha_hasta = value; }
        }

        #endregion  
        // -- TODO --
        #region Relaciones con otras entidades

        // implementar TipoActividad

        #endregion
    }
}
