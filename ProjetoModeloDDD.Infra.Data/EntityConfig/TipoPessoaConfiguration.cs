using System.Data.Entity.ModelConfiguration;
using TurismoDDD.Domain.Entities;

namespace TurismoDDD.Infra.Data.EntityConfig
{
    public class TipoPessoaConfiguration : EntityTypeConfiguration<TipoPessoa>
    {
        public TipoPessoaConfiguration()
        {
            HasKey(c => c.TipoPessoaId);

            Property(c => c.Descricao)
                .IsRequired();
        }
    }
}
