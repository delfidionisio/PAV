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
    internal class UnidadMedidaDao : IUnidadMedidaDao
    {
        public List<UnidadMedida> RecuperarTodos()
        {
            List<UnidadMedida> lista = new List<UnidadMedida>();
            string consulta = "SELECT * FROM UnidadMedida WHERE borrado = 0 order by 2";
            DataTable tabla = DBHelper.obtenerInstancia().consultar(consulta);

            foreach (DataRow fila in tabla.Rows)
            {
                UnidadMedida unidadMedida = new UnidadMedida();
                unidadMedida.IdUnidadMedida = (int)fila["idUnidadMedida"];
                unidadMedida.Nombre = fila["nombre"].ToString();

                lista.Add(unidadMedida);
            }

            return lista;
        }
    }
}
