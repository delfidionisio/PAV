using ProyectoPanaderiaPav.Datos.Daos;
using ProyectoPanaderiaPav.Datos.Interfaces;
using ProyectoPanaderiaPav.Entidades;
using ProyectoPanaderiaPav.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Servicios.Implementaciones
{
    internal class TipoDocumentoService : ITipoDocumentoService
    {
        private ITipoDocumentoDao daoTipoDocumento;
        public TipoDocumentoService()
        {
            daoTipoDocumento = new TipoDocumentoDao();
        }
        public List<TipoDocumento> traerTodos()
        {
            return daoTipoDocumento.RecuperarTodos();
        }
    }
}
