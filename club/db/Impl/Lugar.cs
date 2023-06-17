using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clubApp.db.orm;

namespace clubApp.db
{
    public partial class Lugar : BaseClass, IAccessDB<Lugar>
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionLugarGuardar;
        public List<Lugar> FindAll()
        {
            return this.FindAll(null);
        }
        public List<Lugar> FindAll(string criterio)
        {
            return ORMDB<Lugar>.FindAll(criterio);
        }
        public Lugar FindbyKey(params object[] key)
        {
            var lugar = ORMDB<Lugar>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Codigo = lugar.Codigo;
            this.Descripcion = lugar.Descripcion;
            
            this.SetIsObjFromDB();//marcar como que se recupero desde la base.
            return this;
        }
        public bool     SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionLugarGuardar != null)
                {
                    // Validaciones de los datos que deben estar cargados para tener una tupla de datos valida   
                }
            }
            return ORMDB<Lugar>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-TurnoConsulta
        public static List<Lugar> FindAllStatic(string criterio, Comparison<Lugar> compara)
        {
            var lista = ORMDB<Lugar>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }
    }
}
