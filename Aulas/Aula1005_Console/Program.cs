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
            Console.WriteLine(cpfCliente);

            Cliente cliente2 = new Cliente("Ketlen", "112.531.739-66");
            Cliente cliente3 = new Cliente("Ricardo");

            Console.WriteLine(cliente2.Nome + " " + cliente2.Cpf);
            Console.WriteLine(cliente3.Nome + " " + cliente3.Cpf);


            Console.ReadKey(); //Comando para pausar
        }
    }
}
