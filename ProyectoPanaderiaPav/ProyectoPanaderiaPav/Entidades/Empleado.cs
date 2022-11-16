using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Entidades
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Mail { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set;  }
        public Perfil Perfil { get; set; } = new Perfil();
        public TipoDocumento TipoDocumento { get; set; } = new TipoDocumento();
        public string NroDocumento { get; set; }
        public int Borrado { get; set; }
        public string NombreCompleto => $"{Apellido} {Nombre}";
    }
}