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
    internal class ProductoDao : IProductoDao
    {
        public int EliminarProducto(Producto producto)
        {
            string delete = "UPDATE Productos SET borrado = 1 WHERE idProducto = '" + producto.IdProducto + "'";
            return DBHelper.obtenerInstancia().actualizar(delete);
        }

        public int InsertarProducto(Producto producto)
        {
            string insert = "INSERT INTO Productos (nombre, tipoProducto, precio, puntos, borrado, idUnidadMedida)" +
                            " VALUES (" +
                            "'" + producto.Nombre + "'" + ", " +
                            "'" + producto.Tipo.IdTipo + "', " +
                            "'" + producto.Precio + "' , " +
                            "'" + producto.Puntos + "' , " +
                            "'0' , " +
                            "'" + producto.PrecioUnidad.IdUnidadMedida + "' )";

            return DBHelper.obtenerInstancia().actualizar(insert);
        }

        public int ModificarProducto(Producto producto)
        {
            string update = "UPDATE Productos " +
                "SET nombre = '" + producto.Nombre + "'" + "," +
                             " tipoProducto = " + "'" + producto.Tipo.IdTipo + "'" + "," +
                             " precio = " + "'" + producto.Precio + "'" + "," +
                             " puntos = " + "'" + producto.Puntos + "'" + "," +
                             " borrado = 0," +
                             " idUnidadMedida = " + producto.PrecioUnidad.IdUnidadMedida +
                             " WHERE idProducto = " + producto.IdProducto;

            return DBHelper.obtenerInstancia().actualizar(update);
        }

        public List<Producto> RecuperarFiltrados(string nombreProducto, string tipoProducto, string precioHasta, string puntosHasta, string ordenarPor)
        {
            List<Producto> lista = new List<Producto>();

            string consulta = "SELECT p.idProducto, p.nombre, t.nombre as nombreTipo, p.precio, p.puntos, u.nombre as nombreUnidad " +
                              "FROM Productos p JOIN TipoProducto t ON (p.tipoProducto = t.idTipo)" +
                              "JOIN UnidadMedida u ON (p.idUnidadMedida = u.idUnidadMedida) " +
                              "WHERE p.borrado = 0 AND t.borrado = 0";
            if (nombreProducto != "")
            {
                consulta += " AND p.nombre LIKE '%" + nombreProducto + "%'";
            }
            if (tipoProducto != "")
            {
                consulta += " AND p.tipoProducto = " + tipoProducto;
            }
            if (precioHasta != "")
            {
                consulta += " AND p.precio <= " + precioHasta;
            }
            if (puntosHasta != "")
            {
                consulta += " AND p.puntos <= " + puntosHasta;
            }
            if (ordenarPor != "-1")
            {
                switch (ordenarPor)
                {
                    case "0":
                        {
                            consulta += " ORDER BY p.nombre";
                            break;
                        }
                    case "1":
                        {
                            consulta += " ORDER BY p.nombre DESC";
                            break;
                        }
                    case "2":
                        {
                            consulta += " ORDER BY p.precio";
                            break;
                        }
                    case "3":
                        {
                            consulta += " ORDER BY p.precio DESC";
                            break;
                        }
                }
            }

            DataTable tablaProductos = DBHelper.obtenerInstancia().consultar(consulta);

            foreach (DataRow fila in tablaProductos.Rows)
            {
                Producto producto = new Producto
                {
                    IdProducto = (int)fila["idProducto"],
                    Nombre = fila["nombre"].ToString(),
                    Tipo = new TipoProducto()
                    {
                        Nombre = fila["nombreTipo"].ToString(),
                    },
                    Precio = (int)fila["precio"],
                    PrecioUnidad = new UnidadMedida()
                    {
                        Nombre = fila["nombreUnidad"].ToString(),
                    },
                    Puntos = (int)fila["puntos"],
                };
                lista.Add(producto);
            }
            return lista;
        }

        public List<Producto> RecuperarTodos()
        {
            List<Producto> lista = new List<Producto>();
            string consulta = "SELECT p.idProducto, p.nombre, t.nombre as nombreTipo, p.precio, p.puntos, u.nombre as nombreUnidad, u.idUnidadMedida " +
                              "FROM Productos p JOIN TipoProducto t ON (p.tipoProducto = t.idTipo)" +
                              "JOIN UnidadMedida u ON (p.idUnidadMedida = u.idUnidadMedida) " +
                              "WHERE p.borrado = 0 AND t.borrado = 0";

            DataTable tablaProductos = DBHelper.obtenerInstancia().consultar(consulta);

            foreach (DataRow fila in tablaProductos.Rows)
            {
                Producto producto = new Producto
                {
                    IdProducto = (int)fila["idProducto"],
                    Nombre = fila["nombre"].ToString(),
                    Tipo = new TipoProducto()
                    {
                        Nombre = fila["nombreTipo"].ToString(),
                    },
                    Precio = (int)fila["precio"],
                    PrecioUnidad = new UnidadMedida()
                    {
                        IdUnidadMedida = (int)fila["idUnidadMedida"],
                        Nombre = fila["nombreUnidad"].ToString()
                    },
                    Puntos = (int)fila["puntos"],
                };
                lista.Add(producto);
            }
            return lista;
        }

        public int recuperarProducto(string nombreProducto)
        {
            string consulta = "SELECT * FROM Productos WHERE nombre = '" +
                               nombreProducto + "' AND borrado = 0";

            DataTable tabla = DBHelper.obtenerInstancia().consultar(consulta);
            if (tabla.Rows.Count > 0)
                return (int)tabla.Rows[0][0];
            else
                return 0;
        }

        public DataTable RecuperarDatosReportes(DateTime fechaDesde, DateTime fechaHasta, string tipoProducto)
        {
            string consultaSQL = "SELECT p.nombre, tp.nombre as tipoProd,p.precio, uM.nombre as precioPor , SUM(dv.cantidad) as cantidad" +
                                    " FROM Productos p JOIN TipoProducto tp ON (p.tipoProducto = tp.idTipo)" +
                                    " JOIN UnidadMedida uM ON (p.idUnidadMedida = uM.idUnidadMedida)" +
                                    " JOIN DetalleVenta dv ON (dv.idProducto = p.idProducto)" +
                                    " JOIN Ventas v ON (v.nroVenta = dv.nroVenta)" +
                                    " WHERE v.fecha BETWEEN '" + fechaDesde.ToString("yyyy/MM/dd") + "' AND '" + fechaHasta.ToString("yyyy/MM/dd") + "' ";

            if (tipoProducto != "")
                consultaSQL += "AND tp.idTipo = '" + tipoProducto + "' ";


            consultaSQL += "GROUP BY p.nombre, tp.nombre, p.precio, uM.nombre ORDER BY SUM(dv.cantidad) desc";
            return DBHelper.obtenerInstancia().consultar(consultaSQL);
        }
    }
}
