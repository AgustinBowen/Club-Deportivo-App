using System;

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
        private DateTime _fecha_hasta;
        private TipoActividad _tpAct;

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
        [Propiedad(Name = "fecha_desde", Tipo = typeof(DateTime))]
        public DateTime FechaDesde
        {
            get { return _fecha_desde; }
            set { _fecha_desde = value; }
        }
        [Propiedad(Name = "fecha_fin", Tipo = typeof(DateTime))]
        public DateTime FechaHasta
        {
            get { return _fecha_hasta; }
            set { _fecha_hasta = value; }
        }

        #endregion  
        // -- TODO --
        #region Relaciones con otras entidades

        public TipoActividad TipoActividadObj
        {
            get
            {
                if (_tpAct == null && _cod_tipo_act != 0)
                {
                    var list = TipoActividad.FindAllStatic("codigo=" + _cod_tipo_act.ToString(), (ta1, ta2) => ta1.Nombre.CompareTo(ta2.Nombre));
                    if (list != null)
                    {
                        _tpAct = list[0];
                    }
                }
                return _tpAct;

            }
        }

        #endregion
    }
}
