using ProyectoPanaderiaPav.Datos.Interfaces;
using ProyectoPanaderiaPav.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Datos.Daos
{
    internal class PerfilDao : IPerfilDao
    {

        public List<Perfil> RecuperarTodos()
        {
            List <Perfil> lista = new List<Perfil>();
            string consulta = "SELECT * FROM Perfiles WHERE borrado = 0 order by 2";
            DataTable tabla = DBHelper.obtenerInstancia().consultar(consulta);

            foreach (DataRow fila in tabla.Rows)
            {
                Perfil perfil = new Perfil();
                perfil.IdPerfil = (int)fila["idPerfil"];
                perfil.Nombre = fila["nombre"].ToString();
                perfil.Borrado = (int)fila["borrado"];

                lista.Add(perfil);
            }

            return lista;
        }
    }
}
