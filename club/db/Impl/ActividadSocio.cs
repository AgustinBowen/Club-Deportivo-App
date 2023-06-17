using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clubApp.db.orm;

namespace clubApp.db
{
    public partial class ActividadSocio : BaseClass, IAccessDB<ActividadSocio>
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionActividadSocioGuardar;
        public List<ActividadSocio> FindAll()
        {
            return this.FindAll(null);
        }
        public List<ActividadSocio> FindAll(string criterio)
        {
            return ORMDB<ActividadSocio>.FindAll(criterio);
        }
        public ActividadSocio FindbyKey(params object[] key)
        {
            var actSoc = ORMDB<ActividadSocio>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Id = actSoc.Id;
            this.CodActividad = actSoc.CodActividad;

            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionActividadSocioGuardar != null)
                {
                    // Validaciones de los datos que deben estar cargados para tener una tupla de datos valida  
                }
            }
            return ORMDB<ActividadSocio>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-ActividadSocio
        public static List<ActividadSocio> FindAllStatic(string criterio, Comparison<ActividadSocio> compara)
        {
            var lista = ORMDB<ActividadSocio>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }

        public static ActividadSocio FindByKeyStatic(params object[] key)
        {
            return ORMDB<ActividadSocio>.FindbyKey(key);
        }
    }
}
