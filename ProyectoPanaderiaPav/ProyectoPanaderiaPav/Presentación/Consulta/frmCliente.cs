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
    public partial class frmCliente : Form
    {
        IClienteService servicioCliente = new ClienteService();
        List<Cliente> listaClientes = new List<Cliente>();

        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string nombreCliente = string.Empty;
            string apellidoCliente = string.Empty;
            string numeroDocumento = string.Empty;

            if (checkTodos.Checked) //RESOLVER CHECK
                this.Limpiar();

            if (txtNombreCliente.Text != string.Empty)
            {
                nombreCliente = txtNombreCliente.Text.ToString();
            }

            if (txtApellidoCliente.Text != string.Empty)
            {
                apellidoCliente = txtApellidoCliente.Text.ToString();
            }

            if (txtNumeroDocumento.Text != string.Empty)
            {
                numeroDocumento = txtNumeroDocumento.Text.ToString();
            }

            listaClientes = servicioCliente.traerFiltrados(nombreCliente, apellidoCliente, numeroDocumento);

            if (listaClientes.Count == 0)
            {
                MessageBox.Show("No se ha encontrado ningún cliente.",
                                "CLIENTE NO ENCONTRADO",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
                this.Limpiar();
            }
            else
                this.CargarGrillaClientes(dgvClientes, listaClientes);
            this.Limpiar();

        }

        private void CargarGrillaClientes(DataGridView grillaClientes, List<Cliente> clientes)
        {
            grillaClientes.Rows.Clear();
            foreach (Cliente c in clientes)
            {
                grillaClientes.Rows.Add(c.IdCliente, c.Nombre, c.Apellido, c.Mail, c.Puntos,
                                        c.TipoDocumento.Nombre, c.NroDocumento);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            var idClienteSeleccionado = (int)dgvClientes.CurrentRow.Cells[0].Value;
            var cliente = (Cliente)encontrarCliente(idClienteSeleccionado);

            frmABMCCliente eliminarCliente = new frmABMCCliente(frmABMCCliente.Acciones.delete, cliente);
            eliminarCliente.ShowDialog();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            var idClienteSeleccionado = (int)dgvClientes.CurrentRow.Cells[0].Value;
            var cliente = (Cliente)encontrarCliente(idClienteSeleccionado);

            frmABMCCliente modificarCliente = new frmABMCCliente(frmABMCCliente.Acciones.update, cliente);
            modificarCliente.ShowDialog();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();
            //cliente.TipoDocumento = new TipoDocumento();
            frmABMCCliente nuevoCliente = new frmABMCCliente(frmABMCCliente.Acciones.insert, cliente);
            nuevoCliente.ShowDialog();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            this.Limpiar();
            btnEditarCliente.Enabled = false;
            btnEliminarCliente.Enabled = false;
        }

        private void Limpiar()
        {
            this.txtNombreCliente.Text = string.Empty;
            this.txtApellidoCliente.Text = string.Empty;
            this.txtNumeroDocumento.Text = string.Empty;
        }

        private object encontrarCliente(int idClienteSeleccionado)
        {
            Cliente clienteSeleccionado = new Cliente();
            foreach (Cliente cli in this.listaClientes)
            {
                if (cli.IdCliente == idClienteSeleccionado)
                {
                    clienteSeleccionado = cli;
                    break;
                }
            }
            return clienteSeleccionado;
        }

        private void checkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTodos.Checked)
            {
                txtNombreCliente.Enabled = false;
                txtApellidoCliente.Enabled = false;
                txtNumeroDocumento.Enabled = false;
            }
            else
            {
                txtNombreCliente.Enabled = true;
                txtApellidoCliente.Enabled = true;
                txtNumeroDocumento.Enabled = true;
            }

        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditarCliente.Enabled = true;
            btnEliminarCliente.Enabled = true;
        }

        private void txtNumeroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }
    }
}
