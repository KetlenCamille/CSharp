using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1005_Console
{
    class Cliente
    {
        //Atributo
        private string nome;

        //Propriedade
        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }
        //Atributo e Propriedade junto
        public string Cpf { get; set; }
    }
}
