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
    public partial class frmABMCEmpleados : Form
    {
        IEmpleadoService servicioEmpleado = new EmpleadoService();
        ITipoDocumentoService servicioTipoDocumento = new TipoDocumentoService();
        IPerfilService servicioPerfil = new PerfilService();

        private Empleado empleado = new Empleado();
        private Acciones accion = Acciones.insert;

        public enum Acciones
        {
            insert, 
            update, 
            delete
        }

        public frmABMCEmpleados(Acciones accion, Empleado empleado)
        {
            InitializeComponent();
            this.accion = accion;
            this.empleado = empleado;
        }

        private void frmABMCEmpleados_Load(object sender, EventArgs e)
        {
            this.CargarComboTipoDocumento(cmbTipoDocumento, servicioTipoDocumento.traerTodos());
            this.CargarComboPerfil(cmbPerfil, servicioPerfil.traerTodos());
            switch (accion)
            {
                case Acciones.insert:
                    {
                        this.Text = "Nuevo empleado";
                        break;
                    }

                case Acciones.update:
                    {
                        this.Text = "Modificar empleado";
                        CargarDatos();
                        txtNombre.Enabled = true;
                        txtApellido.Enabled = true;
                        txtMail.Enabled = true;
                        //txtUsuario.Enabled = false;
                        cmbTipoDocumento.Enabled = true;
                        txtNumeroDocumento.Enabled = true;
                        cmbPerfil.Enabled = true;
                        txtUsuario.Enabled = true;
                        txtClave.Enabled = true;
                        txtClaveRepetida.Enabled = true;
                        break;
                    }

                case Acciones.delete:
                    {
                        this.Text = "Eliminar empleado";
                        CargarDatos();
                        txtNombre.Enabled = false;
                        txtApellido.Enabled = false;
                        txtMail.Enabled = false;
                        //txtUsuario.Enabled = false;
                        cmbTipoDocumento.Enabled = false;
                        txtNumeroDocumento.Enabled = false;
                        cmbPerfil.Enabled = false;
                        txtUsuario.Enabled = false;
                        txtClave.Enabled = false;
                        txtClaveRepetida.Enabled = false;
                        break;
                    }
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombreEmpleado = txtNombre.Text.ToString();
            switch (accion)
            {
                case Acciones.insert:
                    //if (servicioEmpleado.existeEmpleado(nombreEmpleado) == 0)
                    //{
                        if (ValidarEmpleado(Acciones.insert))
                        {
                            empleado.Nombre = txtNombre.Text.ToString();
                            empleado.Apellido = txtApellido.Text.ToString();
                            empleado.Mail = txtMail.Text.ToString();
                            //empleado.Usuario.NombreUsuario = txtUsuario.Text.ToString();
                            //empleado.Usuario.IdUsuario = servicioUsuario.existeUsuario(txtUsuario.Text.ToString());
                            empleado.TipoDocumento = (TipoDocumento)cmbTipoDocumento.SelectedItem;
                            empleado.NroDocumento = txtNumeroDocumento.Text.ToString();
                            empleado.Perfil = (Perfil)cmbPerfil.SelectedItem;
                            empleado.Usuario = txtUsuario.Text.ToString();
                            empleado.Clave = txtClave.Text.ToString();

                            if (servicioEmpleado.crearEmpleado(empleado) != 0)
                            {
                                MessageBox.Show("El empleado se ha registrado.", "Información",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }

                        }

                    //}
                    //else
                    //{
                    //    MessageBox.Show("El empleado ya se encuentra registrado en el sistema, vuelva a intentarlo",
                    //            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //    txtNombre.Focus();
                    //}
                    break;

                case Acciones.update:
                    //if (empleado.Nombre != nombreEmpleado)
                    //{
                    //    if (servicioEmpleado.existeEmpleado(nombreEmpleado) != 0)
                    //    {
                    //        MessageBox.Show("El empleado ya se encuentra registrado en el sistema, vuelva a intentarlo",
                    //            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //        txtNombre.Focus();
                    //    }

                    //    else
                    //    {
                            if (ValidarEmpleado(Acciones.update))
                            {
                                empleado.Nombre = txtNombre.Text.ToString();
                                empleado.Apellido = txtApellido.Text.ToString();
                                empleado.Mail = txtMail.Text.ToString();
                                //empleado.Usuario.IdUsuario = servicioUsuario.existeUsuario(txtUsuario.Text.ToString());
                                empleado.TipoDocumento = (TipoDocumento)cmbTipoDocumento.SelectedItem;
                                empleado.NroDocumento = txtNumeroDocumento.Text.ToString();
                                empleado.Perfil = (Perfil)cmbPerfil.SelectedItem;
                                empleado.Usuario = txtUsuario.Text.ToString();
                                empleado.Clave = txtClave.Text.ToString();
                            }

                            if (servicioEmpleado.modificarEmpleado(empleado) != 0)
                            {
                                MessageBox.Show("El empleado se ha modificado.", "Información",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        //}
                    //}
                    //else
                    //{
                    //    if (ValidarEmpleado())
                    //    {
                    //        empleado.Nombre = txtNombre.Text.ToString();
                    //        empleado.TipoDocumento = (TipoDocumento)cmbTipoDocumento.SelectedItem;
                    //        empleado.NroDocumento = txtNumeroDocumento.Text.ToString();
                    //    }

                    //    if (servicioEmpleado.modificarEmpleado(empleado) != 0)
                    //    {
                    //        MessageBox.Show("El empleado se ha modificado.", "Información",
                    //                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //        this.Close();
                    //    }
                    //}
                    break;

                case Acciones.delete:
                    if (MessageBox.Show("¿Está seguro que desea eliminar el empleado " + nombreEmpleado + "?",
                                        "Eliminando",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question,
                                        MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        if (servicioEmpleado.eliminarEmpleado(empleado) != 0)
                        {
                            MessageBox.Show("El empleado se ha eliminado.", "Información",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    break;
            }

        }

        private bool ValidarEmpleado(Acciones accionParaValidarUsuario)
        {
            string nombreEmp = txtNombre.Text.ToString();
            int tipoDoc = cmbTipoDocumento.SelectedIndex;
            string nroDocumento = txtNumeroDocumento.Text.ToString();
            string nombreUsuario = txtUsuario.Text;
            string claveUsuario = txtClave.Text;

            // NOMBRE DE USUARIO A VALIDAR SI YA ESTA CREADO PERO NO ASIGNADO A OTRO EMPLEADO
            //if (accionParaValidarUsuario == Acciones.insert)
            //{ 
            //string nombreUsuario = txtUsuario.Text.ToString();
            //int idUsuario = servicioUsuario.existeUsuario(nombreUsuario);

            //// VAMOS A VALIDAR QUE ESE NOMBRE DE USUARIO NO ESTÉ ASIGNADO YA A UN EMPLEADO
            //if (idUsuario != 0)
            //{
            //    if (this.encontrarEmpleadoConUsuario(idUsuario) != null)
            //    {
            //        MessageBox.Show("El usuario ingresado ya está asignado a un empleado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        txtUsuario.Focus();
            //        return false;
            //    }           
            //}
            //else
            //{
            //    // REGLA DE NEGOCIO!!! EL USUARIO YA DEBE ESTAR CREADO
            //    MessageBox.Show("El nombre de usuario ingresado no existe. Intente nuevamente con uno válido", "Aviso", 
            //        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    txtUsuario.Focus();
            //    return false;
            //}
            //}
            if (nombreUsuario != string.Empty)
            {
                //Validamos que se ingrese la contraseña
                if (claveUsuario == string.Empty)
                {
                    MessageBox.Show("Se debe ingresar una contraseña.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                //Validamos que las contraseñas sean iguales
                if (claveUsuario != txtClaveRepetida.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden, por favor ingrese nuevamente los datos",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //VER!!! SI QUEREMOS BORRARLO
                    txtClave.Focus();
                    return false;
                }
            }
            
            //Validamos que se haya cargado un empleado
            if (nombreEmp == string.Empty)
            {
                MessageBox.Show("Se debe ingresar un empleado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return false;
            }
            
            //Validamos que se haya seleccionado un tipo de documento 
            if (tipoDoc == -1)
            {
                MessageBox.Show("Se debe seleccionar un tipo de documento.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            //Validamos que se haya cargado un numero de documento
            if (nroDocumento == "")
            {
                MessageBox.Show("Se debe ingresar un número de documento.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        //public Empleado encontrarEmpleadoConUsuario(int idUsuarioSeleccionado)
        //{
        //    Empleado empleadoSeleccionado = new Empleado();
        //    empleadoSeleccionado = null;
        //    List<Empleado> listaEmple = servicioEmpleado.traerTodos();
        //    foreach (Empleado e in listaEmple)
        //    {
        //        if (e.Usuario.IdUsuario == idUsuarioSeleccionado)
        //        {
        //            empleadoSeleccionado = e;
        //            break;
        //        }
        //    }
        //    return empleadoSeleccionado;
        //}

            private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?",
                "Saliendo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void CargarDatos()
        {
            txtIdEmpleado.Text = empleado.IdEmpleado.ToString();
            txtNombre.Text = empleado.Nombre.ToString();
            txtApellido.Text = empleado.Apellido.ToString();
            txtMail.Text = empleado.Mail.ToString();
            //txtUsuario.Text = empleado.Usuario.NombreUsuario.ToString();
            cmbTipoDocumento.Text = empleado.TipoDocumento.Nombre.ToString();
            txtNumeroDocumento.Text = empleado.NroDocumento.ToString();
            txtUsuario.Text = empleado.Usuario.ToString();
            txtClave.Text = empleado.Clave.ToString();
            txtClaveRepetida.Text = empleado.Clave.ToString();
            cmbPerfil.Text = empleado.Perfil.Nombre.ToString();
        }

        private void CargarComboTipoDocumento(ComboBox cmbTipoDocumento, List<TipoDocumento> lista)
        {
            cmbTipoDocumento.DataSource = lista;
            cmbTipoDocumento.DisplayMember = "Nombre";
            cmbTipoDocumento.ValueMember = "IdTipoDocumento"; 
            cmbTipoDocumento.SelectedIndex = -1;
        }

        private void txtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);

        }

        private void CargarComboPerfil(ComboBox comboPerfil, List<Perfil> lista)
        {
            comboPerfil.DataSource = lista;
            comboPerfil.DisplayMember = "Nombre";
            comboPerfil.ValueMember = "IdPerfil";
            comboPerfil.SelectedIndex = -1;
        }
    }
}

//ok