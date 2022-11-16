using ProyectoPanaderiaPav.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Datos.Interfaces
{
    internal interface IClienteDao
    {
        List<Cliente> RecuperarTodos();
        List<Cliente> RecuperarFiltrados(string nombreCliente, string apellidoClinte, string numeroDocumento);
        int recuperarCliente(string nombreCliente);
        int InsertarCliente(Cliente cliente);
        int ModificarCliente(Cliente cliente);
        int EliminarCliente(Cliente cliente);
        Cliente RecuperarClienteDni(string dni);
        DataTable RecuperarDatosReporteClientes();
    }
}
