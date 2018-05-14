using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1405_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            Console.WriteLine("Velocidade inicial (Carro): " + carro.Velocidade);

            carro.Acelerar();
            carro.Acelerar();
            carro.Desacelerar();

            Console.WriteLine("Velocidade atual (Carro): " + carro.Velocidade);

            Onibus onibus = new Onibus();
            Console.WriteLine("Velocidade inicial (Onibus): " + onibus.Velocidade);

            onibus.Acelerar();
            onibus.Acelerar();

            onibus.Desacelerar();
            onibus.Desacelerar();
   
            Console.WriteLine("Velocidade atual (Onibus): " + onibus.Velocidade);

            Console.ReadKey();
        }
    }
}
