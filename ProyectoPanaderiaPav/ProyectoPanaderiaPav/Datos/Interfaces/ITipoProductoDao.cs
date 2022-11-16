using ProyectoPanaderiaPav.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Datos.Interfaces
{
    internal interface ITipoProductoDao
    {
        List<TipoProducto> RecuperarTodos();
    }
}
