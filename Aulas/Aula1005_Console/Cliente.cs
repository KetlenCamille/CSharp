﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1005_Console
{
    class Cliente : Pessoa
    {
        public Cliente()
        {

        }

        public Cliente(string nome) : base(nome)
        {
       
        }

        public Cliente(string nome, string cpf) : base(nome,cpf)
        {

        }
    }
}