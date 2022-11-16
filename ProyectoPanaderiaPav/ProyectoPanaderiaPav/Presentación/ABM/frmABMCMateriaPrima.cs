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
    public partial class frmABMCMateriaPrima : Form
    {
        IMateriaPrimaService servicioMateriaPrima = new MateriaPrimaService();
        IUnidadMedidaService servicioUnidadMedida = new UnidadMedidaService();
        

        private MateriaPrima materiaPrima = new MateriaPrima();
        private Acciones accion = Acciones.insert;

        public enum Acciones
        {
            insert,
            update,
            delete
        }

        public frmABMCMateriaPrima(Acciones accion, MateriaPrima materiaPrima)
        {
            InitializeComponent();
            this.accion = accion;
            this.materiaPrima = materiaPrima;
        }

        private void frmABMCMateriaPrima_Load(object sender, EventArgs e)
        {
            this.CargarComboUnidadMedida(cmbUnidadMedida, servicioUnidadMedida.traerTodos());
            switch (accion)
            {
                case Acciones.insert:
                    {
                        this.Text = "Nueva Materia Prima";
                        break;
                    }
                case Acciones.update:
                    {
                        this.Text = "Modificar Materia Prima";
                        CargarDatos();
                        txtNombre.Enabled = true;
                        txtStock.Enabled = true;
                        txtIdMateriaPrima.Enabled = false;
                        cmbUnidadMedida.Enabled = true; 
                        break;
                    }
                case Acciones.delete:
                    {
                        this.Text = "Eliminar Materia Prima";
                        CargarDatos();
                        txtNombre.Enabled = false;
                        cmbUnidadMedida.Enabled = false;
                        txtIdMateriaPrima.Enabled = false;
                        txtStock.Enabled = false;
                        
                        break;
                    }
            }
        }

        private void CargarComboUnidadMedida(ComboBox cmbUnidadMedida, List<UnidadMedida> lista)
        {
            cmbUnidadMedida.DataSource = lista;
            cmbUnidadMedida.DisplayMember = "Nombre";
            cmbUnidadMedida.ValueMember = "IdUnidadMedida";
            cmbUnidadMedida.SelectedIndex = -1;
        }
        

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombreMateriaPrima = txtNombre.Text.ToString();
            switch (accion)
            {
                case Acciones.insert:
                    if (servicioMateriaPrima.existeMateriaPrima(nombreMateriaPrima) == 0)
                    {
                        if (ValidarMateriaPrima())
                        {
                            materiaPrima.Nombre = txtNombre.Text.ToString();
                            materiaPrima.NombreUnidadMedida = (UnidadMedida)cmbUnidadMedida.SelectedItem;
                            materiaPrima.Stock = int.Parse(txtStock.Text);
                                                      
                            
                            if (servicioMateriaPrima.crearMateriaPrima(materiaPrima) != 0)
                            {
                                MessageBox.Show("El producto se ha registrado.", "Información",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }

                        }

                    }
                    else
                    {
                        MessageBox.Show("La materia prima ya se encuentra registrada en el sistema, vuelva a intentarlo",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNombre.Focus();
                    }
                    break;

                case Acciones.update:
                    if (materiaPrima.Nombre != nombreMateriaPrima)
                    {
                        if (servicioMateriaPrima.existeMateriaPrima(nombreMateriaPrima) != 0)
                        {
                            MessageBox.Show("La materia prima ya se encuentra registrada en el sistema, vuelva a intentarlo",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtNombre.Focus();
                        }

                        else
                        {
                            if (ValidarMateriaPrima())
                            {
                                materiaPrima.Nombre = txtNombre.Text.ToString();
                                materiaPrima.NombreUnidadMedida = (UnidadMedida)cmbUnidadMedida.SelectedItem;
                                materiaPrima.Stock = int.Parse(txtStock.Text);
                                
                            }
 
                            if (servicioMateriaPrima.modificarMateriaPrima(materiaPrima) != 0)
                            {
                                MessageBox.Show("La materia prima se ha modificado.", "Información",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        if (ValidarMateriaPrima())
                        {
                            materiaPrima.Nombre = txtNombre.Text.ToString();
                            materiaPrima.NombreUnidadMedida = (UnidadMedida)cmbUnidadMedida.SelectedItem;
                            materiaPrima.Stock = int.Parse(txtStock.Text);
                        }

                        if (servicioMateriaPrima.modificarMateriaPrima(materiaPrima) != 0)
                        {
                            MessageBox.Show("La materia prima se ha modificado.", "Información",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    break;

                case Acciones.delete:
                    if (MessageBox.Show("¿Está seguro que desea eliminar: " + nombreMateriaPrima + "?",
                                        "Eliminando",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question,
                                        MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        if (servicioMateriaPrima.eliminarMateriaPrima(materiaPrima) != 0)
                        {
                            MessageBox.Show("La materia prima se ha eliminado.", "Información",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    break;
            }
        }

        private void CargarDatos()
        {
            txtIdMateriaPrima.Text = materiaPrima.IdMateriaPrima.ToString();
            txtNombre.Text = materiaPrima.Nombre.ToString();
            txtStock.Text = materiaPrima.Stock.ToString();
            cmbUnidadMedida.Text = materiaPrima.NombreUnidadMedida.Nombre.ToString();
            
        }

        private bool ValidarMateriaPrima()
        {
            string nombreMateriaPrima = txtNombre.Text.ToString();
            int tipoUnidadMedida = cmbUnidadMedida.SelectedIndex; //REVISAR SI ES ASI!!! O UNIDADMEDIDA
            string stock = (txtStock.Text).ToString();
            //int precioUnidad = cmbPrecioPor.SelectedIndex;

          
            //Validamos que se haya cargado una materia prima
            if (nombreMateriaPrima == string.Empty)
            {
                MessageBox.Show("Se debe ingresar una materia prima.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return false;
            }

            //Validamos que se haya seleccionado una unidad medida
            if (tipoUnidadMedida == -1)
            {
                MessageBox.Show("Se debe seleccionar un tipo de Unidad de Medida.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }
    }
}
