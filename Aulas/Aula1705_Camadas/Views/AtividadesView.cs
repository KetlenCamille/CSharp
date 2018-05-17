using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aula1705_Camadas.Models;
using System.Threading.Tasks;
using Aula1705_Camadas.Controllers;

namespace Aula1705_Camadas.Views
{
    class AtividadesView
    {
        public int ExibirMenu()
        {
            Console.WriteLine("====================");
            Console.WriteLine("== Escolha uma opção ==");
            Console.WriteLine("= 1) Criar Atividade =");
            Console.WriteLine("= 2) Listar Atividades =");
            Console.WriteLine("= 3) Buscar Atividade =");
            Console.WriteLine("= 4) Editar Atividade =");
            Console.WriteLine("= 5) Excluir Atividade =");
            Console.WriteLine("====================");

            int opcao = int.Parse(Console.ReadLine());
            return opcao;
        }

        public void criarAtividade()
        {
            Atividade atividade = new Atividade();
            Console.Write("Digiste o nome da atividade: ");
            atividade.Nome = Console.ReadLine();

            atividade.Ativo = true;

            AtividadesController atividadeController = new AtividadesController();
            atividadeController.salvarAtividade(atividade);
        }
    }
}
