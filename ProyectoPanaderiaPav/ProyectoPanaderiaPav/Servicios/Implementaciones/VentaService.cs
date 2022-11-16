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
    internal class VentaService : IVentaService
    {
        private IVentaDao daoVenta;
        public VentaService()
        {
            daoVenta = new VentaDao();
        }

        public int crearVenta(Venta venta)
        {
            return daoVenta.InsertarVenta(venta);
        }

        public DataTable traerDatosReporteDescuentos(string fechaDesde, string fechaHasta)
        {
            return daoVenta.RecuperarDatosReporteDescuentos(fechaDesde, fechaHasta);
        }

        public DataTable traerDatosReporteVentas(string fechaDesde, string fechaHasta, int idEmpleado)
        {
            return daoVenta.RecuperarDatosReporteVenta(fechaDesde, fechaHasta, idEmpleado);
        }

        public int traerProximoNumero()
        {
            return daoVenta.RecuperarProximoNumero();
        }
    }
}
