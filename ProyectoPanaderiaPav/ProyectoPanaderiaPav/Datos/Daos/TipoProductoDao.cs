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
    internal class TipoProductoDao : ITipoProductoDao
    {
        public List<TipoProducto> RecuperarTodos()
        {
            List<TipoProducto> lista = new List<TipoProducto>();
            string consulta = "SELECT * FROM TipoProducto WHERE borrado = 0 order by 2";
            DataTable tabla = DBHelper.obtenerInstancia().consultar(consulta);

            foreach (DataRow fila in tabla.Rows)
            {
                TipoProducto tipoProducto = new TipoProducto();
                tipoProducto.IdTipo = (int)fila["idTipo"];
                tipoProducto.Nombre = fila["nombre"].ToString();

                lista.Add(tipoProducto);
            }

            return lista;
        }
    }
}
