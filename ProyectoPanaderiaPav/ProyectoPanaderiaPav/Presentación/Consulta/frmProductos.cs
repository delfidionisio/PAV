using ProyectoPanaderiaPav.Entidades;
using ProyectoPanaderiaPav.Servicios;
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
    public partial class frmProductos : Form
    {
        // Atributos del formulario de productos 
        IProductoService servicioProducto = new ProductoService();
        ITipoProductoService servicioTipoProducto = new TipoProductoService();
        List<int> listaComboPuntos = new List<int>();
        List<Producto> listaProductos = new List<Producto>();
        //metodos metodo = new metodos();


        public frmProductos()
        {
            // Cargar el combo de puntos de productos 
            InitializeComponent();
            listaComboPuntos.Add(50);
            listaComboPuntos.Add(100);
            listaComboPuntos.Add(200);
            listaComboPuntos.Add(400);
            listaComboPuntos.Add(500);
            listaComboPuntos.Add(700);

        }

        // Cerrar el formulario 
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Load del formulario
        private void frmProductos_Load(object sender, EventArgs e)
        {
            this.Limpiar();
            this.CargarComboTipoProducto(cmbTipoProducto, servicioTipoProducto.traerTodos());
            //metodo.CargarCombo(cmbTipoProducto, servicioTipoProducto.traerTodos());
            this.CargarComboPuntos(cmbPuntos);
            btnEditarProducto.Enabled = false;
            btnEliminarProducto.Enabled = false;
        }

        // Método para cargar los combos de puntos
        private void CargarComboPuntos(ComboBox cmbPuntos)
        {
            cmbPuntos.DataSource = listaComboPuntos;
            cmbPuntos.SelectedIndex = -1;
        }

        // Método para cargar los tipo producto
        private void CargarComboTipoProducto(ComboBox comboTipoProducto, List<TipoProducto> lista)
        {
            comboTipoProducto.DataSource = lista;
            comboTipoProducto.DisplayMember = "Nombre";
            comboTipoProducto.ValueMember = "IdTipo";
            comboTipoProducto.SelectedIndex = -1;
        }

        // Limpiar los campos del formulario
        private void Limpiar()
        {
            this.txtNombreProducto.Text = string.Empty;
            this.cmbTipoProducto.SelectedIndex = -1;
            this.trbPrecio.Value = 0;
            lblValorPrecio.Text = trbPrecio.Value.ToString();
            this.cmbPuntos.SelectedIndex = -1;
            this.cmbOrdenarPor.SelectedIndex = -1;
        }

        private void trbPrecio_Scroll(object sender, EventArgs e)
        {
            lblValorPrecio.Text = trbPrecio.Value.ToString();
        }

        // Método para consultar productos según los filtros elegidos
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string nombreProducto = string.Empty;
            string tipoProducto = string.Empty;
            string precioHasta = string.Empty;
            string puntosHasta = string.Empty;
            string ordenarPor = "-1";

            if (checkTodos.Checked)
                this.Limpiar();

            // Asignar a las variables los valores correspondientes según los filtros elegidos
            if (txtNombreProducto.Text != string.Empty)
            {
                nombreProducto = txtNombreProducto.Text.ToString();
            }

            if (cmbTipoProducto.SelectedIndex != -1)
            {
                tipoProducto = cmbTipoProducto.SelectedValue.ToString();
            }

            if (trbPrecio.Value > 0)
            {
                precioHasta = trbPrecio.Value.ToString();
            }

            if (cmbPuntos.SelectedIndex != -1)
            {
                puntosHasta = cmbPuntos.SelectedValue.ToString();
            }

            if (cmbOrdenarPor.SelectedIndex != -1)
            {
                ordenarPor = cmbOrdenarPor.SelectedIndex.ToString();
            }

            listaProductos = servicioProducto.traerFiltrados(nombreProducto, tipoProducto, 
                                                    precioHasta, puntosHasta, ordenarPor);

            if (listaProductos.Count == 0)
            {
                MessageBox.Show("No se ha encontrado ningún producto.",
                "PRODUCTO NO ENCONTRADO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);

                this.Limpiar();
                //this.CargarGrillaUsuarios(dgvProductos, servicioProducto.traerTodos());
            }
            else
                this.CargarGrillaProductos(dgvProductos, listaProductos);
            this.Limpiar();
        }

        // Cargar la grilla de productos
        private void CargarGrillaProductos(DataGridView grillaProductos, List<Producto> productos)
        {
            grillaProductos.Rows.Clear();
            foreach (Producto p in productos)
            {
                grillaProductos.Rows.Add(p.IdProducto, p.Nombre, p.Tipo.Nombre, p.Precio, p.PrecioUnidad.Nombre, p.Puntos);
            }
        }

        // Habilita y deshabilita los campos del formulario cuando se presiona el check button "Todos"
        private void checkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTodos.Checked)
            {
                txtNombreProducto.Enabled = false;
                cmbTipoProducto.Enabled = false;
                trbPrecio.Enabled = false;
                cmbOrdenarPor.Enabled = false;
                cmbPuntos.Enabled = false;
            }
            else
            {
                txtNombreProducto.Enabled = true;
                cmbTipoProducto.Enabled = true;
                trbPrecio.Enabled = true;
                cmbOrdenarPor.Enabled = true;
                cmbPuntos.Enabled = true;
            }
        }

        // Método que crea una instancia del formulario ABMC productos en formato insert
        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            var producto = new Producto();
            frmABMCProductos nuevoProducto = new frmABMCProductos(frmABMCProductos.Acciones.insert, producto);
            nuevoProducto.ShowDialog();
        }

        // Método que crea una instancia del formulario ABMC productos en formato update
        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            // Guardar id del producto seleccionado según la celda seleccionada
            var idProductoSeleccionado = (int)dgvProductos.CurrentRow.Cells[0].Value;

            // Asignar el producto seleccionado a la variable
            var producto = (Producto)encontrarProducto(idProductoSeleccionado);
            
            frmABMCProductos modificarProducto = new frmABMCProductos(frmABMCProductos.Acciones.update, producto);
            modificarProducto.ShowDialog();
        }

        // Buscar si un producto ya se encuentra previamente en la lista de productos del formulario 
        private object encontrarProducto(int idProductoSeleccionado)
        {
            Producto productoSeleccionado = new Producto();
            foreach (Producto prod in this.listaProductos)
            {
                if (prod.IdProducto == idProductoSeleccionado)
                {
                    productoSeleccionado = prod;
                    break;
                }
            }
            return productoSeleccionado;
        }

        // Habilitar botones de edición y eliminación de productos cuando se selecciona un producto de la grilla 
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditarProducto.Enabled = true;
            btnEliminarProducto.Enabled = true;
        }

        // Método que crea una instancia del formulario ABMC productos en formato delete
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            // Guardar id del producto seleccionado según la celda seleccionada
            var idProductoSeleccionado = (int)dgvProductos.CurrentRow.Cells[0].Value;

            // Asignar el producto seleccionado a la variable
            var producto = (Producto)encontrarProducto(idProductoSeleccionado);

            frmABMCProductos eliminarProducto = new frmABMCProductos(frmABMCProductos.Acciones.delete, producto);
            eliminarProducto.ShowDialog(); 
        }
    }
}
