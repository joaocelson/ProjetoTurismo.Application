
using System.Data.Entity.ModelConfiguration;
using TurismoDDD.Domain.Entities;

namespace TurismoDDD.Infra.Data.EntityConfig
{
    public class TipoEstabelecimentoConfiguration : EntityTypeConfiguration<TipoEstabelecimento>
    {
        public TipoEstabelecimentoConfiguration()
        {
            HasKey(p => p.TipoEstabelecimentoId);

            Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(250);
        }
    }
}
