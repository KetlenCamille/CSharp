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
        private static List<Atividade> ListaAtividades { get; set; }

        static int id = 0;

        static AtividadesController()
        {
            ListaAtividades = new List<Atividade>();
        }

        //Salvar
        public void salvarAtividade(Atividade atividade)
        {
            atividade.AtividadeID = ++id;
            //atividade.AtividadeID = ListaAtividades.Count + 1;
            ListaAtividades.Add(atividade);
        }

        //Listar
        public List<Atividade> listarAtividades()
        {
            return ListaAtividades;
        }

        //Buscar
        public Atividade buscarAtividadePorID (int AtividadeID)
        {
            foreach (Atividade atividade in ListaAtividades)
            {
                if(atividade.AtividadeID == AtividadeID)
                {
                    return atividade;
                }
            }
            return null;
        }

        //Editar
        public void editarAtividade(int AtividadeID, Atividade atividadeAtualizada)
        {
            Atividade atividadeAntiga = buscarAtividadePorID(AtividadeID);

            if(atividadeAntiga != null)
            {
                atividadeAntiga.Nome = atividadeAtualizada.Nome;
                atividadeAntiga.Ativo = atividadeAtualizada.Ativo;
            }
        }

        //Excluir
        public void excluirAtividade(int AtividadeID)
        {
            Atividade atividade = buscarAtividadePorID(AtividadeID);

            if(atividade != null)
            {
                ListaAtividades.Remove(atividade);
            }
        }
    }
}
