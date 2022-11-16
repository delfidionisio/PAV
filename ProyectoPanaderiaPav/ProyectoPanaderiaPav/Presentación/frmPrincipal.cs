using ProyectoPanaderiaPav.Entidades;
using ProyectoPanaderiaPav.Presentación;
using ProyectoPanaderiaPav.Presentación.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPanaderiaPav
{
    public partial class frmPrincipal : Form
    {
        // Atributos del formulario principal
        Empleado empleado = new Empleado();
        
        public frmPrincipal()
        {
            InitializeComponent();
        }

        // Crear una instancia del formulario login y asignar el atributo empleado según quien inicia sesión
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
            empleado = login.Empleado;
            timerFechaHora.Enabled = true;
        }

        // Cierra el formulario 
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Crear una instancia del formulario de productos
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos formProductos = new frmProductos();
            formProductos.ShowDialog();
            formProductos.Dispose();
        }

        // Crear una instancia del formulario de clientes
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente formClientes = new frmCliente();
            formClientes.ShowDialog();
            formClientes.Dispose();
        }

        // Crear una instancia del formulario de empleados 
        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleados formEmpleados = new frmEmpleados();
            formEmpleados.ShowDialog();
            formEmpleados.Dispose();
        }

        // Crear una instancia del formulario de proveedores
        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedores formProveedores = new frmProveedores();
            formProveedores.ShowDialog();
            formProveedores.Dispose();
        }

        // Crear una instancia del formulario de materia prima
        private void materiaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMateriaPrima formMateriaPrima = new frmMateriaPrima();
            formMateriaPrima.ShowDialog();
            formMateriaPrima.Dispose();
        }

        // Crear una instancia del formulario de registrar venta
        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            frmVenta formVenta = new frmVenta(empleado);
            formVenta.ShowDialog();
            formVenta.Dispose();
        }

        // Crear una instancia del formulario de generar reporte de productos
        private void generarReporteDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteProductos formReporteProd = new frmReporteProductos();
            formReporteProd.ShowDialog();
            formReporteProd.Dispose();
        }

        // Crear una instancia del formulario de generar reporte de ventas 
        private void generarReporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteVentas formReporteVentas = new frmReporteVentas();
            formReporteVentas.ShowDialog();
            formReporteVentas.Dispose();
        }

        // Crear una instancia del formulario de generar estadística de ventas por mes
        private void generarReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteRendimientos formReporteRend = new frmReporteRendimientos();
            formReporteRend.ShowDialog();
            formReporteRend.Dispose();
        }

        // Crear una instancia del formulario generar reporte de descuentos otorgados 
        private void generarReporteDeDescuentosOtorgadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteDescuentos formReporteDesc = new frmReporteDescuentos();
            formReporteDesc.ShowDialog();
            formReporteDesc.Dispose();
        }

        private void timerFechaHora_Tick(object sender, EventArgs e)
        {
            lblHoraActual.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFechaActual.Text = DateTime.Now.ToShortDateString();
        }
    }
}
