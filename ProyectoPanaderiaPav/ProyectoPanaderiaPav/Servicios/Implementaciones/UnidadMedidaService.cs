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
    internal class UnidadMedidaService : IUnidadMedidaService
    {
        private IUnidadMedidaDao daoUnidadMedida;

        public UnidadMedidaService()
        {
            daoUnidadMedida = new UnidadMedidaDao();
        }
        public List<UnidadMedida> traerTodos()
        {
            return daoUnidadMedida.RecuperarTodos();
        }
    }
}
