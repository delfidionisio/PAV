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
    internal class MateriaPrimaService : IMateriaPrimaService
    {
        private IMateriaPrimaDao daoMateriaPrima;
        public MateriaPrimaService()
        {
            daoMateriaPrima = new MateriaPrimaDao();
        }
        public List<MateriaPrima> traerTodos()
        {
            return daoMateriaPrima.RecuperarTodos();
        }
        public int crearMateriaPrima(MateriaPrima materiaPrima)
        {
            return daoMateriaPrima.InsertarMateriaPrima(materiaPrima);
        }

        public int modificarMateriaPrima(MateriaPrima materiaPrima)
        {
            return daoMateriaPrima.ModificarMateriaPrima(materiaPrima);
        }

        public int eliminarMateriaPrima(MateriaPrima materiaPrima)
        {
            return daoMateriaPrima.EliminarMateriaPrima(materiaPrima);
        }

        public int existeMateriaPrima(string nombreMateriaPrima)
        {
            return daoMateriaPrima.recuperarMateriaPrima(nombreMateriaPrima);
        }

        List<MateriaPrima> IMateriaPrimaService.traerFiltrados(string nombreMateriaPrima, string idMateriaPrima)
        {
            return daoMateriaPrima.RecuperarFiltrados(nombreMateriaPrima, idMateriaPrima);
        }
    }
}
