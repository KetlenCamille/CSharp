using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controllers.Base;
using Controllers.DAL;

namespace Controllers
{
    class UsuarioControllers : IBaseController<Usuario>
    {
        public List<Usuario> ListaUsuarios { get; set; }

        Contexto contexto = new Contexto();

        public void Adicionar (Usuario usuario)
        {
            if(usuario != null)
            {
                contexto.Usuarios.Add(usuario);
                contexto.SaveChanges();
            }
        }

        public Usuario BuscarPorId(int UsuarioId)
        {
            return contexto.Usuarios.Find(UsuarioId);
        }

        public void Atualizar(int UsuarioId, Usuario usuario)
        {
            contexto.Entry(usuario).State =
                System.Data.Entity.EntityState.Modified;

            contexto.SaveChanges();
        }

        public void Excluir(int UsuarioId)
        {
            Usuario usuario = BuscarPorId(UsuarioId);
            contexto.Usuarios.Remove(usuario);

            contexto.SaveChanges();
        }

        public IList<Usuario> ListarPorNome(string nome)
        {
            return contexto.Usuarios.Where(a => a.UsuarioNome == nome).ToList();
        }

        IList<Usuario> IBaseController<Usuario>.ListarTodos()
        {
            return contexto.Usuarios.ToList();
        }
    }
}
