using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Passagens;
using System.ServiceModel.Description;

namespace Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando o host para subir o serviço
            ServiceHost host = new ServiceHost(typeof(ClienteService));
            Uri endereco = new Uri("http://localhost:8080/Cliente");
            host.AddServiceEndpoint(typeof(IClienteService), new BasicHttpBinding(), endereco);
            try
            {
                host.Open();
                ExibirIformacoesServico(host); 
                Console.ReadKey();
                host.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro : "+ ex.Message);
                Console.ReadKey();
            }
        }
        /// <summary>
        /// Exibição das informações do serviço
        /// </summary>
        /// <param name="serviceHost">host do serviço</param>
        private static void ExibirIformacoesServico(ServiceHost serviceHost)
        {
            Console.WriteLine("{0} online ", serviceHost.Description.ServiceType);
            foreach (ServiceEndpoint endPoints in serviceHost.Description.Endpoints)
            {
                Console.WriteLine(endPoints.Address);
            }
        }
    }
}
