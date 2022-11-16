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
    internal class TipoDocumentoDao : ITipoDocumentoDao
    {
        public List<TipoDocumento> RecuperarTodos()
        {
            List<TipoDocumento> lista = new List<TipoDocumento>();
            string consulta = "SELECT * FROM TipoDocumento WHERE borrado = 0 order by 2";
            DataTable tabla = DBHelper.obtenerInstancia().consultar(consulta);

            foreach (DataRow fila in tabla.Rows)
            {
                TipoDocumento tipoDocumento = new TipoDocumento();
                tipoDocumento.IdTipoDocumento = (int)fila["idTipoDocumento"];
                tipoDocumento.Nombre = fila["nombre"].ToString();
                //tipoDocumento.Borrado = (int)fila["borrado"];

                lista.Add(tipoDocumento);
            }

            return lista;
        }
    }
}
