using ProyectoPanaderiaPav.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Datos.Interfaces
{
    internal interface IMateriaPrimaDao
    {
        List<MateriaPrima> RecuperarTodos();
        List<MateriaPrima> RecuperarFiltrados(string nombreMateriaPrima, string idMateriaPrima);
        int recuperarMateriaPrima(string nombreMateriaPrima);
        int InsertarMateriaPrima(MateriaPrima materiaPrima);
        int ModificarMateriaPrima(MateriaPrima materiaPrima);
        int EliminarMateriaPrima(MateriaPrima materiaPrima);
    }
}
