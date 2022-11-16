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
    public partial class frmProveedores : Form
    {
        IMateriaPrimaService servicioMateriaPrima = new MateriaPrimaService();
        IProveedorService servicioProveedor = new ProveedorService();
        List<Proveedor> listaProveedores = new List<Proveedor>();

        public frmProveedores()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            this.Limpiar();
            this.CargarComboMateriaPrima(cmbMateriaPrima, servicioMateriaPrima.traerTodos());
            btnEditarProveedor.Enabled = false;
            btnEliminarProveedor.Enabled = false;
        }

        private void CargarComboMateriaPrima(ComboBox cmbMateriaPrima, List<MateriaPrima> lista)
        {
            cmbMateriaPrima.DataSource = lista;
            cmbMateriaPrima.DisplayMember = "Nombre";
            cmbMateriaPrima.ValueMember = "IdMateriaPrima";
            cmbMateriaPrima.SelectedIndex = -1;
        }

        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            cmbMateriaPrima.SelectedIndex = -1;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string nombreProveedor = string.Empty;
            string materiaPrima = string.Empty;


            if (checkTodos.Checked)
                this.Limpiar();

            if (txtNombre.Text != string.Empty)
            {
                nombreProveedor = txtNombre.Text.ToString();
            }

            if (cmbMateriaPrima.SelectedIndex != -1)
            {
                materiaPrima = cmbMateriaPrima.SelectedValue.ToString();
            }

            listaProveedores = servicioProveedor.traerFiltrados(nombreProveedor, materiaPrima);

            if (listaProveedores.Count == 0)
            {
                MessageBox.Show("No se ha encontrado ningún proveedor.",
                "PROVEEDOR NO ENCONTRADO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);

                this.Limpiar();
            }
            else
                this.CargarGrillaProveedores(dgvProveedores);
            this.Limpiar();
        }

        public void CargarGrillaProveedores(DataGridView grillaProveedores)
        {
            grillaProveedores.Rows.Clear();

            foreach (Proveedor p in listaProveedores)
            {
                grillaProveedores.Rows.Add(p.IdProveedor, p.Nombre, p.MateriaPrima.Nombre, p.Mail, p.Telefono);
            }
        }

        private void checkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTodos.Checked)
            {
                txtNombre.Enabled = false;
                cmbMateriaPrima.Enabled = false;
            }
            else
            {
                txtNombre.Enabled = true;
                cmbMateriaPrima.Enabled = true;
            }
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            var proveedor = new Proveedor();
            frmABMCProveedor nuevoProveedor = new frmABMCProveedor(frmABMCProveedor.Acciones.insert, proveedor);
            nuevoProveedor.ShowDialog();
        }

        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
            var idProveedorSeleccionado = (int)dgvProveedores.CurrentRow.Cells[0].Value;
            var proveedor = (Proveedor)encontrarProveedor(idProveedorSeleccionado);

            frmABMCProveedor modificarProveedor = new frmABMCProveedor(frmABMCProveedor.Acciones.update, proveedor);
            modificarProveedor.ShowDialog();
        }

        private Proveedor encontrarProveedor(int idProveedorSeleccionado)
        {
            Proveedor proveedorSeleccionado = new Proveedor();
            foreach (Proveedor prov in listaProveedores)
            {
                if (prov.IdProveedor == idProveedorSeleccionado)
                {
                    proveedorSeleccionado = prov;
                    break;
                }
            }
            return proveedorSeleccionado;
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            var idProveedorSeleccionado = (int)dgvProveedores.CurrentRow.Cells[0].Value;
            var proveedor = (Proveedor)encontrarProveedor(idProveedorSeleccionado);

            frmABMCProveedor eliminarProveedor = new frmABMCProveedor(frmABMCProveedor.Acciones.delete, proveedor);
            eliminarProveedor.ShowDialog();
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditarProveedor.Enabled = true;
            btnEliminarProveedor.Enabled = true;
        }
    }
}
