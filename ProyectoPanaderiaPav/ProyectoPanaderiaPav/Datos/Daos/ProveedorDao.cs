using ProyectoPanaderiaPav.Datos.Interfaces;
using ProyectoPanaderiaPav.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Datos.Daos
{
    internal class ProveedorDao : IProveedorDao
    {
        public int EliminarProveedor(Proveedor proveedor)
        {
            string delete = "UPDATE Proveedores SET borrado = 1 WHERE idProveedor = '" + proveedor.IdProveedor + "'";
            return DBHelper.obtenerInstancia().actualizar(delete);
        }

        public int InsertarProveedor(Proveedor proveedor)
        {
            string insert = "INSERT INTO Proveedores (nombre, idMateriaPrima, mail, telefono, borrado)" +
                            " VALUES (" +
                            "'" + proveedor.Nombre + "'" + ", " +
                            + proveedor.MateriaPrima.IdMateriaPrima + ", " +
                            "'" + proveedor.Mail + "' , '"
                            + proveedor.Telefono + "' , " +
                            "'0')";

            return DBHelper.obtenerInstancia().actualizar(insert);
        }

        public int ModificarProveedor(Proveedor proveedor)
        {
            string update = "UPDATE Proveedores " +
                "SET nombre = '" + proveedor.Nombre + "'" + "," +
                             " idMateriaPrima = " + proveedor.MateriaPrima.IdMateriaPrima + "," +
                             " mail = " + "'" + proveedor.Mail + "'" + "," +
                             " telefono = '" + proveedor.Telefono + "' ," +
                             " borrado = 0" +
                             " WHERE idProveedor = " + proveedor.IdProveedor;

            return DBHelper.obtenerInstancia().actualizar(update);
        }

        public List<Proveedor> RecuperarFiltrados(string nombreProveedor, string materiaPrima)
        {
            List<Proveedor> lista = new List<Proveedor>();

            string consulta = "SELECT p.idProveedor, p.nombre, m.nombre as nombreMat, p.mail, p.telefono " +
                             "FROM Proveedores p JOIN MateriaPrima m ON (p.idMateriaPrima = m.idMateriaPrima) " +
                             "WHERE p.borrado = 0 AND m.borrado = 0";
            if (nombreProveedor != "")
            {
                consulta += " AND p.nombre LIKE '%" + nombreProveedor + "%'";
            }
            if (materiaPrima != "")
            {
                consulta += " AND m.idMateriaPrima = " + materiaPrima;
            }

            DataTable tablaProveedores = DBHelper.obtenerInstancia().consultar(consulta);

            foreach (DataRow fila in tablaProveedores.Rows)
            {
                Proveedor proveedor = new Proveedor
                {
                    IdProveedor = (int)fila["idProveedor"],
                    Nombre = fila["nombre"].ToString(),
                    MateriaPrima = new MateriaPrima()
                    {
                        Nombre = fila["nombreMat"].ToString(),
                    },
                    Mail = fila["mail"].ToString(),
                    Telefono = fila["telefono"].ToString(),
                };
                lista.Add(proveedor);
            }
            return lista;
        }

        public int RecuperarProveedor(string nombreProveedor)
        {
            string consulta = "SELECT * FROM Proveedores WHERE nombre = '" +
                               nombreProveedor + "' AND borrado = 0";

            DataTable tabla = DBHelper.obtenerInstancia().consultar(consulta);
            if (tabla.Rows.Count > 0)
                return (int)tabla.Rows[0][0];
            else
                return 0;
        }

        public List<Proveedor> RecuperarTodos()
        {
            List<Proveedor> lista = new List<Proveedor>();
            //string consulta = "SELECT * FROM Perfiles WHERE borrado = 0 order by 2";
            //DataTable tabla = DBHelper.obtenerInstancia().consultar(consulta);

            //foreach (DataRow fila in tabla.Rows)
            //{
            //    Perfil perfil = new Perfil();
            //    perfil.IdPerfil = (int)fila["idPerfil"];
            //    perfil.Nombre = fila["nombre"].ToString();
            //    perfil.Borrado = (int)fila["borrado"];

            //    lista.Add(perfil);
            //}

            return lista;
        }
    }
}
