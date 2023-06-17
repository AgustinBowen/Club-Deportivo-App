using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace clubApp.db
{
    [Table(Name = "cuotas")]
    public partial class Cuota
    {
        #region variables locales
        private int _codigo;
        private int _cod_act_socio;
        private int _anio;
        private int _mes;        
        private string _estado;
        private float importe;
        private DateTime _fecha_venc;
        private DateTime? _fecha_pago;        
        private ActividadSocio _actividad_socioObj = null;
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "codigo", Tipo = typeof(int), EsAutoGenerado = true, EsClave = true)]
        public int Id
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        [Propiedad(Name = "cod_act_socio", Tipo = typeof(int))]
        public int CodActSocio
        {
            get { return _cod_act_socio; }
            set { _cod_act_socio = value; }
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
        
        [Propiedad(Name = "estado", Tipo = typeof(string), Longitud=1)]
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        [Propiedad(Name = "importe", Tipo = typeof(float))]
        public float Importe
        {
            get { return importe; }
            set { importe = value; }
        }

        [Propiedad(Name = "fecha_venc", Tipo = typeof(DateTime))]
        public DateTime FechaVenc
        {
            get { return _fecha_venc; }
            set { _fecha_venc = value; }
        }

        [Propiedad(Name = "fecha_pago", Tipo = typeof(DateTime?))]
        public DateTime? FechaPago
        {
            get { return _fecha_pago; }
            set { _fecha_pago = value; }
        }
        
        #endregion
        // -- TODO --
        #region Relaciones con otras entidades
        // implementar con Actividad Socio        
        #endregion
    }

}
