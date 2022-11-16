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
    public partial class frmABMCNivel : Form
    {
        INivelService servicioNivel = new NivelService();

        private Nivel nivel = new Nivel();
        private Acciones accion = Acciones.insert;

        public enum Acciones
        {
            insert,
            update,
            delete
        }

        public frmABMCNivel(Acciones accion, Nivel nivel)
        {
            InitializeComponent();
            this.accion = accion;
            this.nivel = nivel;
        }

        private void btnCancelarABMC_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir?",
                                "Saliendo",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                                this.Close();
        }

        private void btnAceptarABMC_Click(object sender, EventArgs e)
        {
            string nombreNivel = txtNombre.Text.ToString();
            switch (accion)
            {
                case Acciones.insert:
                    if (servicioNivel.existeNivel(nombreNivel) == 0)
                    {
                        if (ValidarNivel())
                        {
                            nivel.Nombre = txtNombre.Text.ToString();
                            nivel.PuntosDesde = int.Parse(txtPuntosDesde.Text);
                            nivel.PuntosHasta = int.Parse(txtPuntosHasta.Text);
                            nivel.Descuento = int.Parse(txtDescuento.Text);
                            if (servicioNivel.crearNivel(nivel) != 0)
                            {
                                MessageBox.Show("El nivel se ha registrado",
                                                "Informacion",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);
                                                this.Close();
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("El nivel ya se encuentra registrado en el sistema, vuelva a intentarlo.",
                                        "Aviso",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
                        txtNombre.Focus();
                    }
                    break;

                case Acciones.update:
                    if (nivel.Nombre != nombreNivel)
                    {
                        if (servicioNivel.existeNivel(nombreNivel) != 0)
                        {
                            MessageBox.Show("El nivel ya se encuentra registrado en el sistema, vuelva a intentarlo.",
                                            "Aviso",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Exclamation);
                                txtNombre.Focus();
                        }
                        else
                        {
                            if (ValidarNivel())
                            {
                                nivel.Nombre = txtNombre.Text.ToString();
                                nivel.PuntosDesde = int.Parse(txtPuntosDesde.Text);
                                nivel.PuntosHasta = int.Parse(txtPuntosHasta.Text);
                                nivel.Descuento = int.Parse(txtDescuento.Text);

                                if (servicioNivel.modificarNivel(nivel) != 0)
                                {
                                    MessageBox.Show("El nivel se ha modificado",
                                                    "Informacion",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                        }
                    }
                    else
                    {
                        if (ValidarNivel())
                        {
                            nivel.Nombre = txtNombre.Text.ToString();
                            nivel.PuntosDesde = int.Parse(txtPuntosDesde.Text);
                            nivel.PuntosHasta = int.Parse(txtPuntosHasta.Text);
                            nivel.Descuento = int.Parse(txtDescuento.Text);
                        }

                        if (servicioNivel.modificarNivel(nivel) != 0)
                        {
                            MessageBox.Show("El nivel se ha modificado.", "Información",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    break;

                case Acciones.delete:
                    if (MessageBox.Show("¿Está seguro que desea eliminar el nivel " + nombreNivel + "?",
                                        "Eliminando",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question,
                                        MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        if (servicioNivel.eliminarNivel(nivel) != 0)
                        {
                            MessageBox.Show("El nivel se ha eliminado.", "Información",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    break;

            }
        }

        private void CargarDatos()
        {
            txtIdNivel.Text = nivel.IdNivel.ToString();
            txtNombre.Text = nivel.Nombre.ToString();
            txtPuntosDesde.Text = nivel.PuntosDesde.ToString();
            txtPuntosHasta.Text = nivel.PuntosHasta.ToString();
            txtDescuento.Text = nivel.Descuento.ToString();
        }

        private bool ValidarNivel()
        {
            string nombreNivel = txtNombre.Text.ToString();
            string puntosDesde = txtPuntosDesde.Text.ToString();
            string puntosHasta = txtPuntosHasta.Text.ToString();
            string descuento = txtDescuento.Text.ToString();

            //int num_var = Int32.Parse(str_var);

            //Validamos que se haya cargado un nivel
            if (nombreNivel == "")
            {
                MessageBox.Show("Se debe ingresar un nivel.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return false;
            }

            //Validamos que se hayan cargado los puntos desde 
            if (puntosDesde == "")
            {
                MessageBox.Show("Se deben ingresar los puntos desde.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (puntosHasta == "")
            {
                MessageBox.Show("Se deben ingresar los puntos hasta.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (descuento == "")
            {
                MessageBox.Show("Se debe ingresar un descuento.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            //if (descuento )

            return true;
        }

        private void frmABMCNivel_Load(object sender, EventArgs e)
        {
            switch (accion)
            {
                case Acciones.insert:
                    {
                        this.Text = "Nuevo Nivel";
                        break;
                    }

                case Acciones.update:
                    {
                        this.Text = "Modificar Nivel";
                        CargarDatos();
                        txtNombre.Enabled = true;
                        txtPuntosDesde.Enabled = true;
                        txtPuntosHasta.Enabled = true;
                        txtDescuento.Enabled = true;
                        break;
                    }

                case Acciones.delete:
                    {
                        this.Text = "Eliminar nivel";
                        CargarDatos();
                        txtNombre.Enabled = false;
                        txtPuntosDesde.Enabled = false;
                        txtPuntosHasta.Enabled = false;
                        txtDescuento.Enabled = false;
                        break;
                    }
            }

        }

        private void txtPuntosDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

        private void txtPuntosHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

    }
}
