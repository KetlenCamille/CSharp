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
            ExcluirAtividade = 5,
            BuscarAtividadeNome = 6,
            ListarAtividadesAtivosInativos = 7,
            Sair = 0
        }
        public AtividadesView()
        {
            atividadeController = new AtividadesController();
        }
        public void ExibirMenu()
        {
            OpcoesMenu opcao = OpcoesMenu.Sair;
            do
            {
                Console.Clear();
                Console.WriteLine("======================");
                Console.WriteLine("= Escolha uma opção =");
                Console.WriteLine("= 1) Criar Atividade =");
                Console.WriteLine("= 2) Listar Atividades =");
                Console.WriteLine("= 3) Buscar Atividade por ID=");
                Console.WriteLine("= 4) Editar Atividade =");
                Console.WriteLine("= 5) Excluir Atividade =");
                Console.WriteLine("= 6) Buscar Atividade por Nome =");
                Console.WriteLine("= 7) Listar Atividade (Ativos/Inativos) =");
                Console.WriteLine("= 0) Sair do Sistema =");
                Console.WriteLine("=======================");

                opcao = (OpcoesMenu) int.Parse(Console.ReadLine());
                //return opcao;

                switch (opcao)
                {
                    case OpcoesMenu.CriarAtividade:
                        criarAtividade();
                        break;
                    case OpcoesMenu.ListarAtividades:
                        listarAtividades();
                        break;
                    case OpcoesMenu.BuscarAtividades:
                        buscarAtividades();
                        break;
                    case OpcoesMenu.EditarAtividade:
                        editarAtividade();
                        break;
                    case OpcoesMenu.ExcluirAtividade:
                        excluirAtividade();
                        break;
                    case OpcoesMenu.BuscarAtividadeNome:
                        buscarAtividadesPorNome();
                        break;
                    case OpcoesMenu.ListarAtividadesAtivosInativos:
                        listarAtividadesAtivosInativos();
                        break;
                    case OpcoesMenu.Sair:
                        break;
                    default:
                        Console.WriteLine("OPÇÃO INVÁLIDA! Digite qualquer tecla para continuar");
                        Console.ReadKey();
                        break;
                }
                /*
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
                }*/
            } while (opcao != OpcoesMenu.Sair);
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

            Console.WriteLine("Ativo? (S/N)");
            atividade.Ativo = Console.ReadLine() == "S" ? true : false;

            //string i = Console.ReadLine() == "ok" ? "acertou" : "errou";
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

        public void buscarAtividadesPorNome()
        {
            Console.WriteLine("Digite o nome da atividade");
            string atividadeNome = Console.ReadLine();

            Atividade atividade = atividadeController.buscarAtividadePorNome(atividadeNome);
            if(atividade != null)
            {
                exibirDetalhesAtividade(atividade);
            }
            else
            {
                Console.WriteLine("Atividade não encontrada!");
            }
            Console.ReadKey();
        }
        public void listarAtividadesAtivosInativos()
        {
            Console.WriteLine("Deseja listar: 1 - Atividades Ativas");
            Console.WriteLine("Deseja listar: 2 - Atividades Inativas");

            bool op = Console.ReadLine() == "1" ? true : false;

            foreach (Atividade atividade in atividadeController.listarAtividades())
            {
                if(atividade.Ativo == op)
                {
                    exibirDetalhesAtividade(atividade);
                }
            }
            Console.WriteLine("Fim da Lista");
            Console.ReadKey();
        }
    }
}
