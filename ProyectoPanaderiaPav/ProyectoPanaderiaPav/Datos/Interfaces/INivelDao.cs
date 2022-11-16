using ProyectoPanaderiaPav.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Datos.Interfaces
{
    internal interface INivelDao
    {
        List<Nivel> RecuperarTodos();
        List<Nivel> RecuperarFiltrados(string nombreNivel, string idNivel);
        int recuperarNivel(string nombreNivel);
        int InsertarNivel(Nivel nivel);
        int ModificarNivel(Nivel nivel);
        int EliminarNivel(Nivel nivel);
    }
}
