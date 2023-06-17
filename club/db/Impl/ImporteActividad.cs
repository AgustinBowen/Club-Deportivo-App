using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clubApp.db.orm;

namespace clubApp.db
{
    public partial class ImporteActividad : BaseClass, IAccessDB<ImporteActividad>
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionImporteActividadGuardar;
        public List<ImporteActividad> FindAll()
        {
            return this.FindAll(null);
        }
        public List<ImporteActividad> FindAll(string criterio)
        {
            return ORMDB<ImporteActividad>.FindAll(criterio);
        }
        public ImporteActividad FindbyKey(params object[] key)
        {
            var impact = ORMDB<ImporteActividad>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Id = impact.Id;
            this.CodTipoAct = impact.CodTipoAct;
            this.Anio = impact.Anio;
            this.Mes = impact.Mes;
            this.Importe = impact.Importe;            
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionImporteActividadGuardar != null)
                {
                    // Validaciones de los datos que deben estar cargados para tener una tupla de datos valida
                    if (CodTipoAct == 0)
                        ValidacionImporteActividadGuardar("Debe tener indicado codigo del tipo de actividad");
                }
            }
            return ORMDB<ImporteActividad>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-ImporteActividad
        public static List<ImporteActividad> FindAllStatic(string criterio, Comparison<ImporteActividad> compara)
        {
            var lista = ORMDB<ImporteActividad>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }

        public static ImporteActividad FindByKeyStatic(params object[] key)
        {
            return ORMDB<ImporteActividad>.FindbyKey(key);
        }
    }
}
