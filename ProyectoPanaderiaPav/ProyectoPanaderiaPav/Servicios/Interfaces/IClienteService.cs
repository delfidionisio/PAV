using ProyectoPanaderiaPav.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Servicios.Interfaces
{
    internal interface IClienteService
    {
        List<Cliente> traerFiltrados(string nombreCliente, string apellidoCliente, string numeroDocumento);
        List<Cliente> traerTodos();
        int existeCliente(string nombreCliente);
        int crearCliente(Cliente cliente);
        int modificarCliente(Cliente cliente);
        int eliminarCliente(Cliente cliente);
        Cliente traerCliente(string dni);
        DataTable traerDatosReporteClientes();
    }
}
