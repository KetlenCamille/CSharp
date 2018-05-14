using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1005_Console
{
    class Cliente : Pessoa
    {
        public DateTime DataNascimento { get; set; }

        public string DataQueNasce
        {
            get
            {
                return DataNascimento.ToShortDateString();
            }
        }

        public int Idade
        {
            get
            {
                DateTime hoje = DateTime.Today;
               int idade = hoje.Year - DataNascimento.Year;
                return idade;
                //return DateTime.Today.Year - DataNascimento.Year;
            }
        }

        public Cliente() {

        }

        public Cliente(string nome) : base(nome) {
        }

        public Cliente(string nome, string cpf) : base(nome,cpf) {

        }
        override
            public string imprimirInfo()
        {
            return nome + ", " + cpf + ", " + DataNascimento.ToShortDateString() + ", " + Idade;
        }
    }
}
