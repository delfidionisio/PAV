using ProyectoPanaderiaPav.Datos.Interfaces;
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
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPanaderiaPav.Presentación
{
    public partial class frmLogin : Form
    {
        // Atributos formulario login
        private Empleado empleado = new Empleado();
        private IEmpleadoService servicioEmpleado = new EmpleadoService();

        public Empleado Empleado
        {
            get { return empleado; }

        }

        public frmLogin()
        {
            InitializeComponent();
        }
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Validación de "no vacio" en ingreso
            if (string.IsNullOrEmpty(this.txtUsuario.Text))
            {
                MessageBox.Show("Debe ingresar un usuario...");
                this.txtUsuario.Focus();
                return;
            }
            if (this.txtClave.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar una contraseña...");
                this.txtClave.Focus();
                return;
            }

            // Asignar atributos al usuario con los datos cargados
            this.empleado.Usuario = this.txtUsuario.Text;
            this.empleado.Clave = this.txtClave.Text;

            // Cargar atributo ID con lo que devuelve el método encontrar usuario del servicio usuario
            this.empleado = this.servicioEmpleado.encontrarEmpleado(empleado.Usuario, empleado.Clave);

            // Validación de usuario cargado
            if (empleado != null)
            {
                MessageBox.Show("Login OK", "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsuario.Text = "";
                this.txtClave.Text = string.Empty;
                this.txtUsuario.Focus();
                this.empleado = new Empleado();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Método para cerrar el formulario cuando toca el boton salir
            Environment.Exit(0);
        }

    }
}
