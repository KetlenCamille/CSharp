using Controllers.Base;
using Controllers.DAL;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class AtividadeControllers : IBaseController<Atividade>
    {
        private Contexto contexto = new Contexto();

        public void Adicionar(Atividade atividade)
        {
            if (atividade != null)
            {
                contexto.Atividades.Add(atividade);
                contexto.SaveChanges();
            }
        }

        public void Atualizar(int id, Atividade entity)
        {
            throw new NotImplementedException();
        }

        public Atividade BuscarPorId(int id)
        {
            return contexto.Atividades.Find(id);
        }

        public void Excluir(int idAtividade)
        {
            Atividade atividade = BuscarPorId(idAtividade);
            if(atividade != null)
            {
                contexto.Atividades.Remove(atividade);
            }
        }

        public IList<Atividade> ListarPorNome(string nome)
        {
            /* LINQ
            var atividadesComNome = from atividade in contexto.Atividades
                        where atividade.AtividadeNome == nome
                        select atividade;

            return atividadesComNome.ToList();
            */

            // LAMBDA

            return contexto.Atividades.Where(a => a.AtividadeNome == nome).ToList();
        }

        public IList<Atividade> ListarTodos()
        {
            return contexto.Atividades.ToList();
        }
    }
}
