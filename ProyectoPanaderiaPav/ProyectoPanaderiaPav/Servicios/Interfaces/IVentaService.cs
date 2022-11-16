using ProyectoPanaderiaPav.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Servicios.Interfaces
{
    internal interface IVentaService
    {
        int crearVenta(Venta venta);
        DataTable traerDatosReporteDescuentos(string fechaDesde, string fechaHasta);
        DataTable traerDatosReporteVentas(string fechaDesde, string fechaHasta, int idEmpleado);
        int traerProximoNumero();
    }
}
