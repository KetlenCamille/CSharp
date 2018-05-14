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
            carro.Desacelerar();

            Console.WriteLine("Velocidade atual (Carro): " + carro.Velocidade);

            Onibus onibus = new Onibus();
            Console.WriteLine("Velocidade inicial (Onibus): " + onibus.Velocidade);

            onibus.Acelerar();
            onibus.Acelerar();

            onibus.Desacelerar();
            onibus.Desacelerar();
   
            Console.WriteLine("Velocidade atual (Onibus): " + onibus.Velocidade);

            AcelerarBastante(carro);
            Console.WriteLine(carro.ImprimirInfo());

            AcelerarBastante(onibus);
            Console.WriteLine(onibus.ImprimirInfo());
           
            Console.ReadKey();
        }
        //Injeção de dependência
        static void AcelerarBastante(IMeioTransporte meioTransporte)
        {
            for (int i = 0; i < 20; i++)
            {
                meioTransporte.Acelerar();
            }
        }
    }
}
