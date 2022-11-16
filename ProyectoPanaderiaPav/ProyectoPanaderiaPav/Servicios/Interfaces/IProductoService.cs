using ProyectoPanaderiaPav.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Servicios.Interfaces
{
    internal interface IProductoService
    {
        List<Producto> traerFiltrados(string nombreProducto, string tipoProducto, string precioHasta, string puntosHasta, string ordenarPor);

        int existeProducto(string nombreProducto);

        int crearProducto(Producto producto);

        int modificarProducto(Producto producto);

        int eliminarProducto(Producto producto);
        List<Producto> traerTodos();
        DataTable traerDatosReporte(DateTime fechaDesde, DateTime fechaHasta, string tipoProducto);
    }
}
