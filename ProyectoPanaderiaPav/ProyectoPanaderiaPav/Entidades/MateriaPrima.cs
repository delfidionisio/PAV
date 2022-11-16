using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Entidades
{
    public class MateriaPrima
    {
        public int IdMateriaPrima { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public UnidadMedida NombreUnidadMedida { get; set; } = new UnidadMedida();
        public int Borrado { get; set; }
    }
}
