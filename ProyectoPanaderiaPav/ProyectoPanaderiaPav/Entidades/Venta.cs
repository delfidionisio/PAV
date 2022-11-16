using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Entidades
{
    public class Venta
    {
        public int NroVenta { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; } = new Cliente();
        public Empleado Empleado { get; set; } = new Empleado();
        public List<DetalleVenta> DetalleVentaLista { get; set; } = new List<DetalleVenta>();
        public float Total { get; set; }
        public float Descuento { get; set; } 
        public float Subtotal { get; set; }
        public int TotalPuntos { get; set; }
        public Nivel Nivel { get; set; } = new Nivel();

        public Venta()
        {
            Fecha = DateTime.Today;
            Total = 0;
            TotalPuntos = 0;
            Subtotal = 0;
        }

        public void AgregarDetalle(DetalleVenta detalle)
        {
            DetalleVentaLista.Add(detalle);
            Subtotal += detalle.Subtotal;
            
        }

        public void QuitarDetalle(DetalleVenta detalle)
        {
            DetalleVentaLista.Remove(detalle);
            Subtotal -= detalle.Subtotal;
        }

        public void calcularTotal()
        {
            Total = Subtotal - calcularDescuento();
        }

        public float calcularDescuento()
        {
            float desc = (Descuento / 100) * Subtotal;
            return desc;
        }

    }

    

}
