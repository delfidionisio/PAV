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
    public partial class frmABMCProveedor : Form
    {
        IProveedorService servicioProveedor = new ProveedorService();
        IMateriaPrimaService servicioMateriaPrima = new MateriaPrimaService();

        private Proveedor proveedor = new Proveedor();
        private Acciones accion = Acciones.insert;

        public enum Acciones
        {
            insert,
            update,
            delete
        }

        public frmABMCProveedor(Acciones accion, Proveedor proveedor)
        {
            InitializeComponent();
            this.accion = accion;
            this.proveedor = proveedor;
        }

        private void frmABMCProveedor_Load(object sender, EventArgs e)
        {
            this.CargarComboMateriaPrima(cmbMateriaPrima, servicioMateriaPrima.traerTodos());

            switch (accion)
            {
                case Acciones.insert:
                    {
                        this.Text = "Nuevo proveedor";
                        break;
                    }
                case Acciones.update:
                    {
                        this.Text = "Modificar proveedor";
                        CargarDatos();
                        txtNombre.Enabled = true;
                        cmbMateriaPrima.Enabled = true;
                        txtMail.Enabled = true;
                        txtTelefono.Enabled = true;
                        break;

                    }
                case Acciones.delete:
                    {
                        this.Text = "Eliminar proveedor";
                        CargarDatos();
                        txtNombre.Enabled = false;
                        cmbMateriaPrima.Enabled = false;
                        txtMail.Enabled = false;
                        txtTelefono.Enabled = false;
                        break;
                    }
            }
        }

        private void CargarDatos()
        {
            txtIdProveedor.Text = proveedor.IdProveedor.ToString();
            txtNombre.Text = proveedor.Nombre.ToString();
            cmbMateriaPrima.Text = proveedor.MateriaPrima.Nombre.ToString();
            txtMail.Text = proveedor.Mail.ToString();
            txtTelefono.Text = proveedor.Telefono.ToString();
        }

        private void CargarComboMateriaPrima(ComboBox cmbMateriaPrima, List<MateriaPrima> lista)
        {
            cmbMateriaPrima.DataSource = lista;
            cmbMateriaPrima.DisplayMember = "Nombre";
            cmbMateriaPrima.ValueMember = "IdMateriaPrima";
            cmbMateriaPrima.SelectedIndex = -1;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombreProveedor = txtNombre.Text.ToString();
            switch (accion)
            {
                case Acciones.insert:
                    if (servicioProveedor.existeProveedor(nombreProveedor) == 0)
                    {
                        if (ValidarProveedor())
                        {
                            proveedor.Nombre = txtNombre.Text.ToString();
                            proveedor.MateriaPrima = (MateriaPrima)cmbMateriaPrima.SelectedItem;
                            proveedor.Mail = txtMail.Text.ToString();
                            proveedor.Telefono = txtTelefono.Text.ToString();

                            if (servicioProveedor.crearProveedor(proveedor) != 0)
                            {
                                MessageBox.Show("El proveedor se ha registrado.", "Información",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }

                        }

                    }
                    else
                    {
                        MessageBox.Show("El proveedor ya se encuentra registrado en el sistema, vuelva a intentarlo",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNombre.Focus();
                    }
                    break;

                case Acciones.update:
                    if (proveedor.Nombre != nombreProveedor)
                    {
                        if (servicioProveedor.existeProveedor(nombreProveedor) != 0)
                        {
                            MessageBox.Show("El proveedor ya se encuentra registrado en el sistema, vuelva a intentarlo",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            //txtNombreABMC.BackColor = Color.Tomato;
                            txtNombre.Focus();
                            //usuario.NombreUsuario = txtNombreABMC.Text.ToString();
                        }

                        else
                        {
                            if (ValidarProveedor())
                            {
                                proveedor.Nombre = txtNombre.Text.ToString();
                                proveedor.MateriaPrima = (MateriaPrima)cmbMateriaPrima.SelectedItem;
                                proveedor.Mail = txtMail.Text.ToString();
                                proveedor.Telefono = txtTelefono.Text.ToString();
                            }

                            if (servicioProveedor.modificarProveedor(proveedor) != 0)
                            {
                                MessageBox.Show("El proveedor se ha modificado.", "Información",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        if (ValidarProveedor())
                        {
                            proveedor.Nombre = txtNombre.Text.ToString();
                            proveedor.MateriaPrima = (MateriaPrima)cmbMateriaPrima.SelectedItem;
                            proveedor.Mail = txtMail.Text.ToString();
                            proveedor.Telefono = txtTelefono.Text.ToString();
                        }

                        if (servicioProveedor.modificarProveedor(proveedor) != 0)
                        {
                            MessageBox.Show("El proveedor se ha modificado.", "Información",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    break;

                case Acciones.delete:
                    if (MessageBox.Show("¿Está seguro que desea eliminar el proveedor " + nombreProveedor + "?",
                                        "Eliminando",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question,
                                        MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        if (servicioProveedor.eliminarProveedor(proveedor) != 0)
                        {
                            MessageBox.Show("El proveedor se ha eliminado.", "Información",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    break;
            }
        }
        private bool ValidarProveedor()
        {
            string nombreProveedor = txtNombre.Text.ToString();
            MateriaPrima matPri = (MateriaPrima)cmbMateriaPrima.SelectedItem;
            string mail = (txtMail.Text).ToString();
            string telefono = txtTelefono.Text.ToString();

            //int num_var = Int32.Parse(str_var);
            //Validamos que se haya cargado un producto
            if (nombreProveedor == string.Empty)
            {
                MessageBox.Show("Se debe ingresar un proveedor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return false;
            }

            //Validamos que se haya seleccionado un tipo de producto 
            if (matPri == null)
            {
                MessageBox.Show("Se debe seleccionar una materia prima.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (mail == "")
            {
                MessageBox.Show("Se debe ingresar un mail.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (telefono == "")
            {
                MessageBox.Show("Se debe ingresar un teléfono.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }
    }
}
