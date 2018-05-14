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

            CriarRelacionamentos();
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

        static void CriarRelacionamentos()
        {
            Carro c = new Carro();
            c.Modelo = "Corsa";

            Marca m = new Marca();
            m.Nome = "Chevrolet";
            //Atribuindo marca
            c._Marca = m;

            //Criando e armazenando rodas
            c.Rodas = new List<Roda>();
            Roda r1 = new Roda();
            c.Rodas.Add(r1);
           
            for(int i = 0; i < 3; i++)
            {
                c.Rodas.Add(new Roda());
            }

            Console.WriteLine("Qtde rodas: " + c.Rodas.Count);


            Onibus o = new Onibus();
            o.Modelo = "3100";

            o._Marca = m;
        }
    }
}
