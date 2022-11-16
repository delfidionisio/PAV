using ProyectoPanaderiaPav.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Servicios.Interfaces
{
    internal interface IMateriaPrimaService
    {
        List<MateriaPrima> traerTodos();

        int existeMateriaPrima(string nombreMateriaPrima);

        int crearMateriaPrima(MateriaPrima materiaPrima);

        int modificarMateriaPrima(MateriaPrima materiaPrima);

        int eliminarMateriaPrima(MateriaPrima materiaPrima);

        List<MateriaPrima> traerFiltrados(string nombreMateriaPrima, string idMateriaPrima);
    }
    
}
