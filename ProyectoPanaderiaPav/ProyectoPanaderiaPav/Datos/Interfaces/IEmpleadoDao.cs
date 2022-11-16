using ProyectoPanaderiaPav.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Datos.Interfaces
{
    internal interface IEmpleadoDao
    {
        List<Empleado> RecuperarTodos();
        List<Empleado> RecuperarFiltrados(string nombreEmpleado, string apellidoEmpleado, string numeroDocumento);
        int InsertarEmpleado(Empleado empleado);
        int recuperarEmpleado(string nombreEmpleado);
        Empleado RecuperarEmpleadoDNI(string dniEmpleado);
        int ModificarEmpleado(Empleado empleado);
        int EliminarEmpleado(Empleado empleado);
        bool TieneUsuario(string dniEmpleado);
        Empleado EncontrarEmpleado(string usuario, string clave);
    }
}
