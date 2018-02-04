using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    public class ClienteService : IClienteService
    {
        public void Add(Cliente c)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            clienteDAO.AddCliente(c);
        }

        public Cliente Get(string nome)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            return clienteDAO.GetCliente(nome);
        }
    }
}
