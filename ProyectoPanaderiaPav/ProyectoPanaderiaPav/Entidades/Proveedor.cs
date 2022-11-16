using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Entidades
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public MateriaPrima MateriaPrima { get; set; } = new MateriaPrima();
        public string Mail { get; set; }
        public string Telefono { get; set; }
        public int Borrado { get; set; }
    }
}