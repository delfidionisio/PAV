using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Entidades
{
    public class DetalleVenta
    {
        public int NroVenta { get; set; }
        public int NroDetalle { get; set; }
        public Producto Producto { get; set; }    
        public float Cantidad { get; set; }
        public int PrecioUnitario { get; set; }
        public float Subtotal { get; set; }
        public int Borrado { get; set; }

        public DetalleVenta(float cant,Producto producto)
        {
            Cantidad = cant;
            if (producto != null)
            {
                Producto = producto;
                PrecioUnitario = producto.Precio;
            }
            else
                PrecioUnitario=0;
            Subtotal = 0;
            float subtotal = PrecioUnitario * cant;
            Subtotal = subtotal;
        }
        
        


    }
}
