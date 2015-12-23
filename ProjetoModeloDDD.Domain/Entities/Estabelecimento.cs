
namespace TurismoDDD.Domain.Entities
{
    public class Estabelecimento
    {
        public int EstabelecimentoId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Disponivel { get; set; }
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
