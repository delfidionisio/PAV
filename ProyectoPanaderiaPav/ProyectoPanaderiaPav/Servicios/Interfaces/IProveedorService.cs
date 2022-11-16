using ProyectoPanaderiaPav.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Servicios.Interfaces
{
    internal interface IProveedorService
    {
        int crearProveedor(Proveedor proveedor);
        int eliminarProveedor(Proveedor proveedor);
        int existeProveedor(string nombreProveedor);
        int modificarProveedor(Proveedor proveedor);
        List<Proveedor> traerFiltrados(string nombreProveedor, string materiaPrima);
        List<Proveedor> traerTodos();
    }
}
