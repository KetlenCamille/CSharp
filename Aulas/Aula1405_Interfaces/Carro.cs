﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1405_Interfaces
{
    class Carro : IMeioTransporte
    {
        public int Velocidade { get; set; }

        public string Modelo { get; set; }

        //Chave para objeto Marca
        public int idMarca { get; set; }

        //Propriedade de navegação
        public virtual Marca _Marca { get; set; }

        public List<Roda> Rodas { get; set; }

        public Carro()
        {
            Velocidade = 0;
        }
        public void Acelerar()
        {
            Velocidade += 10;
        }

        public void Desacelerar()
        {
                Velocidade -= 5;
        }

        public string ImprimirInfo()
        {
            return "Carro (velocidade atual): " + Velocidade;
        }

        string IMeioTransporte.Modelo()
        {
            throw new NotImplementedException();
        }
    }
}
