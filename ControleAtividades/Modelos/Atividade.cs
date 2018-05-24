namespace Modelos
{
    public class Atividade
    {
        public int AtividadeId { get; set; }

        public string AtividadeNome { get; set; }

        public string AtividadeDescricao { get; set; }

        public bool AtividadeAtivo { get; set; }

        public int CategoriaId { get; set; }

        public int UsuarioId { get; set; }
    }
}
