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
    internal class NivelService : INivelService
    {
        private INivelDao daoNivel;

        public NivelService()
        {
            daoNivel = new NivelDao();
        }

        public int crearNivel(Nivel nivel)
        {
            return daoNivel.InsertarNivel(nivel);
        }

        public int eliminarNivel(Nivel nivel)
        {
            return daoNivel.EliminarNivel(nivel);
        }

        public int existeNivel(string nombreNivel)
        {
            throw new NotImplementedException();
        }

        public int modificarNivel(Nivel nivel)
        {
            return daoNivel.ModificarNivel(nivel); 
        }

        public List<Nivel> traerFiltrados(string nombreNivel, string idNivel)
        {
            return daoNivel.RecuperarFiltrados(nombreNivel, idNivel);
        }

        public List<Nivel> traerTodos()
        {
            return daoNivel.RecuperarTodos();
        }
    }
}
