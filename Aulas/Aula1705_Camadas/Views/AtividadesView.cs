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
        public void ExibirMenu()
        {
            int opcao;
            do
            {
                Console.WriteLine("======================");
                Console.WriteLine("= Escolha uma opção =");
                Console.WriteLine("= 1) Criar Atividade =");
                Console.WriteLine("= 2) Listar Atividades =");
                Console.WriteLine("= 3) Buscar Atividade =");
                Console.WriteLine("= 4) Editar Atividade =");
                Console.WriteLine("= 5) Excluir Atividade =");
                Console.WriteLine("= 0) Sair do Sistema =");
                Console.WriteLine("=======================");

                opcao = int.Parse(Console.ReadLine());
                //return opcao;
                switch (opcao)
                {
                    case 1:
                        criarAtividade();
                        break;
                    case 2:
                        listarAtividades();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    default:
                        break;
                }
            } while (opcao != 0);
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
        
        public void listarAtividades()
        {
            AtividadesController atividadeController = new AtividadesController();
            //Cópia da lista (para evitar problemas)
            foreach (Atividade atividade in atividadeController.listarAtividades())
            {
                Console.WriteLine("----");
                Console.WriteLine("Id: " + atividade.AtividadeID);
                Console.WriteLine("Nome: " + atividade.Nome);
                Console.WriteLine("Ativo: " + atividade.Ativo);
                Console.WriteLine("----");
            }
            Console.WriteLine("Fim da Lista");
            Console.ReadKey();
        }
    }
}
