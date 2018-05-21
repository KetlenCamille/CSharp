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
        AtividadesController atividadeController;

        enum OpcoesMenu
        {
            CriarAtividade = 1,
            ListarAtividades = 2,
            BuscarAtividades = 3,
            EditarAtividade = 4,
            ExcluirAtividade = 5
        }
        public AtividadesView()
        {
            atividadeController = new AtividadesController();
        }
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
                        buscarAtividades();
                        break;
                    case 4:
                        editarAtividade();
                        break;
                    case 5:
                        excluirAtividade();
                        break;
                    default:
                        break;
                }
            } while (opcao != 0);
       }
            

        public void criarAtividade()
        {
            Atividade atividade = obterDadosAtividade();

            atividadeController.salvarAtividade(atividade);
        }

        private static Atividade obterDadosAtividade()
        {
            Atividade atividade = new Atividade();
            Console.Write("Digiste o nome da atividade: ");
            atividade.Nome = Console.ReadLine();

            atividade.Ativo = true;
            return atividade;
        }

        public void listarAtividades()
        {
            //Cópia da lista (para evitar problemas)
            foreach (Atividade atividade in atividadeController.listarAtividades())
            {
                exibirDetalhesAtividade(atividade);
            }
            Console.WriteLine("Fim da Lista");
            Console.ReadKey();
        }

        private static void exibirDetalhesAtividade(Atividade atividade)
        {
            Console.WriteLine("----");
            Console.WriteLine("Id: " + atividade.AtividadeID);
            Console.WriteLine("Nome: " + atividade.Nome);
            Console.WriteLine("Ativo: " + atividade.Ativo);
            Console.WriteLine("----");
        }

        public void buscarAtividades()
        {
            AtividadesController atividadeController = new AtividadesController();
            Console.WriteLine("Digite o id da atividade");
            int id = int.Parse(Console.ReadLine());

            Atividade atividade = atividadeController.buscarAtividadePorID(id);
            if(atividade != null)
            {
                exibirDetalhesAtividade(atividade);
            }
            else
            {
                Console.WriteLine("Atividade não encontrada");
            }
            Console.ReadKey();
        }

       public void editarAtividade()
        {
            listarAtividades();

            Console.Write("Digite o ID da atividade que deseja editar: ");
            int idAtividade = int.Parse(Console.ReadLine());

            Atividade atividadeAtualizada = obterDadosAtividade();

            atividadeController.editarAtividade(idAtividade, atividadeAtualizada);
        }

        public void excluirAtividade()
        {
            listarAtividades();

            Console.Write("Digite o ID da atividade que deseja excluir: ");
            int idAtividade = int.Parse(Console.ReadLine());


            atividadeController.excluirAtividade(idAtividade);
        }
    }
}
