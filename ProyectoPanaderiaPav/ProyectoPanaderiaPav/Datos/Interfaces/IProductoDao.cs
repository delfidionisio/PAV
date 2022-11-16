using ProyectoPanaderiaPav.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Datos.Interfaces
{
    internal interface IProductoDao
    {
        List<Producto> RecuperarFiltrados(string nombreProducto, string tipoProducto, string precioHasta, string puntosHasta, string ordenarPor);
        int recuperarProducto(string nombreProducto);
        int InsertarProducto(Producto producto);
        int ModificarProducto(Producto producto);
        int EliminarProducto(Producto producto);
        List<Producto> RecuperarTodos();
        DataTable RecuperarDatosReportes(DateTime fechaDesde, DateTime fechaHasta, string tipoProducto);
    }
}
