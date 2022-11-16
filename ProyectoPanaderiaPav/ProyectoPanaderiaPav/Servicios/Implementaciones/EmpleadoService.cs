using ProyectoPanaderiaPav.Datos.Daos;
using ProyectoPanaderiaPav.Datos.Interfaces;
using ProyectoPanaderiaPav.Entidades;
using ProyectoPanaderiaPav.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Servicios.Implementaciones
{
    internal class EmpleadoService : IEmpleadoService
    {
        private IEmpleadoDao daoEmpleado;
        public EmpleadoService()
        {
            daoEmpleado = new EmpleadoDao();
        }

        public List<Empleado> traerTodos()
        {
            return daoEmpleado.RecuperarTodos();
        }

        public int existeEmpleado(string nombreEmpleado)
        {
            return daoEmpleado.recuperarEmpleado(nombreEmpleado);
        }

        public int crearEmpleado(Empleado empleado)
        {
            return daoEmpleado.InsertarEmpleado(empleado);
        }

        public int modificarEmpleado(Empleado empleado)
        {
            return daoEmpleado.ModificarEmpleado(empleado);
        }

        public int eliminarEmpleado(Empleado empleado)
        {
            return daoEmpleado.EliminarEmpleado(empleado);
        }

        public List<Empleado> traerFlitrados(string nombreEmpleado, string apellidoEmpleado, string numeroDocumento)
        {
            return daoEmpleado.RecuperarFiltrados(nombreEmpleado, apellidoEmpleado, numeroDocumento);
        }

        public Empleado existeEmpleadoDNI(string dniEmpleado)
        {
            return daoEmpleado.RecuperarEmpleadoDNI(dniEmpleado);
        }

        public bool tieneUsuario(string dniEmpleado)
        {
            return daoEmpleado.TieneUsuario(dniEmpleado);
        }

        public Empleado encontrarEmpleado(string usuario, string clave)
        {
            return daoEmpleado.EncontrarEmpleado(usuario, clave);
        }
    }
}
