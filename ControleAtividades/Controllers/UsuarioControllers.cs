using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    class UsuarioControllers
    {
        public List<Usuario> ListaUsuarios { get; set; }

        public void SalvarUsuario (Usuario usuario)
        {
            if(usuario != null)
            {
                ListaUsuarios.Add(usuario);
            }
        }

    }
}
