using ProyectoPanaderiaPav.Entidades;
using ProyectoPanaderiaPav.Servicios.Implementaciones;
using ProyectoPanaderiaPav.Servicios.Interfaces;
using System;
using System.Collections;
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
    public partial class frmABMCProductos : Form
    {
        IProductoService servicioProducto = new ProductoService();
        ITipoProductoService servicioTipoProducto = new TipoProductoService();
        IUnidadMedidaService servicioUnidadMedida = new UnidadMedidaService();
        
        private Producto producto = new Producto();
        private Acciones accion = Acciones.insert;

        public enum Acciones
        {
            insert,
            update,
            delete
        }

        public frmABMCProductos(Acciones accion, Producto producto)
        {
            InitializeComponent();
            this.accion = accion;
            this.producto = producto;
        }

        private void frmABMCProductos_Load(object sender, EventArgs e)
        {
            this.CargarComboTipoProducto(cmbTipoProducto, servicioTipoProducto.traerTodos());
            this.CargarComboUnidadMedida(cmbPrecioPor, servicioUnidadMedida.traerTodos());
            switch (accion)
            {
                case Acciones.insert:
                    {
                        this.Text = "Nuevo producto";
                        break;
                    }
                case Acciones.update:
                    {
                        this.Text = "Modificar producto";
                        CargarDatos();
                        txtNombre.Enabled = true;
                        cmbTipoProducto.Enabled = true;
                        txtPrecio.Enabled = true;
                        txtPuntos.Enabled = true;
                        cmbPrecioPor.Enabled = true;
                        break;

                    }
                case Acciones.delete:
                    {
                        this.Text = "Eliminar producto";
                        CargarDatos();
                        txtNombre.Enabled = false;
                        cmbTipoProducto.Enabled = false;
                        txtPrecio.Enabled = false;
                        txtPuntos.Enabled = false;
                        cmbPrecioPor.Enabled = false;
                        break;
                    }
            }
        }

        private void CargarComboUnidadMedida(ComboBox cmbPrecioPor, List<UnidadMedida> lista)
        {
            cmbPrecioPor.DataSource = lista;
            cmbPrecioPor.DisplayMember = "Nombre";
            cmbPrecioPor.ValueMember = "IdUnidadMedida";
            cmbPrecioPor.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?",
                "Saliendo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombreProducto = txtNombre.Text.ToString();
            switch (accion)
            {
                case Acciones.insert:
                    if (servicioProducto.existeProducto(nombreProducto) == 0)
                    {
                        if (ValidarProducto())
                        {
                            producto.Nombre = txtNombre.Text.ToString();
                            producto.Tipo = (TipoProducto)cmbTipoProducto.SelectedItem;
                            if (txtPuntos.Text == "")
                                producto.Puntos = 0;
                            else
                                producto.Puntos = int.Parse(txtPuntos.Text);
                            
                            producto.Precio = int.Parse(txtPrecio.Text);
                            producto.PrecioUnidad = (UnidadMedida)cmbPrecioPor.SelectedItem;
                            
                            // AYUDA! 
                            //producto.Precio = Convert.ToInt32(txtPrecio.Text);
                            //int puntos = Convert.ToInt32(txtPuntos.Text);
                            //int precioUnidad = cmbPrecioPor.SelectedIndex;
                            if (servicioProducto.crearProducto(producto) != 0)
                            {
                                MessageBox.Show("El producto se ha registrado.", "Información",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }

                        }

                    }
                    else
                    {
                        MessageBox.Show("El producto ya se encuentra registrado en el sistema, vuelva a intentarlo",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNombre.Focus();
                    }
                    break;

                case Acciones.update:
                    if (producto.Nombre != nombreProducto)
                    {
                        if (servicioProducto.existeProducto(nombreProducto) != 0)
                        {
                            MessageBox.Show("El producto ya se encuentra registrado en el sistema, vuelva a intentarlo",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            //txtNombreABMC.BackColor = Color.Tomato;
                            txtNombre.Focus();
                            //usuario.NombreUsuario = txtNombreABMC.Text.ToString();
                        }

                        else
                        {
                            if (ValidarProducto())
                            {
                                producto.Nombre = txtNombre.Text.ToString();
                                producto.Tipo = (TipoProducto)cmbTipoProducto.SelectedItem;
                                producto.Precio = int.Parse(txtPrecio.Text);
                                producto.PrecioUnidad = (UnidadMedida)cmbPrecioPor.SelectedItem;
                                if (txtPuntos.Text == "")
                                    producto.Puntos = 0;
                                else
                                    producto.Puntos = int.Parse(txtPuntos.Text);
                            }
 
                            if (servicioProducto.modificarProducto(producto) != 0)
                            {
                                MessageBox.Show("El producto se ha modificado.", "Información",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        if (ValidarProducto())
                        {
                            producto.Nombre = txtNombre.Text.ToString();
                            producto.Tipo = (TipoProducto)cmbTipoProducto.SelectedItem;
                            producto.Precio = int.Parse(txtPrecio.Text);
                            producto.PrecioUnidad = (UnidadMedida)cmbPrecioPor.SelectedItem;
                            if (txtPuntos.Text == "")
                                producto.Puntos = 0;
                            else
                                producto.Puntos = int.Parse(txtPuntos.Text);
                        }

                        if (servicioProducto.modificarProducto(producto) != 0)
                        {
                            MessageBox.Show("El producto se ha modificado.", "Información",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    break;

                case Acciones.delete:
                    if (MessageBox.Show("¿Está seguro que desea eliminar el producto " + nombreProducto + "?",
                                        "Eliminando",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question,
                                        MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        if (servicioProducto.eliminarProducto(producto) != 0)
                        {
                            MessageBox.Show("El producto se ha eliminado.", "Información",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    break;
            }
                
        }
        
        private void CargarDatos()
        {
            txtIdProducto.Text = producto.IdProducto.ToString();
            txtNombre.Text = producto.Nombre.ToString();
            cmbTipoProducto.Text = producto.Tipo.Nombre.ToString();
            txtPrecio.Text = producto.Precio.ToString();
            cmbPrecioPor.Text = "Kilo";
            //if (producto.PrecioUnidad == 1)
            //    cmbPrecioPor.Text = "Unidad";
            txtPuntos.Text = producto.Puntos.ToString();
        }

        private void CargarComboTipoProducto(ComboBox comboTipoProducto, List<TipoProducto> lista)
        {
            comboTipoProducto.DataSource = lista;
            comboTipoProducto.DisplayMember = "Nombre";
            comboTipoProducto.ValueMember = "IdTipo";
            comboTipoProducto.SelectedIndex = -1;
        }

        private bool ValidarProducto()
        {
            string nombreProducto = txtNombre.Text.ToString();
            TipoProducto tipoProd = (TipoProducto)cmbTipoProducto.SelectedItem;
            string precio = (txtPrecio.Text).ToString();
            int precioUnidad = cmbPrecioPor.SelectedIndex;
            
            //int num_var = Int32.Parse(str_var);
            //Validamos que se haya cargado un producto
            if (nombreProducto == string.Empty)
            {
                MessageBox.Show("Se debe ingresar un producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return false;
            }

            //Validamos que se haya seleccionado un tipo de producto 
            if (tipoProd == null)
            {
                MessageBox.Show("Se debe seleccionar un tipo de producto.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (precio == "")
            {
                MessageBox.Show("Se debe ingresar un precio.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (precioUnidad == -1)
            {
                MessageBox.Show("Se debe seleccionar un precio por unidad.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

        private void txtPuntos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }
    }
}
