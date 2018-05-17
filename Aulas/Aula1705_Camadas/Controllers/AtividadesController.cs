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
        
        //Salvar
        public void salvarAtividade(Atividade atividade)
        {
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

        public void editarAtividade(int AtividadeID, Atividade atividadeAtualizada)
        {
            Atividade atividadeAntiga = buscarAtividadePorID(AtividadeID);

            if(atividadeAntiga != null)
            {
                atividadeAntiga.Nome = atividadeAtualizada.Nome;
                atividadeAntiga.Ativo = atividadeAtualizada.Ativo;
            }
        }

    }
}
