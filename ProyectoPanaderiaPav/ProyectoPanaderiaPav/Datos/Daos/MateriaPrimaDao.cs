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
    internal class MateriaPrimaDao : IMateriaPrimaDao
    {
        public List<MateriaPrima> RecuperarTodos()
        {
            List<MateriaPrima> lista = new List<MateriaPrima>();
            string consulta = "SELECT mp.idMateriaPrima, mp.nombre, mp.stock, u.nombre as nombreUnidad " +
                              "FROM MateriaPrima mp JOIN UnidadMedida u ON (mp.idUnidadMedida = u.idUnidadMedida) " +
                              "WHERE mp.borrado = 0 AND u.borrado = 0 order by 2";
            DataTable tabla = DBHelper.obtenerInstancia().consultar(consulta);

            foreach (DataRow fila in tabla.Rows)
            {
                MateriaPrima materiaPrima = new MateriaPrima
                {
                    IdMateriaPrima = (int)fila["idMateriaPrima"],
                    Nombre = fila["nombre"].ToString(),
                    Stock = (int)fila["stock"],
                    NombreUnidadMedida = new UnidadMedida()
                    {
                        Nombre = fila["nombreUnidad"].ToString(),
                    },
                };
            lista.Add(materiaPrima);
            }
            return lista;

        }

        public int recuperarMateriaPrima(string nombreMateriaPrima)
        {
            string consulta = "SELECT * FROM MateriaPrima WHERE nombre = '" +
                               nombreMateriaPrima + "' AND borrado = 0";

            DataTable tabla = DBHelper.obtenerInstancia().consultar(consulta);
            if (tabla.Rows.Count > 0)
                return (int)tabla.Rows[0][0];
            else
                return 0;
        }

        public int ModificarMateriaPrima(MateriaPrima materiaPrima)
        {
            string update = "UPDATE MateriaPrima " +
                "SET nombre = '" + materiaPrima.Nombre + "'" + "," +
                             " stock = " + materiaPrima.Stock + "," +
                             " idUnidadMedida = " + materiaPrima.NombreUnidadMedida.IdUnidadMedida + "," +                             
                             " borrado = 0" +
                             " WHERE idMateriaPrima = " + materiaPrima.IdMateriaPrima;

            return DBHelper.obtenerInstancia().actualizar(update);
        }

        public int EliminarMateriaPrima(MateriaPrima materiaPrima)
        {
            string delete = "UPDATE MateriaPrima SET borrado = 1 WHERE idMateriaPrima = '" + materiaPrima.IdMateriaPrima + "'";
            return DBHelper.obtenerInstancia().actualizar(delete);
        }

        public int InsertarMateriaPrima(MateriaPrima materiaPrima)
        {
            string insert = "INSERT INTO MateriaPrima (nombre, stock, idUnidadMedida, borrado)" +
                            " VALUES (" +
                            "'" + materiaPrima.Nombre + "'" + ", " +
                             + materiaPrima.Stock + ", '" 
                             + materiaPrima.NombreUnidadMedida.IdUnidadMedida + "' , " +
                            "'0')";

            return DBHelper.obtenerInstancia().actualizar(insert); ;
        }

        public List<MateriaPrima> RecuperarFiltrados(string nombreMateriaPrima, string idMateriaPrima)
        {
            List<MateriaPrima> lista = new List<MateriaPrima>();

            string consulta = "SELECT mp.idMateriaPrima, mp.nombre, mp.stock, u.nombre AS nombreUnidad " +
                              "FROM MateriaPrima mp JOIN UnidadMedida u ON (mp.idUnidadMedida = u.idUnidadMedida)" +
                              "WHERE mp.borrado = 0 AND u.borrado = 0";

            if (nombreMateriaPrima != "")
            {
                consulta += " AND mp.nombre LIKE '%" + nombreMateriaPrima + "%'";
            }
            if (idMateriaPrima != "")
            {
                consulta += " AND mp.idMateriaPrima = " + idMateriaPrima;
            }

            DataTable tablaMateriaPrima = DBHelper.obtenerInstancia().consultar(consulta);

            foreach (DataRow fila in tablaMateriaPrima.Rows)
            {
                MateriaPrima materiaPrima = new MateriaPrima
                {
                    IdMateriaPrima = (int)fila["idMateriaPrima"],
                    Nombre = fila["nombre"].ToString(),
                    NombreUnidadMedida = new UnidadMedida()
                    {
                        Nombre = fila["nombreUnidad"].ToString(),
                    },
                    Stock = (int)fila["stock"]
                };
                lista.Add(materiaPrima);
            }
            return lista;
        }
    }
}
