using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Entidades
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Mail { get; set; }
        public int Puntos { get; set; }
        public string NroDocumento { get; set; }
        public TipoDocumento TipoDocumento { get; set; } = new TipoDocumento();
        public int Borrado { get; set; }
    }
}
