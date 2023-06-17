using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clubApp.db.orm;

namespace clubApp.db
{
    public partial class Horario : BaseClass, IAccessDB<Horario>
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionHorarioGuardar;
        public List<Horario> FindAll()
        {
            return this.FindAll(null);
        }
        public List<Horario> FindAll(string criterio)
        {
            return ORMDB<Horario>.FindAll(criterio);
        }
        public Horario FindbyKey(params object[] key)
        {
            var hor = ORMDB<Horario>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Id = hor.Id;
            this.Dia = hor.Dia;
            this.CodAct = hor.CodAct;
            this.HoraDesde = hor.HoraDesde;
            this.HoraHasta = hor.HoraHasta;
            this.CodLugar = hor.CodLugar;
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionHorarioGuardar != null)
                {
                    // Validaciones de los datos que deben estar cargados para tener una tupla de datos valida
                    if (Dia == 0)
                        ValidacionHorarioGuardar("No se puede poner Descripcion vacio");
                }
            }
            return ORMDB<Horario>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-Horario
        public static List<Horario> FindAllStatic(string criterio, Comparison<Horario> compara)
        {
            var lista = ORMDB<Horario>.FindAll(criterio);
            if(compara!=null)
                lista.Sort(compara);
            return lista;
        }

        public static Horario FindByKeyStatic(params object[] key)
        {
            return ORMDB<Horario>.FindbyKey(key);
        }
    }
}
