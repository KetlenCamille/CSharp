using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Atividade
    {
        [Key]
        public int AtividadeId { get; set; }

        //Compo obrigatório e tamanho máximo
        [Required, StringLength(30)]
        public string AtividadeNome { get; set; }

        public string AtividadeDescricao { get; set; }

        public bool AtividadeAtivo { get; set; }

        public int CategoriaId { get; set; }

        public int UsuarioId { get; set; }
    }
}
