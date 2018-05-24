using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Base
{
    public interface IBaseController<T> where T : class
    {
        //Pode colocar qualquer nome ou letra entre os <>, ele só serve para dizer que é uma classe
        void Adicionar(T entity);

        IList<T> ListarTodos();

        IList<T> ListarPorNome(string nome);

        T BuscarPorId(int id);

        void Atualizar(int id, T entity);

        void Excluir(int id);

    }
}
