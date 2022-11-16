using ProyectoPanaderiaPav.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Servicios.Interfaces
{
    internal interface IEmpleadoService
    {
        List<Empleado> traerTodos();
        int existeEmpleado(string nombreEmpleado);
        Empleado existeEmpleadoDNI(string dniEmpleado);
        int crearEmpleado(Empleado empleado);
        int modificarEmpleado(Empleado empleado);
        int eliminarEmpleado(Empleado empleado);
        List<Empleado> traerFlitrados(string nombreEmpleado, string apellidoEmpleado, string numeroDocumento);
        bool tieneUsuario(string dniEmpleado);
        Empleado encontrarEmpleado(string usuario, string clave);
    }
}
