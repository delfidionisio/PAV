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
    public partial class frmMateriaPrima : Form
    {

        IMateriaPrimaService servicioMateriaPrima = new MateriaPrimaService();
        List<MateriaPrima> listaMateriaPrima = new List<MateriaPrima>();


        public frmMateriaPrima()
        {
            InitializeComponent();
        }

        private void frmMateriaPrima_Load(object sender, EventArgs e)
        {
            this.Limpiar();
            btnEliminarMateriaPrima.Enabled = false;
            btnEditarMateriaPrima.Enabled = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string nombreMateriaPrima = string.Empty;
            string idMateriaPrima = string.Empty;

            if (checkTodos.Checked)
                this.Limpiar();

            if (txtNombre.Text != string.Empty)
            {
                nombreMateriaPrima = txtNombre.Text.ToString();
            }

            if (txtIdMateriaPrima.Text != string.Empty)
            {
                idMateriaPrima = txtIdMateriaPrima.Text.ToString();
            }

            listaMateriaPrima = servicioMateriaPrima.traerFiltrados(nombreMateriaPrima, idMateriaPrima);

            if (listaMateriaPrima.Count == 0)
            {
                MessageBox.Show("No se ha encontrado ninguna materia prima.",
                "MATERIA PRIMA NO ENCONTRADA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);

                this.Limpiar();
                //this.CargarGrillaUsuarios(dgvProductos, servicioProducto.traerTodos());
            }
            else
                this.CargarGrillaMateriaPrima(dgvMateriaPrima, listaMateriaPrima);
            this.Limpiar();

        }

        private void CargarGrillaMateriaPrima(DataGridView grillaMateriaPrima, List<MateriaPrima> lista)
        {
            grillaMateriaPrima.Rows.Clear();
            foreach (MateriaPrima m in lista)
            {
                grillaMateriaPrima.Rows.Add(m.IdMateriaPrima, m.Nombre, m.Stock, m.NombreUnidadMedida.Nombre);
            }
        }

        private void btnNuevaMateriaPrima_Click(object sender, EventArgs e)
        {
            var materiaPrima = new MateriaPrima();
            frmABMCMateriaPrima nuevaMateriaPrima = new frmABMCMateriaPrima(frmABMCMateriaPrima.Acciones.insert, materiaPrima);
            nuevaMateriaPrima.ShowDialog();

        }

        private void btnEditarMateriaPrima_Click(object sender, EventArgs e)
        {
            var idMateriaPrimaSeleccionada = (int)dgvMateriaPrima.CurrentRow.Cells[0].Value;
            var materiaPrima = (MateriaPrima)encontrarMateriaPrima(idMateriaPrimaSeleccionada);

            frmABMCMateriaPrima modificarMateriaPrima = new frmABMCMateriaPrima(frmABMCMateriaPrima.Acciones.update, materiaPrima);
            modificarMateriaPrima.ShowDialog();
        }

        private MateriaPrima encontrarMateriaPrima(int idMateriaPrimaSeleccionada)
        {
            MateriaPrima materiaPrimaSeleccionada = new MateriaPrima();
            foreach (MateriaPrima mat in this.listaMateriaPrima)
            {
                if (mat.IdMateriaPrima == idMateriaPrimaSeleccionada)
                {
                    materiaPrimaSeleccionada = mat;
                    break;
                }
            }
            return materiaPrimaSeleccionada;
        }

        private void btnEliminarMateriaPrima_Click(object sender, EventArgs e)
        {
            var idMateriaPrimaSeleccionada = (int)dgvMateriaPrima.CurrentRow.Cells[0].Value;
            var materiaPrima = (MateriaPrima)encontrarMateriaPrima(idMateriaPrimaSeleccionada);

            frmABMCMateriaPrima eliminarMateriaPrima = new frmABMCMateriaPrima(frmABMCMateriaPrima.Acciones.delete, materiaPrima);
            eliminarMateriaPrima.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpiar()
        {
            this.txtNombre.Text = string.Empty;
            this.txtIdMateriaPrima.Text = string.Empty;
            
        }

        private void checkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTodos.Checked)
            {
                txtNombre.Enabled = false;
                txtIdMateriaPrima.Enabled = false;
                
            }
            else
            {
                txtNombre.Enabled = true;
                txtIdMateriaPrima.Enabled = true;
            }
        }

        private void dgvMateriaPrima_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditarMateriaPrima.Enabled = true;
            btnEliminarMateriaPrima.Enabled = true;
        }
    }
}
