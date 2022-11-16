using ProyectoPanaderiaPav.Datos.Daos;
using ProyectoPanaderiaPav.Datos.Interfaces;
using ProyectoPanaderiaPav.Entidades;
using ProyectoPanaderiaPav.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Servicios.Implementaciones
{
    internal class ProductoService : IProductoService
    {
        private IProductoDao daoProducto;
        public ProductoService()
        {
            daoProducto = new ProductoDao();
        }

        public List<Producto> traerFiltrados(string nombreProducto, string tipoProducto, string precioHasta, string puntosHasta, string ordenarPor)
        {
            return daoProducto.RecuperarFiltrados(nombreProducto, tipoProducto, precioHasta, puntosHasta, ordenarPor);
        }

        public int existeProducto(string nombreProducto)
        {
            return daoProducto.recuperarProducto(nombreProducto);
        }

        public int crearProducto(Producto producto)
        {
            return daoProducto.InsertarProducto(producto);
        }

        public int modificarProducto(Producto producto)
        {
            return daoProducto.ModificarProducto(producto);
        }

        public int eliminarProducto(Producto producto)
        {
            return daoProducto.EliminarProducto(producto);
        }

        public List<Producto> traerTodos()
        {
            return daoProducto.RecuperarTodos();
        }

        public DataTable traerDatosReporte(DateTime fechaDesde, DateTime fechaHasta, string tipoProducto)
        {
            return daoProducto.RecuperarDatosReportes(fechaDesde, fechaHasta, tipoProducto);
        }
    }
}
