using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Entidades
{
    public class Nivel
    {
        public int IdNivel { get; set; }
        public string Nombre { get; set; }
        public int PuntosDesde { get; set; }
        public int PuntosHasta { get; set; }
        public int Descuento { get; set; }
        public int Borrado { get; set; }
    }
}
