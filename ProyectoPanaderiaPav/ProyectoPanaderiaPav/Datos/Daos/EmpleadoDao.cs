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
    internal class EmpleadoDao : IEmpleadoDao
    {
        public List<Empleado> RecuperarTodos()
        {
            List<Empleado> lista = new List<Empleado>();
            string consulta = "SELECT * FROM Empleados e JOIN TipoDocumento td ON (e.idTipoDocumento = td.idTipoDocumento) " +
                "JOIN Perfiles p ON (e.idPerfil = p.idPerfil)" +
                "WHERE e.borrado = 0 AND td.borrado = 0 AND p.borrado = 0" +
                "order by 2";
            DataTable tabla = DBHelper.obtenerInstancia().consultar(consulta);

            foreach (DataRow fila in tabla.Rows)
            {
                Empleado empleado = new Empleado
                {
                    IdEmpleado = (int)fila["idEmpleado"],
                    Nombre = fila["nombre"].ToString(),
                    Apellido = fila["apellido"].ToString(),
                    Mail = fila["mail"].ToString(),
                    TipoDocumento = new TipoDocumento()
                    {
                        Nombre = fila["nombre"].ToString(),
                    },
                    NroDocumento = fila["nroDocumento"].ToString(),
                    Usuario = fila["usuario"].ToString(),
                    Clave = fila["clave"].ToString(),
                    Perfil = new Perfil()
                    {
                        Nombre = fila["nombre"].ToString(),
                    }
                };
            lista.Add(empleado);
            }
            return lista;
        }

        public int ModificarEmpleado(Empleado empleado)
        {
            string update = "UPDATE Empleados" +
                            " SET nombre = '" + empleado.Nombre + "'" + "," +
                            " apellido = " + "'" + empleado.Apellido + "'" + "," +
                            " mail = " + "'" + empleado.Mail + "'" + "," +
                            //" idUsuario = " + "'" + empleado.Usuario.IdUsuario + "'" + "," +
                            " borrado = 0," +
                            " idTipoDocumento = " + empleado.TipoDocumento.IdTipoDocumento + ", " + 
                            " nroDocumento = '" + empleado.NroDocumento + "', " +
                            " usuario = '" + empleado.Usuario + "'," + 
                            " clave = '" + empleado.Clave + "'," + 
                            " idPerfil = " + empleado.Perfil.IdPerfil + 
                            " WHERE idEmpleado = " + empleado.IdEmpleado;

            return DBHelper.obtenerInstancia().actualizar(update);
        }

        public int EliminarEmpleado(Empleado empleado)
        {
            string delete = "UPDATE Empleados SET borrado = 1 WHERE idEmpleado = '" + empleado.IdEmpleado+ "'";
            return DBHelper.obtenerInstancia().actualizar(delete);
        }

        public int InsertarEmpleado(Empleado empleado)
        {
            string idPerfil = "NULL";
            if (empleado.Perfil != null)
                idPerfil = empleado.Perfil.IdPerfil.ToString();


            string insert = "INSERT INTO Empleados (nombre, apellido, mail, nroDocumento, idTipoDocumento, usuario, clave, idPerfil, borrado)" +
                            " VALUES (" +
                            "'" + empleado.Nombre + "'" + ", " +
                            "'" + empleado.Apellido + "', " +
                            "'" + empleado.Mail + "' , " +
                            "'" + empleado.NroDocumento + "', " +
                            "'" + empleado.TipoDocumento.IdTipoDocumento + "'," +
                            "'" + empleado.Usuario + "', " +
                            "'" + empleado.Clave + "', " +
                                  idPerfil + ", " +
                            "'0' )";
            return DBHelper.obtenerInstancia().actualizar(insert); 
        }

        public List<Empleado> RecuperarFiltrados(string nombreEmpleado, string apellidoEmpleado, string numeroDocumento)
        {
            List<Empleado> lista = new List<Empleado>();

            string consulta = "SELECT e.idEmpleado, e.nombre, e.apellido, e.mail, e.nroDocumento, " +
                "td.nombre as nombreTipoDoc, e.usuario, e.clave, p.nombre as nombrePerfil " +
                "FROM Empleados e JOIN TipoDocumento td ON (e.idTipoDocumento = td.idTipoDocumento) " +
                "LEFT JOIN Perfiles p ON (p.idPerfil = e.idPerfil) " +
                "WHERE e.borrado = 0 AND td.borrado = 0"; //AND p.borrado = 0 // AND u.borrado = 0

            if (nombreEmpleado != "")
            {
                consulta += " AND e.nombre LIKE '%" + nombreEmpleado + "%'";
            }

            if (apellidoEmpleado != "")
            {
                consulta += " AND e.apellido LIKE '%" + apellidoEmpleado + "%'";
            }

            if (numeroDocumento != "")
            {
                consulta += " AND e.nroDocumento LIKE '%" + numeroDocumento + "%'";
            }

            DataTable tablaEmpleados = DBHelper.obtenerInstancia().consultar(consulta);

            foreach (DataRow fila in tablaEmpleados.Rows)
            {
                Empleado empleado = new Empleado
                {
                    IdEmpleado = (int)fila["idEmpleado"],
                    Nombre = fila["nombre"].ToString(),
                    Apellido = fila["apellido"].ToString(),
                    Mail = fila["mail"].ToString(),
                    TipoDocumento = new TipoDocumento()
                    {
                        Nombre = fila["nombreTipoDoc"].ToString(),
                    },
                    NroDocumento = fila["nroDocumento"].ToString(),
                    Usuario = fila["usuario"].ToString(),
                    Clave = fila["clave"].ToString(),
                    Perfil = new Perfil()
                    {
                        Nombre = fila["nombrePerfil"].ToString(),
                    }
                };
                lista.Add(empleado);
            }
            return lista;
        }

        public int recuperarEmpleado(string nombreEmpleado)
        {
            string consulta = "SELECT * FROM Empleados WHERE nombre = '" +
                               nombreEmpleado + "' AND borrado = 0";

            DataTable tabla = DBHelper.obtenerInstancia().consultar(consulta);
            if (tabla.Rows.Count > 0)
                return (int)tabla.Rows[0][0];
            else
                return 0;
        }

        public Empleado RecuperarEmpleadoDNI(string dniEmpleado)
        {
            string consulta = "SELECT * FROM Empleados WHERE nroDocumento = '" +
                               dniEmpleado + "' AND borrado = 0";

            DataTable tabla = DBHelper.obtenerInstancia().consultar(consulta);
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    Empleado empleado = new Empleado
                    {
                        IdEmpleado = (int)fila["idEmpleado"],
                        Nombre = fila["nombre"].ToString(),
                        Apellido = fila["apellido"].ToString(),
                        Mail = fila["mail"].ToString(),
                        //Usuario = new Usuario()
                        //{
                        //    NombreUsuario = fila["nombreUsu"].ToString(),
                        //},
                        TipoDocumento = new TipoDocumento()
                        {
                            Nombre = fila["nombreTipoDoc"].ToString(),
                        },
                        NroDocumento = fila["nroDocumento"].ToString(),
                    };
                    return empleado;
                }
                return null;
            }
            else
                return null;
        }

        public bool TieneUsuario(string dniEmpleado)
        {
            string consulta = "SELECT e.idUsuario FROM Empleados e WHERE nroDocumento = '" +
                               dniEmpleado + "' AND idUsuario IS NOT NULL AND borrado = 0";

            DataTable tabla = DBHelper.obtenerInstancia().consultar(consulta);
            if (tabla.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public Empleado EncontrarEmpleado(string usuario, string clave)
        {
            string consulta = "SELECT e.idEmpleado, e.nombre, e.apellido, e.mail, e.nroDocumento, " +
                              "td.nombre as nombreTipoDoc, e.usuario, e.clave, p.nombre as nombrePerfil " +
                              "FROM Empleados e JOIN TipoDocumento td ON (e.idTipoDocumento = td.idTipoDocumento) " +
                              "LEFT JOIN Perfiles p ON (p.idPerfil = e.idPerfil) " +
                              "WHERE e.usuario = '" + usuario + "' AND e.clave = '" + clave + "' " +
                              "AND e.borrado = 0 AND td.borrado = 0";

            DataTable tabla = DBHelper.obtenerInstancia().consultar(consulta);
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    Empleado empleado = new Empleado
                    {
                        IdEmpleado = (int)fila["idEmpleado"],
                        Nombre = fila["nombre"].ToString(),
                        Apellido = fila["apellido"].ToString(),
                        Mail = fila["mail"].ToString(),
                        Usuario = fila["usuario"].ToString(),
                        Clave = fila["clave"].ToString(),
                        TipoDocumento = new TipoDocumento()
                        {
                            Nombre = fila["nombreTipoDoc"].ToString(),
                        },
                        NroDocumento = fila["nroDocumento"].ToString(),
                    };
                    return empleado;
                }
                return null;
            }
            else
                return null;
        }
            
                
        
    }
}
