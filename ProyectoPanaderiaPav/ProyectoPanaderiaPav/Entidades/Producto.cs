using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Entidades
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public TipoProducto Tipo { get; set; } = new TipoProducto();
        public int Precio { get; set; }
        public UnidadMedida PrecioUnidad { get; set; } = new UnidadMedida();
        public int Puntos { get; set; }
        public int Borrado { get; set; }
    }
}
