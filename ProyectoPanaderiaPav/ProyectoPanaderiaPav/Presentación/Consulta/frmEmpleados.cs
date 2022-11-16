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
    public partial class frmEmpleados : Form
    {
        IEmpleadoService servicioEmpleado = new EmpleadoService();
        ITipoDocumentoService servicioTipoDocumento = new TipoDocumentoService();
        List<Empleado> listaEmpleados = new List<Empleado>();

        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            var empleado = new Empleado();
            frmABMCEmpleados nuevoEmpleado = new frmABMCEmpleados(frmABMCEmpleados.Acciones.insert, empleado);
            nuevoEmpleado.ShowDialog();
        }

        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            var idEmpleadoSeleccionado = (int)dgvEmpleados.CurrentRow.Cells[0].Value;
            var empleado = (Empleado)encontrarEmpleado(idEmpleadoSeleccionado);

            frmABMCEmpleados modificarEmpleado = new frmABMCEmpleados(frmABMCEmpleados.Acciones.update, empleado);
            modificarEmpleado.ShowDialog();
        }

        private Empleado encontrarEmpleado(int idEmpleadoSeleccionado)
        {
            Empleado empleadoSeleccionado = new Empleado();
            foreach (Empleado e in this.listaEmpleados)
            {
                if (e.IdEmpleado == idEmpleadoSeleccionado)
                {
                    empleadoSeleccionado = e;
                    break;
                }
            }
            return empleadoSeleccionado;
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            var idEmpleadoSeleccionado = (int)dgvEmpleados.CurrentRow.Cells[0].Value;
            var empleado = (Empleado)encontrarEmpleado(idEmpleadoSeleccionado);

            frmABMCEmpleados eliminarEmpleado = new frmABMCEmpleados(frmABMCEmpleados.Acciones.delete, empleado);
            eliminarEmpleado.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string nombreEmpleado = string.Empty;
            string apellidoEmpleado = string.Empty;
            string numeroDocumento = string.Empty;

            if (checkTodos.Checked)
                this.Limpiar();

            if (txtNombreEmpleado.Text != string.Empty)
            {
                nombreEmpleado = txtNombreEmpleado.Text.ToString();
            }

            if (txtApellidoEmpleado.Text != string.Empty)
            {
                apellidoEmpleado = txtApellidoEmpleado.Text.ToString();
            }

            if (txtNumeroDocumento.Text != string.Empty)
            {
                numeroDocumento = txtNumeroDocumento.Text.ToString();
            }

            listaEmpleados = servicioEmpleado.traerFlitrados(nombreEmpleado, apellidoEmpleado, numeroDocumento);

            if (listaEmpleados.Count == 0)
            {
                MessageBox.Show("No se ha encontrado ningún empleado",
                    "Empleado no encontrado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                this.Limpiar();
            }
            else
                this.CargarGrillaEmpleados(dgvEmpleados, listaEmpleados);
            this.Limpiar();
        }

        private void CargarGrillaEmpleados(DataGridView grillaEmpleados, List<Empleado> empleados)
        {
            grillaEmpleados.Rows.Clear();
            foreach (Empleado e in empleados)
            {
                grillaEmpleados.Rows.Add(e.IdEmpleado, e.Nombre, e.Apellido, e.Mail, e.TipoDocumento.Nombre, e.NroDocumento, 
                                        e.Usuario, e.Perfil.Nombre);
            }
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            this.Limpiar();
            btnEditarEmpleado.Enabled = false;
            btnEliminarEmpleado.Enabled = false;
        }

        private void Limpiar()
        {
            this.txtNombreEmpleado.Text = string.Empty;
            this.txtApellidoEmpleado.Text = string.Empty;
            this.txtNumeroDocumento.Text = string.Empty;
        }

        private void checkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTodos.Checked)
            {
                txtNombreEmpleado.Enabled = false;
                txtApellidoEmpleado.Enabled = false;
                txtNumeroDocumento.Enabled = false;
            }
            else
            {
                txtNombreEmpleado.Enabled = true;
                txtApellidoEmpleado.Enabled = true;
                txtNumeroDocumento.Enabled = true;
            }
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditarEmpleado.Enabled = true;
            btnEliminarEmpleado.Enabled = true;
        }

        
    }
}
