using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1005_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = "Godofredo"; //Set
            string nomeCliente = cliente.Nome; //Get

            cliente.Cpf = "111.222.333-44"; //Set
            string cpfCliente = cliente.Cpf; //Get

            Console.WriteLine(nomeCliente);
        }
    }
}
