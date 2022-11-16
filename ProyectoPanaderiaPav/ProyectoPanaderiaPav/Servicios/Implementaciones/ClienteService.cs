using ProyectoPanaderiaPav.Datos.Daos;
using ProyectoPanaderiaPav.Datos.Interfaces;
using ProyectoPanaderiaPav.Entidades;
using ProyectoPanaderiaPav.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPanaderiaPav.Servicios.Implementaciones
{
    internal class ClienteService : IClienteService
    {
        private IClienteDao daoCliente;
        public ClienteService()
        {
            daoCliente = new ClienteDao();
        }

        public List<Cliente> traerTodos()
        {
            return daoCliente.RecuperarTodos();
        }

        public List<Cliente> traerFiltrados(string nombreCliente, string apellidoCliente, string numeroDocumento)
        {
            return daoCliente.RecuperarFiltrados(nombreCliente, apellidoCliente, numeroDocumento);   
        }

        public int existeCliente(string nombreCliente)
        {
            return daoCliente.recuperarCliente(nombreCliente);
        }

        public int crearCliente(Cliente cliente)
        {
            return daoCliente.InsertarCliente(cliente);
        }

        public int modificarCliente(Cliente cliente)
        {
            return daoCliente.ModificarCliente(cliente);
        }

        public int eliminarCliente(Cliente cliente)
        {
            return daoCliente.EliminarCliente(cliente);
        }

        public Cliente traerCliente(string dni)
        {
            return daoCliente.RecuperarClienteDni(dni);
        }

        public DataTable traerDatosReporteClientes()
        {
            return daoCliente.RecuperarDatosReporteClientes();
        }
    }
}
