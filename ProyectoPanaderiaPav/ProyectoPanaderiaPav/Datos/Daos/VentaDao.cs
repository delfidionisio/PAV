using ProyectoPanaderiaPav.Datos.Interfaces;
using ProyectoPanaderiaPav.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPanaderiaPav.Datos.Daos
{
    internal class VentaDao : IVentaDao
    {
        public int InsertarVenta(Venta venta)
        {
            int aux = 0;
            //Insertar Venta
            string insertVenta = "Insert into Ventas (fecha, idCliente" +
                                 ", idEmpleado, subtotal, descuento) "
                                 + "Values ('" + venta.Fecha.ToString("yyyy/MM/dd") + "', "
                                               + venta.Cliente.IdCliente + ","                                        
                                               + venta.Empleado.IdEmpleado + ", "
                                               + venta.Subtotal + ","
                                               + venta.Descuento + ")";
                
            DBHelper.obtenerInstancia().conectarConTransaccion();
            DBHelper.obtenerInstancia().EjecutarSQLConTransaccion(insertVenta);

            //Recuperar id nuevo

            var nuevoNroVenta = DBHelper.obtenerInstancia().ConsultaSQLScalar("SELECT @@IDENTITY");
            //DetalleVenta.NroVenta = Convert.ToInt32(nuevoNroVenta);

            foreach (DetalleVenta detVenta in venta.DetalleVentaLista)
            {
                string insertDetalle = "Insert into DetalleVenta (nroVenta, idProducto, " +
                                       "cantidad, precioUnitario, idUnidadMedida) " +
                                       "Values ('" + nuevoNroVenta + "', "
                                                   + detVenta.Producto.IdProducto+ ", "
                                                   + detVenta.Cantidad + ","
                                                   + detVenta.PrecioUnitario + ","
                                                   + detVenta.Producto.PrecioUnidad.IdUnidadMedida + ")";
                
                DBHelper.obtenerInstancia().EjecutarSQLConTransaccion(insertDetalle);
                
            }

            // Actualizar los puntos del cliente
            if (venta.Cliente.NroDocumento != "00000000")
            {
                string actualizarCliente = "UPDATE Clientes SET puntos = puntos +" + venta.TotalPuntos +
                                        " WHERE idCliente =" + venta.Cliente.IdCliente;

                DBHelper.obtenerInstancia().EjecutarSQLConTransaccion(actualizarCliente);
            }
                
            aux = DBHelper.obtenerInstancia().desconectar();
            return aux;

            
            
        }

        public DataTable RecuperarDatosReporteDescuentos(string fechaDesde, string fechaHasta)
        {
            DataTable resultado = new DataTable();

            string consulta = "SELECT subtotal as totalVentasSinDescuento, subtotal*descuento/100 as descuentoAplicado, fecha as fechaVenta, " +
                                 "subtotal-(subtotal*descuento/100) as totalVentasConDescuento" +
                                 " FROM Ventas" +
                                 " WHERE fecha BETWEEN '" + fechaDesde + "' AND '"
                                 + fechaHasta + "'";

            resultado = DBHelper.obtenerInstancia().consultar(consulta);
            return resultado;
        }

        public DataTable RecuperarDatosReporteVenta(string fechaDesde, string fechaHasta, int idEmpleado)
        {
            DataTable resultado = new DataTable();
            //string consulta = "SELECT COUNT(DISTINCT v.nroVenta) as cantVentas, " +
            //    "SUM(DISTINCT v.subtotal  - (v.subtotal*v.descuento/100)) as totVend, " +
            //    "ROUND(AVG (DISTINCT v.subtotal  - (v.subtotal*v.descuento/100)), 2) as prom, SUM (dv.cantidad) as cantProd " +
            //    "FROM Ventas v JOIN DetalleVenta dv ON (v.nroVenta = dv.nroVenta) ";

            string consulta = "SELECT v.nroVenta, v.fecha, v.subtotal, v.descuento, v.subtotal - " +
                "(v.subtotal * v.descuento / 100) as totVend FROM Ventas v";

            consulta += " WHERE v.fecha BETWEEN '" + fechaDesde + "' AND '" + fechaHasta + "'";

            if (idEmpleado != 0)
            {
                consulta += " AND idEmpleado = " + idEmpleado;
            }

            resultado = DBHelper.obtenerInstancia().consultar(consulta);
            return resultado;
            
        }

        public int RecuperarProximoNumero()
        {
            string consulta = "SELECT MAX(nroVenta) FROM Ventas";

            DataTable tabla = DBHelper.obtenerInstancia().consultar(consulta);

            if (tabla.Rows[0][0] == DBNull.Value)
            {
                return 1;
            }
            else
                return (int)tabla.Rows[0][0] + 1;
        }
    }
}
