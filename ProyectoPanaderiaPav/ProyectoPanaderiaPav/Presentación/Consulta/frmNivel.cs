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
    public partial class frmNivel : Form
    {
        INivelService servicioNivel = new NivelService();
        List<Nivel> listaNiveles = new List<Nivel>();

        public frmNivel()
        {
            InitializeComponent();
        }

        private void frmNivel_Load(object sender, EventArgs e)
        {
            this.Limpiar();
            this.CargarComboNombreNivel(cmbNombreNivel, servicioNivel.traerTodos());
        }

        public void Limpiar()
        {
            txtIdNivel.Text = string.Empty;
            cmbNombreNivel.SelectedIndex = -1;
        }

        private void CargarComboNombreNivel(ComboBox comboNombreNivel, List<Nivel> lista)
        {
            comboNombreNivel.DataSource = lista;
            comboNombreNivel.DisplayMember = "Nombre";
            comboNombreNivel.ValueMember = "IdNivel";
            comboNombreNivel.SelectedIndex = -1;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string nombreNivel = string.Empty;
            string idNivel = string.Empty;

            if (checkTodos.Checked)
                this.Limpiar();

            if (cmbNombreNivel.SelectedIndex != -1)
            {
                nombreNivel = cmbNombreNivel.Text.ToString();
            }

            if (txtIdNivel.Text != string.Empty)
            {
                idNivel = txtIdNivel.Text.ToString();
            }

            listaNiveles = servicioNivel.traerFiltrados(nombreNivel, idNivel);

            if (listaNiveles.Count == 0)
            {
                MessageBox.Show("No se ha encontrado ningún nivel.",
                "NIVEL NO ENCONTRADO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);

                this.Limpiar();
            }
            else
                this.CargarGrillaNiveles(dgvNiveles, listaNiveles);
            this.Limpiar();
        }

        private void CargarGrillaNiveles(DataGridView grillaNiveles, List<Nivel> niveles)
        {
            grillaNiveles.Rows.Clear();
            foreach (Nivel n in niveles)
            {
                grillaNiveles.Rows.Add(n.IdNivel, n.Nombre, n.PuntosDesde, n.PuntosHasta, n.Descuento);
            }
        }

        private void btnNuevoNivel_Click(object sender, EventArgs e)
        {
            var nivel = new Nivel();
            frmABMCNivel nuevoNivel = new frmABMCNivel(frmABMCNivel.Acciones.insert, nivel);
            nuevoNivel.ShowDialog();
        }

        private void btnEditarNivel_Click(object sender, EventArgs e)
        {
            var idNivelSeleccionado = (int)dgvNiveles.CurrentRow.Cells[0].Value;
            var nivel = (Nivel)encontrarNivel(idNivelSeleccionado);

            frmABMCNivel modificarNivel = new frmABMCNivel(frmABMCNivel.Acciones.update, nivel);
            modificarNivel.ShowDialog();
        }

        private object encontrarNivel(int idNivelSeleccionado)
        {
            Nivel nivelSeleccionado = new Nivel();
            foreach (Nivel niv in this.listaNiveles)
            {
                if (niv.IdNivel == idNivelSeleccionado)
                {
                    nivelSeleccionado = niv;
                    break;
                }
            }
            return nivelSeleccionado;
        }

        private void btnEliminarNivel_Click(object sender, EventArgs e)
        {
            var idNivelSeleccionado = (int)dgvNiveles.CurrentRow.Cells[0].Value;
            var nivel = (Nivel)encontrarNivel(idNivelSeleccionado);

            frmABMCNivel eliminarNivel = new frmABMCNivel(frmABMCNivel.Acciones.delete, nivel);
            eliminarNivel.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTodos.Checked)
            {
                txtIdNivel.Enabled = false;
                cmbNombreNivel.Enabled = false;
            }
            else
            {
                txtIdNivel.Enabled = true;
                cmbNombreNivel.Enabled = true;
            }
        }
    }
}
