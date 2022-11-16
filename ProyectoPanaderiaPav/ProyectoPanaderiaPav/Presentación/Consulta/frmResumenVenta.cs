using ProyectoPanaderiaPav.Entidades;
using ProyectoPanaderiaPav.Servicios.Implementaciones;
using ProyectoPanaderiaPav.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPanaderiaPav.Presentación
{
    public partial class frmResumenVenta : Form
    {
        IVentaService servicioVenta = new VentaService();
        Venta nuevaVenta = new Venta();
        public enum Modo
        {
            guardar, volver
        }
        public Modo frmModo;

        public frmResumenVenta(Venta venta)
        {
            InitializeComponent();
            this.nuevaVenta = venta;
            frmModo = Modo.guardar;
        }

        private void frmResumenVenta_Load(object sender, EventArgs e)
        {
            CargarDatosEmpleado();
            CargarDatosCliente();
            CargarDatosProductos();
            CargarDatosTotales();
            txtNroVenta.Text = servicioVenta.traerProximoNumero().ToString();
        }

        private void CargarDatosProductos()
        {
            CargarGrillaDetalleVenta(nuevaVenta.DetalleVentaLista);
        }

        private void CargarGrillaDetalleVenta(List<DetalleVenta> detVenta)
        {
            foreach (DetalleVenta det in detVenta)
            {
                dgvDetalleVenta.Rows.Add(det.NroDetalle, det.Producto.Nombre, det.Cantidad, 
                                     det.PrecioUnitario, det.Subtotal);
            }
             
        }

        private void CargarDatosEmpleado()
        {
            string nombreApellido = nuevaVenta.Empleado.Nombre.ToString() + " " + nuevaVenta.Empleado.Apellido.ToString();
            txtNombreEmpleado.Text = nombreApellido;

            txtDNIEmpleado.Text = nuevaVenta.Empleado.NroDocumento.ToString();
        }

        private void CargarDatosCliente()
        {
            string nombreApellido = nuevaVenta.Cliente.Nombre.ToString() + " " + nuevaVenta.Cliente.Apellido.ToString();
            txtNombreCliente.Text = nombreApellido;

            txtDNICliente.Text = nuevaVenta.Cliente.NroDocumento.ToString();

            if (nuevaVenta.Cliente.NroDocumento != "00000000")
            {
                int puntosSumados = nuevaVenta.TotalPuntos;
                txtPuntosSumados.Text = puntosSumados.ToString();

                txtPuntosActuales.Text = (puntosSumados + nuevaVenta.Cliente.Puntos).ToString();

                txtNivel.Text = nuevaVenta.Nivel.Nombre.ToString();
            }

        }

        private void CargarDatosTotales()
        {
            txtSubtotal.Text = nuevaVenta.Subtotal.ToString();
            txtDescuento.Text = nuevaVenta.Descuento.ToString();
            txtTotal.Text = nuevaVenta.Total.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (servicioVenta.crearVenta(nuevaVenta) != 0)
            {
                MessageBox.Show("La venta se ha registrado.", "Información",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmModo = Modo.volver;
            this.Close();
        }
    }
}
