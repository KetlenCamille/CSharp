using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controllers.Base;
using Modelos;

namespace Controllers
{
    class CategoriaControllers : IBaseController<Categoria>
    {
        public static List<Categoria> {get; set;}

        public void Adicionar(Categoria entity)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(int id, Categoria entity)
        {
            throw new NotImplementedException();
        }

        public Categoria BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Categoria> ListarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public IList<Categoria> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
