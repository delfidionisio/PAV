using ProyectoPanaderiaPav.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Datos.Interfaces
{
    internal interface IProveedorDao
    {
        int EliminarProveedor(Proveedor proveedor);
        int InsertarProveedor(Proveedor proveedor);
        int ModificarProveedor(Proveedor proveedor);
        List<Proveedor> RecuperarFiltrados(string nombreProveedor, string materiaPrima);
        int RecuperarProveedor(string nombreProveedor);
        List<Proveedor> RecuperarTodos();
    }
}
