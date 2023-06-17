using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clubApp.db.orm;

namespace clubApp.db
{
    public partial class Actividad : BaseClass, IAccessDB<Actividad>
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionActividadGuardar;
        public List<Actividad> FindAll()
        {
            return this.FindAll(null);
        }
        public List<Actividad> FindAll(string criterio)
        {
            return ORMDB<Actividad>.FindAll(criterio);
        }
        public Actividad FindbyKey(params object[] key)
        {
            var act = ORMDB<Actividad>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Id = act.Id;
            this.CodTipoActividad = act.CodTipoActividad;
            this.LegajoProfe = act.LegajoProfe;
            this.FechaDesde = act.FechaDesde;
            this.FechaHasta = act.FechaHasta;
       
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionActividadGuardar != null)
                {// Validaciones de los datos que deben estar cargados para tener una tupla de datos valida
                    if (this.CodTipoActividad == 0)
                        ValidacionActividadGuardar("No se puede poner Denominacion vacia");
                }
            }
            return ORMDB<Actividad>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-Actividad
        public static List<Actividad> FindAllStatic(string criterio, Comparison<Actividad> compara)
        {
            var lista = ORMDB<Actividad>.FindAll(criterio);
            if(compara!=null)
                lista.Sort(compara);
            return lista;
        }
    }
}
