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

namespace ProyectoPanaderiaPav.Servicios
{
    internal class PerfilService : IPerfilService
    {
        private IPerfilDao daoPerfil;
        public PerfilService()
        {
            daoPerfil = new PerfilDao();
        }
        public List<Perfil> traerTodos()
        {
            return daoPerfil.RecuperarTodos();
        }
    }
}
