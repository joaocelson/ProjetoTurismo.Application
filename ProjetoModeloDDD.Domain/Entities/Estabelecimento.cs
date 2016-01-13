
namespace TurismoDDD.Domain.Entities
{
    public class Estabelecimento
    {
        public int EstabelecimentoId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Disponivel { get; set; }
        public string Descricacao { get; set; }
        public string NomeFotoPerfil { get; set; }

        public int PessoaId { get; set; }
        public int TipoEstabelecimentoId { get; set; }

        public virtual TipoEstabelecimento TipoEstabelecimento { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
