using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace clubApp.db
{
    [Table(Name = "importe_actividad")]
    public partial class ImporteActividad
    {
        #region variables locales
        private int _codigo;
        private int _cod_tipo_act;
        private int _anio;
        private int _mes;
        private float _importe;
        private TipoActividad _tipo_actividad=null;
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "codigo", Tipo = typeof(int), EsAutoGenerado = true, EsClave = true)]
        public int Id
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        [Propiedad(Name = "cod_act", Tipo = typeof(int))]
        public int CodTipoAct
        {
            get { return _cod_tipo_act; }
            set { _cod_tipo_act = value; }
        }

        [Propiedad(Name = "anio", Tipo = typeof(int))]
        public int Anio
        {
            get { return _anio; }
            set { _anio = value; }
        }

        [Propiedad(Name = "mes", Tipo = typeof(int))]
        public int Mes
        {
            get { return _mes; }
            set { _mes = value; }
        }

        [Propiedad(Name = "importe", Tipo = typeof(float))]
        public float Importe
        {
            get { return _importe; }
            set { _importe = value; }
        }

        #endregion
        // -- TODO --
        #region Relaciones con otras entidades
        // implementar las relaciones.....
        // Especie
        #endregion
    }

}
