using ProyectoPanaderiaPav.Datos.Daos;
using ProyectoPanaderiaPav.Datos.Interfaces;
using ProyectoPanaderiaPav.Entidades;
using ProyectoPanaderiaPav.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Servicios.Implementaciones
{
    internal class ProveedorService : IProveedorService
    {
        private IProveedorDao daoProveedor;

        public ProveedorService()
        {
            daoProveedor = new ProveedorDao();
        }

        public int crearProveedor(Proveedor proveedor)
        {
            return daoProveedor.InsertarProveedor(proveedor);
        }

        public int eliminarProveedor(Proveedor proveedor)
        {
            return daoProveedor.EliminarProveedor(proveedor);
        }

        public int existeProveedor(string nombreProveedor)
        {
            return daoProveedor.RecuperarProveedor(nombreProveedor);
        }

        public int modificarProveedor(Proveedor proveedor)
        {
            return daoProveedor.ModificarProveedor(proveedor);
        }

        public List<Proveedor> traerFiltrados(string nombreProveedor, string materiaPrima)
        {
            return daoProveedor.RecuperarFiltrados(nombreProveedor, materiaPrima);
        }

        public List<Proveedor> traerTodos()
        {
            return daoProveedor.RecuperarTodos();
        }
    }
}
