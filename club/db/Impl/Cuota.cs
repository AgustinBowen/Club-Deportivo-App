using clubApp.db.orm;
using System;
using System.Collections.Generic;

namespace clubApp.db
{
    public partial class Cuota : BaseClass, IAccessDB<Cuota>
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionCuotaGuardar;
        public List<Cuota> FindAll()
        {
            return this.FindAll(null);
        }
        public List<Cuota> FindAll(string criterio)
        {
            return ORMDB<Cuota>.FindAll(criterio);
        }
        public Cuota FindbyKey(params object[] key)
        {
            var cuota = ORMDB<Cuota>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Id = cuota.Id;
            this.CodActSocio = cuota.CodActSocio;
            this.Anio = cuota.Anio;
            this.Mes = cuota.Mes;
            this.Estado = cuota.Estado;
            this.Importe = cuota.Importe;
            this.FechaVenc = cuota.FechaVenc;
            this.FechaPago = cuota.FechaPago;
            this.SetIsObjFromDB();//marcar como que se recupero desde la base.
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionCuotaGuardar != null)
                {
                    // Validaciones de los datos que deben estar cargados para tener una tupla de datos valida
                }
            }
            return ORMDB<Cuota>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-Mascota
        public static List<Cuota> FindAllStatic(string criterio, Comparison<Cuota> compara)
        {
            var lista = ORMDB<Cuota>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }

        public override bool Equals(object obj)
        {
            return (this.CodActSocio == (obj as Cuota).CodActSocio) && ((this._mes + this.Anio) == ((obj as Cuota).Mes + (obj as Cuota).Anio));
        }

        public override string ToString()
        {
            Cuota cuota = new Cuota();
            cuota.FindbyKey(this.Id);
            return string.Format("{0} - {1} - {2} - {3} - {4} - {5} - {6} - {7}",
                                         cuota.Id, cuota.CodActSocio, cuota.Anio, cuota.Mes, cuota.Estado,
                                         cuota.Importe, cuota.FechaVenc.ToShortDateString(), cuota.FechaPago.ToShortDateString());
        }
    }
}
