using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clubApp.db.orm;

namespace clubApp.db
{
    public partial class Socio : BaseClass, IAccessDB<Socio>
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionSocioGuardar;
        public List<Socio> FindAll()
        {
            return this.FindAll(null);
        }
        public List<Socio> FindAll(string criterio)
        {
            return ORMDB<Socio>.FindAll(criterio);
        }
        public Socio FindbyKey(params object[] key)
        {
            var soc = ORMDB<Socio>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.NroSocio = soc.NroSocio;    
            this.NroDocumento = soc.NroDocumento;
            this.Apellido = soc.Apellido;
            this.Nombres = soc.Nombres;
            this.Domicilio = soc.Domicilio;
            this.Telefono = soc.Telefono;
            this.CodPostal = soc.CodPostal;
            this.Observaciones = soc.Observaciones;
            this.Activo = soc.Activo;
            this.Moroso = soc.Moroso;
            this.SetIsObjFromDB();// marcar la lectura desde la Base de datos.
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionSocioGuardar != null)
                {
                    // Validaciones de los datos que deben estar cargados para tener una tupla de datos valida
                    if (NroDocumento == 0)
                        ValidacionSocioGuardar("No se puede poner Dni cero");
                }
            }
            return ORMDB<Socio>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-Socio
        public static List<Socio> FindAllStatic(string criterio, Comparison<Socio> compara)
        {
            var lista = ORMDB<Socio>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }
    }
}
