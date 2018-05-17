using Aula1705_Camadas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1705_Camadas.Controllers
{
    class AtividadesController
    {
        public List<Atividade> ListaAtividades { get; set; }

        public void salvarAtividade(Atividade atividade)
        {
            ListaAtividades.Add(atividade);
        }

        public List<Atividade> listarAtividades()
        {
            return ListaAtividades;
        }

    }
}
