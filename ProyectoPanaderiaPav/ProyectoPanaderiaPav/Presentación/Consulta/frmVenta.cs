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
    public partial class frmVenta : Form
    {
        IProductoService servicioProducto = new ProductoService();
        IClienteService servicioCliente = new ClienteService();
        INivelService servicioNiveles = new NivelService();
        IVentaService servicioVenta = new VentaService();

        List<Nivel> listaNiveles = new List<Nivel>();
                
        Venta venta = new Venta();

        public frmVenta(Empleado empleado)
        {
            InitializeComponent();
            this.listaNiveles = servicioNiveles.traerTodos();
            venta.Empleado = empleado;
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            CargarComboProducto(cmbProductos, servicioProducto.traerTodos());
            dtpVenta.Value = DateTime.Now;
            dtpVenta.Text = DateTime.Now.ToString();

            Cliente clienteGenerico = servicioCliente.traerCliente("00000000");
            CargarGrillaClientes(dgvCliente, clienteGenerico);
            venta.Cliente = clienteGenerico;
        }

        private void CargarGrillaClientes(DataGridView grillaClientes , Cliente cliente)
        {
            grillaClientes.Rows.Clear();
            grillaClientes.Rows.Add(cliente.Nombre, cliente.Apellido, cliente.Mail, cliente.Puntos, cliente.NroDocumento);
        }

        private void CargarComboProducto(ComboBox cmbProductos, List<Producto> lista)
        {
            cmbProductos.DataSource = lista;
            cmbProductos.SelectedIndex = -1;
            cmbProductos.DisplayMember = "Nombre";
            cmbProductos.ValueMember = "IdProducto";
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string dni = txtDniCliente.Text.ToString();

            venta.Cliente = servicioCliente.traerCliente(dni);
            
            if (venta.Cliente == null)
            {
                MessageBox.Show("No se encontró ningún Cliente con el DNI ingresado.", "Información",
                                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
                CargarGrillaClientes(dgvCliente, venta.Cliente);
            
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();
            frmABMCCliente nuevoCliente = new frmABMCCliente(frmABMCCliente.Acciones.insert, cliente);
            nuevoCliente.ShowDialog();
            CargarGrillaClientes(dgvCliente, servicioCliente.traerCliente(nuevoCliente.DniCliente));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //DetalleVenta detalleVenta = new DetalleVenta();
            Producto producto = (Producto)cmbProductos.SelectedItem;

            DetalleVenta detalleVenta = new DetalleVenta(float.Parse(txtCantidad.Text), producto);
            detalleVenta.NroDetalle = venta.DetalleVentaLista.Count + 1;
            
            DetalleVenta det = ValidarRepeticionProducto(detalleVenta);
            if (det == null)
            {
                venta.AgregarDetalle(detalleVenta);
                cargarGrillaDetalleVenta(dgvDetalleVenta, detalleVenta);
            }
            else
                cargarGrillaDetalleVenta(dgvDetalleVenta, det);

            // VACIAMOS LOS TXT DE C/ PRODUCTO
            txtSubtot.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            txtUnidadMedida.Text = "";

            venta.Descuento = traerDescuentoCliente();

            venta.calcularTotal();
            
            txtSubtotal.Text = venta.Subtotal.ToString();
            txtDescuento.Text = venta.Descuento.ToString();
            txtTotal.Text = venta.Total.ToString();
        }

        private DetalleVenta ValidarRepeticionProducto(DetalleVenta detalleVenta)
        {
            DetalleVenta detalleCambiado = new DetalleVenta(0, null);
            detalleCambiado = null;
            foreach (DetalleVenta detLista in venta.DetalleVentaLista)
            {
                if (detLista.Producto.IdProducto == detalleVenta.Producto.IdProducto)
                {
                    detLista.Cantidad += detalleVenta.Cantidad;
                    detLista.Subtotal += detalleVenta.Subtotal;

                    venta.Subtotal += detalleVenta.Subtotal;
                    venta.calcularTotal();

                    detalleCambiado = detLista;

                    dgvDetalleVenta.Rows.RemoveAt(detLista.NroDetalle-1);
                    return detalleCambiado;
                }
            }
            return detalleCambiado;
        }

        private void calcularTotalVenta(DetalleVenta detABorrar)
        {
            venta.Subtotal -= detABorrar.Subtotal;
            venta.Total -= detABorrar.Subtotal;
            txtSubtotal.Text = venta.Subtotal.ToString();
            txtTotal.Text = venta.Total.ToString();
        }

        private int traerDescuentoCliente()
        {
            Nivel nivelCliente = new Nivel();
            foreach (Nivel nivel in listaNiveles)
            {
                if (venta.Cliente.Puntos >= nivel.PuntosDesde && venta.Cliente.Puntos <= nivel.PuntosHasta)
                {
                    nivelCliente = nivel;
                }
            }
            return nivelCliente.Descuento;
        }

        private void cargarGrillaDetalleVenta(DataGridView grillaProductos, DetalleVenta det)
        {
            grillaProductos.Rows.Add(det.NroDetalle, det.Producto.IdProducto, det.Producto.Nombre, det.Producto.Tipo.Nombre, 
                                     det.Cantidad, det.PrecioUnitario, det.Subtotal, det.Producto.Puntos);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvDetalleVenta.CurrentRow == null)
                return;

            // Borrarla de la lista
            var nroDetalle = (int)dgvDetalleVenta.CurrentRow.Cells[0].Value;
            var detalleVenta = (DetalleVenta)encontrarDetalle(nroDetalle);
            venta.QuitarDetalle(detalleVenta);
            venta.calcularTotal();
            txtSubtotal.Text = venta.Subtotal.ToString();
            txtTotal.Text = venta.Total.ToString();

            // Borrarla de la grilla
            dgvDetalleVenta.Rows.Remove(dgvDetalleVenta.CurrentRow);
        }

        private object encontrarDetalle(int nroDetalle)
        {
            DetalleVenta detalleSeleccionado = new DetalleVenta(0, null);
            foreach (DetalleVenta det in venta.DetalleVentaLista)
            {
                if (det.NroDetalle == nroDetalle)
                {
                    detalleSeleccionado = det;
                    break;
                }
            }
            return detalleSeleccionado;
        }

        private bool ValidarDatos(Venta venta)
        {
            if (venta.DetalleVentaLista.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un detalle de venta.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSubtot.Text = "";
            
            if (cmbProductos.SelectedItem != null)
            {
                Producto producto = (Producto)cmbProductos.SelectedItem;
                txtPrecio.Text = producto.Precio.ToString();
                txtUnidadMedida.Text = producto.PrecioUnidad.Nombre.ToString();
                txtCantidad.Enabled = true;
            }
                
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            venta.Fecha = dtpVenta.Value;

            int puntosClienteActuales = venta.TotalPuntos + venta.Cliente.Puntos;
            venta.Nivel = traerNivel(puntosClienteActuales);

            //FALTA AGREGAR EL EMPLEADO Y NUMERO VENTA

            // Calcular total de puntos por la venta
            foreach (DetalleVenta detalleVenta in venta.DetalleVentaLista)
            {
                venta.TotalPuntos += (int)(detalleVenta.Cantidad * detalleVenta.Producto.Puntos);

            }

            if (ValidarDatos(venta))
            {
                frmResumenVenta resumenVenta = new frmResumenVenta(venta);
                resumenVenta.ShowDialog();
                if (resumenVenta.frmModo.ToString() == "guardar")
                    this.Close();
            }
        }

        private Nivel traerNivel(int puntosClienteActuales)
        {
            Nivel nuevoNivel = new Nivel();
            foreach (Nivel nivel in listaNiveles)
            {
                if (puntosClienteActuales >= nivel.PuntosDesde && puntosClienteActuales <= nivel.PuntosHasta)
                {
                    nuevoNivel = nivel;
                }
            }
            return nuevoNivel;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?",
                "Saliendo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void txtDniCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            Producto producto = (Producto)cmbProductos.SelectedItem;
            
            if (txtCantidad.Text != "")
            {
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                txtSubtot.Text = (producto.Precio * cantidad).ToString();
            }
            else
                txtSubtot.Text = "";
        }
    }
}
