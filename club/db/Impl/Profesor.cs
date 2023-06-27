using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clubApp.db.orm;

namespace clubApp.db
{
    public partial class Profesor : BaseClass, IAccessDB<Profesor>
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionProfesorGuardar;
        public List<Profesor> FindAll()
        {
            return this.FindAll(null);
        }
        public List<Profesor> FindAll(string criterio)
        {
            return ORMDB<Profesor>.FindAll(criterio);
        }
        public Profesor FindbyKey(params object[] key)
        {
            var prof = ORMDB<Profesor>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.NroDocumento = prof.NroDocumento;
            this.Legajo = prof.Legajo;
            this.Apellido = prof.Apellido;
            this.Nombres = prof.Nombres;
            this.Domicilio = prof.Domicilio;
            this.Telefono = prof.Telefono;
            
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionProfesorGuardar != null)
                {
                    // Validaciones de los datos que deben estar cargados para tener una tupla de datos valida
                    if (NroDocumento == 0)
                        ValidacionProfesorGuardar("No se puede poner NroDocumento cero");
                }
            }
            return ORMDB<Profesor>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-Profesor
        public static List<Profesor> FindAllStatic(string criterio, Comparison<Profesor> compara)
        {
            var lista = ORMDB<Profesor>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }
        public static bool ExisteProfesor(int doc)
        {
            var list = FindAllStatic("dni=" + doc.ToString(),null);
            if (list != null && list.Count>0)
            return true;
            return false;
        }
    }
}
