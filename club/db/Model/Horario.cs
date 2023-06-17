using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace clubApp.db
{
    [Table(Name = "horario")]
    public partial class Horario
    {
        #region variables locales
        private int _codigo;
        private int _dia;
        private int _cod_act;
        private DateTime _hora_desde;
        private DateTime _hora_hasta;
        private int _cod_lugar;
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "codigo", Tipo = typeof(int), EsAutoGenerado = true, EsClave = true)]
        public int Id
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        [Propiedad(Name = "dia", Tipo = typeof(int))]
        public int Dia
        {
            get { return _dia; }
            set { _dia = value; }
        }

        [Propiedad(Name = "cod_act", Tipo = typeof(int))]
        public int CodAct
        {
            get { return _cod_act; }
            set { _cod_act = value; }
        }

        [Propiedad(Name = "hora_desde", Tipo = typeof(DateTime))]
        public DateTime HoraDesde
        {
            get { return _hora_desde; }
            set { _hora_desde = value; }
        }
        [Propiedad(Name = "hora_hasta", Tipo = typeof(DateTime))]
        public DateTime HoraHasta
        {
            get { return _hora_hasta; }
            set { _hora_hasta = value; }
        }

        [Propiedad(Name = "cod_lugar", Tipo = typeof(int))]
        public int CodLugar
        {
            get { return _cod_lugar; }
            set { _cod_lugar = value; }
        }

        #endregion

        // -- TODO --
        #region Relaciones con otras entidades
        // implementar Actividad
        // implementar Lugar
        #endregion
    }

}
