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
    internal class TipoProductoService : ITipoProductoService
    {
        private ITipoProductoDao daoTipoProducto;
        public TipoProductoService()
        {
            daoTipoProducto = new TipoProductoDao();
        }
        public List<TipoProducto> traerTodos()
        {
            return daoTipoProducto.RecuperarTodos();
        }
    }
}
