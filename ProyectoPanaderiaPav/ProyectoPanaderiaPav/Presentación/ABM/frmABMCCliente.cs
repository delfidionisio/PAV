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
    public partial class frmABMCCliente : Form
    {
        IClienteService servicioCliente = new ClienteService();
        ITipoDocumentoService servicioTipoDocumento = new TipoDocumentoService();

        private Cliente cliente = new Cliente();
        private Acciones accion = Acciones.insert;
        public string DniCliente { get; set; }

        public enum Acciones
        {
            insert,
            update,
            delete
        }

        public frmABMCCliente(Acciones accion, Cliente cliente)
        {
            InitializeComponent();
            this.accion = accion;
            this.cliente = cliente;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombreCliente = txtNombreABMC.Text.ToString();
            switch (accion)
            {
                case Acciones.insert:
                    //if (servicioCliente.existeCliente(nombreCliente) == 0)
                    //{
                        if (ValidarCliente())
                        {
                            cliente.Nombre = txtNombreABMC.Text.ToString();
                            cliente.Apellido = txtApellidoCliente.Text.ToString();
                            cliente.Mail = txtMailCliente.Text.ToString();
                            if (txtPuntos.Text == "")
                                cliente.Puntos = 0;
                            else
                                cliente.Puntos = int.Parse(txtPuntos.Text);
                            cliente.NroDocumento = txtNumeroDoc.Text.ToString();
                            this.DniCliente = txtNumeroDoc.Text.ToString();
                            cliente.TipoDocumento = (TipoDocumento)cmbTipoDoc.SelectedItem;
                            

                            if (servicioCliente.crearCliente(cliente) != 0)
                            {
                                MessageBox.Show("El cliente se ha registrado.", "Información",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }

                        }
                    //}
                    //else
                    //{
                    //    MessageBox.Show("El cliente ya se encuentra registrado en el sistema, vuelva a intentarlo",
                    //                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //    txtNombreABMC.Focus();
                    //}
                    break;
                case Acciones.update:
                    //if (cliente.Nombre != nombreCliente)
                    //{
                        //if (servicioCliente.existeCliente(nombreCliente) != 0)
                        //{
                            //MessageBox.Show("El cliente ya se encuentra registrado en el sistema, vuelva a intentarlo",
                                //"Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            //txtNombreABMC.Focus();
                        //}

                        //else
                        //{
                            if (ValidarCliente())
                            {
                                cliente.Nombre = txtNombreABMC.Text.ToString();
                                cliente.Apellido = txtApellidoCliente.Text.ToString();
                                cliente.Mail = txtMailCliente.Text.ToString();
                                if (txtPuntos.Text == "")
                                    cliente.Puntos = 0;
                                else
                                    cliente.Puntos = int.Parse(txtPuntos.Text);
                                cliente.NroDocumento = txtNumeroDoc.Text.ToString();
                                cliente.TipoDocumento = (TipoDocumento)cmbTipoDoc.SelectedItem;
                            }

                            if (servicioCliente.modificarCliente(cliente) != 0)
                            {
                                MessageBox.Show("El cliente se ha modificado.", "Información",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        //}
                    //}
                    //else
                    //{
                    //    if (ValidarCliente())
                    //    {
                    //        cliente.Nombre = txtNombreABMC.Text.ToString();
                    //        cliente.Apellido = txtApellidoCliente.Text.ToString();
                    //        cliente.Mail = txtMailCliente.Text.ToString();
                    //        if (txtPuntos.Text == "")
                    //            cliente.Puntos = 0;
                    //        else
                    //            cliente.Puntos = int.Parse(txtPuntos.Text);
                    //        cliente.NroDocumento = txtNumeroDoc.Text.ToString();
                    //        cliente.TipoDocumento = (TipoDocumento)cmbTipoDoc.SelectedItem;
                    //    }

                    //    if (servicioCliente.modificarCliente(cliente) != 0)
                    //    {
                    //        MessageBox.Show("El cliente se ha modificado.", "Información",
                    //                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //        this.Close();
                    //    }
                    //}
                    break;
                case Acciones.delete:
                    if (MessageBox.Show("¿Está seguro que desea eliminar el cliente " + nombreCliente + "?",
                                        "Eliminando",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question,
                                        MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        if (servicioCliente.eliminarCliente(cliente) != 0)
                        {
                            MessageBox.Show("El cliente se ha eliminado.", "Información",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea salir?",
                                "Saliendo",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void frmABMCCliente_Load(object sender, EventArgs e)
        {
            this.CargarComboTipoDocumento(cmbTipoDoc, servicioTipoDocumento.traerTodos());
            switch (accion)
            {
                case Acciones.insert:
                    {
                        this.Text = "Nuevo Cliente";
                        break;
                    }
                case Acciones.update:
                    {
                        this.Text = "Modificar Cliente";
                        CargarDatos();
                        txtNombreABMC.Enabled = true;
                        txtApellidoCliente.Enabled = true;
                        txtMailCliente.Enabled = true;
                        txtPuntos.Enabled = true;
                        txtNumeroDoc.Enabled = true;
                        cmbTipoDoc.Enabled = true;
                        break;
                    }
                case Acciones.delete:
                    {
                        this.Text = "Eliminar Cliente";
                        CargarDatos();
                        txtNombreABMC.Enabled = false;
                        txtApellidoCliente.Enabled = false;
                        txtMailCliente.Enabled = false;
                        txtPuntos.Enabled = false;
                        txtNumeroDoc.Enabled = false;
                        cmbTipoDoc.Enabled = false;
                        break;
                    }
            }
        }

        private void CargarComboTipoDocumento(ComboBox cmbTipoDoc, List<TipoDocumento> lista)
        {
            cmbTipoDoc.DataSource = lista;
            cmbTipoDoc.DisplayMember = "Nombre";
            cmbTipoDoc.ValueMember = "IdTipoDocumento";
            cmbTipoDoc.SelectedIndex = -1;
        }

        private void CargarDatos()
        {
            txtIdClienteABMC.Text = cliente.IdCliente.ToString();
            txtNombreABMC.Text = cliente.Nombre.ToString();
            txtApellidoCliente.Text = cliente.Apellido.ToString();
            txtMailCliente.Text = cliente.Mail.ToString();
            txtPuntos.Text = cliente.Puntos.ToString();
            txtNumeroDoc.Text = cliente.NroDocumento.ToString();
            cmbTipoDoc.Text = cliente.TipoDocumento.Nombre.ToString();
        }

        private bool ValidarCliente()
        {
            string nombreCliente = txtNombreABMC.Text.ToString();
            string apellidoCliente = txtApellidoCliente.Text.ToString();
            string mailCliente = txtMailCliente.Text.ToString();
            string puntos = txtPuntos.Text.ToString();
            string numeroDoc = txtNumeroDoc.ToString();
            TipoDocumento tipoDoc = (TipoDocumento)cmbTipoDoc.SelectedItem;
           
            if (nombreCliente == string.Empty)
            {
                MessageBox.Show("Se debe ingresar un cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombreABMC.Focus();
                return false;
            }

            //Validamos que se haya seleccionado un tipo de producto 
            if (tipoDoc == null)
            {
                MessageBox.Show("Se debe seleccionar un tipo de documento.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (apellidoCliente == "")
            {
                MessageBox.Show("Se debe ingresar un apellido.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (numeroDoc == "")
            {
                MessageBox.Show("Se debe ingresar un número de documento.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void txtPuntos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

        private void txtNumeroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }
    }
}
