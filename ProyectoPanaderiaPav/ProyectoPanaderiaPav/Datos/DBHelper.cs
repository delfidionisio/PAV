using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Datos
{
    internal class DBHelper
    {
        //private static DBHelper instancia;
        //private SqlConnection conexion;
        //private SqlCommand comando;
        //private string cadenaConexion;

        //private DBHelper()
        //{
        //    conexion = new SqlConnection();
        //    comando = new SqlCommand();
        //    cadenaConexion = Properties.Resources.StringConexion;
        //}
        //public static DBHelper obtenerInstancia()
        //{
        //    if (instancia == null)
        //        instancia = new DBHelper();
        //    return instancia;
        //}

        //// Método utilizado para realizar una consulta en la base de datos
        //public DataTable consultar(string consultaSQL)
        //{
        //    DataTable tabla = new DataTable();
        //    conexion.ConnectionString = cadenaConexion;
        //    conexion.Open();

        //    comando.Connection = conexion;
        //    comando.CommandType = CommandType.Text;
        //    comando.CommandText = consultaSQL;
        //    tabla.Load(comando.ExecuteReader());

        //    conexion.Close();
        //    return tabla;
        //}

        //// Método utilizado para un insert, update y delete en la base de datos
        //public int actualizar(string actualizacionSQL)
        //{
        //    int filasAfectadas = 0;
        //    conexion.ConnectionString = cadenaConexion;
        //    conexion.Open();

        //    comando.Connection = conexion;
        //    comando.CommandType = CommandType.Text;
        //    comando.CommandText = actualizacionSQL;
        //    filasAfectadas = comando.ExecuteNonQuery();

        //    conexion.Close();
        //    return filasAfectadas;
        //}

        // -------------- 

        enum ResultadoTransaccion
        {
            exito, fracaso
        }
        enum tipoConexion
        {
            simple, transaccion
        }
        private ResultadoTransaccion miEstado = ResultadoTransaccion.exito;
        private tipoConexion miTipo = tipoConexion.simple;

        private static DBHelper instancia;
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlTransaction transaccion;
        private string cadenaConexion;

        private DBHelper()
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
            cadenaConexion = Properties.Resources.StringConexion;
        }
        public static DBHelper obtenerInstancia()
        {
            if (instancia == null)
                instancia = new DBHelper();
            return instancia;
        }
        public DataTable consultar(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consultaSQL;
            tabla.Load(comando.ExecuteReader());

            conexion.Close();
            return tabla;
        }
        public int actualizar(string consultaSQL)
        {
            //try
            //{
            int filasAfectadas = 0;
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consultaSQL;
            filasAfectadas = comando.ExecuteNonQuery();

            conexion.Close();
            return filasAfectadas;
            //}
            //catch
            //{
            //return 0;
            //}
        }

        public void conectarConTransaccion()
        {
            miTipo = tipoConexion.transaccion;
            miEstado = ResultadoTransaccion.exito;

            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            transaccion = conexion.BeginTransaction();
            comando.Transaction = transaccion;
            comando.Connection = conexion;
        }
        public int desconectar()
        {
            if (miTipo == tipoConexion.transaccion)
            {
                if (miEstado == ResultadoTransaccion.exito)
                {
                    transaccion.Commit(); //MessageBox.Show("La trasacción resultó con éxito...");
                }
                else
                {
                    transaccion.Rollback(); //MessageBox.Show("La trasacción no pudo realizarce...");
                }
                miTipo = tipoConexion.simple;
            }
            if ((conexion.State == ConnectionState.Open))
            {
                conexion.Close();
            }

            // Dispose() libera los recursos asociados a la conexón
            conexion.Dispose();
            if (miEstado.Equals(ResultadoTransaccion.exito))
                return 1;
            else
                return 0;
        }

        public void EjecutarSQLConTransaccion(string consultaSql)
        {
            //  Se utiliza para sentencias SQL del tipo Insert, Update, Delete con transaccion.
            try
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = consultaSql;
                comando.ExecuteNonQuery();
                miEstado = ResultadoTransaccion.exito;
            }
            catch
            {
                miEstado = ResultadoTransaccion.fracaso;
            }
        }
        public object ConsultaSQLScalar(string consultaSql)
        {
            comando.CommandType = CommandType.Text;
            comando.CommandText = consultaSql;
            return comando.ExecuteScalar();
        }

    }
}
