using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controllers.Base;

namespace Controllers
{
    class UsuarioControllers : IBaseController<Usuario>
    {
        public List<Usuario> ListaUsuarios { get; set; }

        public void Adicionar (Usuario usuario)
        {
            if(usuario != null)
            {
                ListaUsuarios.Add(usuario);
            }
        }

        public Usuario BuscarPorId(int UsuarioId)
        {
            foreach (Usuario usuario in ListaUsuarios)
            {
                if (usuario.UsuarioId == UsuarioId)
                {
                    return usuario;
                }
            }
            return null;
        }

        public void Atualizar(int UsuarioId, Usuario UsuarioAtualizado)
        {
            Usuario UsuarioAntigo = BuscarPorId(UsuarioId);
            
            if(UsuarioAntigo != null)
            {
                UsuarioAntigo.UsuarioNome = UsuarioAtualizado.UsuarioNome;
                UsuarioAntigo.UsuarioAtivo = UsuarioAtualizado.UsuarioAtivo;
            }
        }

        public void Excluir(int UsuarioId)
        {
            foreach (Usuario usuario in ListaUsuarios)
            {
                if(usuario.UsuarioId == UsuarioId)
                {
                    ListaUsuarios.Remove(usuario);
                }
            }
        }

    }
}
