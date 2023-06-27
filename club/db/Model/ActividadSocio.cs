using System;

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
        Actividad _tpAct = null;

        private Actividad _actividad = null;
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

        [Propiedad(Name = "fecha_inicio", Tipo = typeof(DateTime), Format = "yyyy-MM-dd")]
        public DateTime FechaInicio
        {
            get { return _fecha_inicio; }
            set { _fecha_inicio = value; }
        }
        [Propiedad(Name = "fecha_fin", Tipo = typeof(DateTime?), Format = "yyyy-MM-dd")]
        public DateTime? FechaFin
        {
            get { return _fecha_fin; }
            set { _fecha_fin = value; }
        }

        #endregion
        // -- TODO --
        #region Relaciones con otras entidades

        // implementar TipoActividad
        public Actividad ActividadObj
        {
            get
            {
                if (_tpAct == null && _cod_act != 0)
                {
                    var list = Actividad.FindAllStatic("codigo=" + _cod_act.ToString(), (a1, a2) => a1.TipoActividadObj.Nombre.CompareTo(a2.TipoActividadObj.Nombre));
                    if (list.Count > 0)
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
