using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class ClienteBLL
    {
        private ClienteDAL clienteDAL;

        public ClienteBLL()
        {
           clienteDAL = new ClienteDAL();
        }

        public Cliente ConsultarCliente(int telefone)
        {
         
            return  clienteDAL.ConsultarCliente(telefone);
        }

        public List<Cliente> MostrarCliente()
        {
            return clienteDAL.MostrarCliente();
        }

        public int IncluirCliente(Cliente cliente)
        {
            return clienteDAL.IncluirCliente(cliente);
        }

        public void AtualizarCliente(Cliente cliente)
        {
            clienteDAL.AtualizarCliente(cliente);
        }

        public void ExcluirCliente(int codigo)
         {
             clienteDAL.ExcluirCliente(codigo);
         }

        

    }
}
