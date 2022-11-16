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
    internal class ClienteDao : IClienteDao
    {
        public List<Cliente> RecuperarTodos()
        {
            List<Cliente> lista = new List<Cliente>();
            string consulta = "SELECT * FROM Clientes JOIN TipoDocumento td ON (c.idTipoDocumento = td.idTipoDocumento)" +
                " WHERE c.borrado = 0 AND td.borrado = 0 order by 2";
            DataTable tabla = DBHelper.obtenerInstancia().consultar(consulta);

            foreach (DataRow fila in tabla.Rows)
            {
                Cliente cliente = new Cliente()
                {
                    IdCliente = (int)fila["idCliente"],
                    Nombre = fila["nombre"].ToString(),
                    Apellido = fila["apellido"].ToString(),
                    Mail = fila["mail"].ToString(),
                    Puntos = (int)fila["puntos"],
                    NroDocumento = fila["nroDocumento"].ToString(),
                    TipoDocumento = new TipoDocumento()
                    {
                        Nombre = fila["nombre"].ToString(),
                    },
                    Borrado = (int)fila["borrado"],
                };
                lista.Add(cliente);
            }
            return lista;
        }

        public List<Cliente> RecuperarFiltrados(string nombreCliente, string apellidoCliente, string numeroDocumento)
        {
            List<Cliente> lista = new List<Cliente>();

            string consulta = "SELECT c.idCliente, c.nombre, c.apellido, c.mail, c.puntos, " +
                "c.nroDocumento, td.nombre as nombreTipoDoc " +
                "FROM Clientes c JOIN TipoDocumento td ON (c.idTipoDocumento = td.idTipoDocumento) " +
                "WHERE c.borrado = 0 AND td.borrado = 0";

            if (nombreCliente != "")
            {
                consulta += " AND c.nombre LIKE '%" + nombreCliente + "%'";
            }

            if (apellidoCliente != "")
            {
                consulta += " AND c.apellido LIKE '%" + apellidoCliente + "%'";
            }

            if (numeroDocumento != "")
            {
                consulta += " AND c.nroDocumento LIKE '%" + numeroDocumento + "%'";
            }

            DataTable tablaClientes = DBHelper.obtenerInstancia().consultar(consulta);

            foreach (DataRow fila in tablaClientes.Rows)
            {
                Cliente cliente = new Cliente
                {
                    IdCliente = (int)fila["idCliente"],
                    Nombre = fila["nombre"].ToString(),
                    Apellido = fila["apellido"].ToString(),
                    Mail = fila["mail"].ToString(),
                    Puntos = (int)fila["puntos"],
                    TipoDocumento = new TipoDocumento()
                    {
                        Nombre = fila["nombreTipoDoc"].ToString(),
                    },
                    NroDocumento = fila["nroDocumento"].ToString(),
                };
                lista.Add(cliente);
            }
            return lista;
        }

        public int EliminarCliente(Cliente cliente)
        {
            string delete = "UPDATE Clientes SET borrado = 1 WHERE idCliente = '" + cliente.IdCliente + "'";
            return DBHelper.obtenerInstancia().actualizar(delete);
        }

        public int InsertarCliente(Cliente cliente)
        {
            string insert = "INSERT INTO Clientes (nombre, apellido, mail, nroDocumento, idTipoDocumento, puntos, borrado)" +
                            " VALUES (" +
                            "'" + cliente.Nombre + "'" + ", " +
                            "'" + cliente.Apellido + "', " +
                            "'" + cliente.Mail + "', " +
                            "'" + cliente.NroDocumento + "'," +
                            cliente.TipoDocumento.IdTipoDocumento + ", " +
                            cliente.Puntos + ", 0)";

            return DBHelper.obtenerInstancia().actualizar(insert); ;
        }

        public int ModificarCliente(Cliente cliente)
        {
            string update = "UPDATE Clientes " +
                            "SET nombre = '" + cliente.Nombre + "'" + "," +
                            " apellido = " + "'" + cliente.Apellido + "'" + "," +
                            " mail = '" + cliente.Mail + "' ," +
                            " nroDocumento = '" + cliente.NroDocumento + "' ," +
                            " idTipoDocumento = " + "'" + cliente.TipoDocumento.IdTipoDocumento + "' ," +
                            " puntos = " + "'" + cliente.Puntos + "'" + "," +
                            " borrado = 0" +
                            " WHERE idCliente = " + cliente.IdCliente;

            return DBHelper.obtenerInstancia().actualizar(update);
        }

        public int recuperarCliente(string nombreCliente)
        {
            string consulta = "SELECT * FROM Clientes WHERE nombre = '" +
                               nombreCliente + "' AND borrado = 0";

            DataTable tabla = DBHelper.obtenerInstancia().consultar(consulta);
            if (tabla.Rows.Count > 0)
                return (int)tabla.Rows[0][0];
            else
                return 0;
        }

        public Cliente RecuperarClienteDni(string dni)
        {
            string consulta = "SELECT idCliente , nombre, apellido, mail, puntos, nroDocumento FROM Clientes WHERE nroDocumento = " + dni;

            DataTable tabla = DBHelper.obtenerInstancia().consultar(consulta);
            foreach (DataRow fila in tabla.Rows)
            {
                Cliente cliente = new Cliente
                {
                    IdCliente = (int)fila["idCliente"],
                    Nombre = fila["nombre"].ToString(),
                    Apellido = fila["apellido"].ToString(),
                    Mail = fila["mail"].ToString(),
                    Puntos = (int)fila["puntos"],
                    NroDocumento = fila["nroDocumento"].ToString(),
                };

                return cliente;
            }
            return null;
                
        }

        public DataTable RecuperarDatosReporteClientes()
        {
            return null;
        }
    }
}
