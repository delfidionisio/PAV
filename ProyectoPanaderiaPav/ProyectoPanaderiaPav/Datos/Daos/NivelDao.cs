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
    internal class NivelDao : INivelDao
    {
        public List<Nivel> RecuperarTodos()
        {
            List<Nivel> lista = new List<Nivel>();
            string consulta = "SELECT * FROM Niveles WHERE borrado = 0 order by 2 ";
            DataTable tabla = DBHelper.obtenerInstancia().consultar(consulta);

            foreach (DataRow fila in tabla.Rows)
            {
                Nivel nivel = new Nivel();
                nivel.IdNivel = (int)fila["idNivel"];
                nivel.Nombre = fila["nombre"].ToString();
                nivel.PuntosDesde = (int)fila["puntosDesde"];
                nivel.PuntosHasta = (int)fila["puntosHasta"];
                nivel.Descuento = (int)fila["descuento"];

                lista.Add(nivel);
            }

            return lista;
        }

        public int recuperarNivel(string nombreNivel)
        {
            string consulta = "SELECT * FROM Niveles WHERE nombre = '" +
                               nombreNivel + "' AND borrado = 0";

            DataTable tabla = DBHelper.obtenerInstancia().consultar(consulta);
            if (tabla.Rows.Count > 0)
                return (int)tabla.Rows[0][0];
            else
                return 0;
        }

        public int ModificarNivel(Nivel nivel)
        {
            string update = "UPDATE Niveles " +
                "SET nombre = '" + nivel.Nombre + "'" + "," +
                             " puntosDesde = " + nivel.PuntosDesde + "," +
                             " puntosHasta = " + nivel.PuntosHasta + "," +
                             " descuento = " + nivel.Descuento + "," +
                             " borrado = 0" +
                             " WHERE idNivel = " + nivel.IdNivel;

            return DBHelper.obtenerInstancia().actualizar(update);
        }

        public List<Nivel> RecuperarFiltrados(string nombreNivel, string idNivel)
        {
            List<Nivel> lista = new List<Nivel>();

            string consulta = "SELECT n.idNivel, n.nombre, n.puntosDesde, n.puntosHasta, n.descuento " +
                              "FROM Niveles n WHERE n.borrado = 0 ";

            if (nombreNivel != "")
            {
                consulta += " AND n.nombre LIKE '%" + nombreNivel + "%'";
            }
            if (idNivel != "")
            {
                consulta += " AND n.idNivel = " + idNivel;
            }

            DataTable tablaNiveles = DBHelper.obtenerInstancia().consultar(consulta);

            foreach (DataRow fila in tablaNiveles.Rows)
            {
                Nivel nivel = new Nivel
                {
                    IdNivel = (int)fila["idNivel"],
                    Nombre = fila["nombre"].ToString(),
                    PuntosDesde = (int)fila["puntosDesde"],
                    PuntosHasta = (int)fila["puntosHasta"],
                    Descuento = (int)fila["descuento"]
                    
                };
                lista.Add(nivel);
            }
            return lista;
        }

        public int InsertarNivel(Nivel nivel)
        {
            string insert = "INSERT INTO Niveles (nombre, puntosDesde, puntosHasta, descuento, borrado)" +
                            " VALUES (" +
                            "'" + nivel.Nombre + "'" + ", " +
                             + nivel.PuntosDesde + ", '"
                             + nivel.PuntosHasta + "' , " +
                             + nivel.Descuento + "' , " +
                            "'0')";

            return DBHelper.obtenerInstancia().actualizar(insert); ;
        }

        public int EliminarNivel(Nivel nivel)
        {
            string delete = "UPDATE Niveles SET borrado = 1 WHERE idNivel = '" + nivel.IdNivel + "'";
            return DBHelper.obtenerInstancia().actualizar(delete);
        }







    }
}
