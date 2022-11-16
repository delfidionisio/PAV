using ProyectoPanaderiaPav.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Datos.Interfaces
{
    internal interface IVentaDao
    {
        int InsertarVenta(Venta venta);
        DataTable RecuperarDatosReporteDescuentos(string fechaDesde, string fechaHasta);
        DataTable RecuperarDatosReporteVenta(string fechaDesde, string fechaHasta, int idEmpleado);
        int RecuperarProximoNumero();
    }
}
