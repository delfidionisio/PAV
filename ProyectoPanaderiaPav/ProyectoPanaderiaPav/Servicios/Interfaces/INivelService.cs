using ProyectoPanaderiaPav.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Servicios.Interfaces
{
    internal interface INivelService
    {
        List<Nivel> traerTodos();
        List<Nivel> traerFiltrados(string nombreNivel, string idNivel);
        int existeNivel(string nombreNivel);
        int crearNivel(Nivel nivel);
        int modificarNivel(Nivel nivel);
        int eliminarNivel(Nivel nivel);
        
    }
}
