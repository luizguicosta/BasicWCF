using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    public class ClienteDAO
    {
        public static List<Cliente> clientes = new List<Cliente>();
        
        public void AddCliente(Cliente c)
        {
            ClienteDAO.clientes.Add(c);
        }

        public Cliente GetCliente(string nome)
        {
            return ClienteDAO.clientes.Where(x => x.Nome.Equals(nome)).FirstOrDefault();
        }
    }
}
