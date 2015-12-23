
using System.Data.Entity.ModelConfiguration;
using TurismoDDD.Domain.Entities;

namespace TurismoDDD.Infra.Data.EntityConfig
{
    public class EstabelecimentoConfiguration : EntityTypeConfiguration<Estabelecimento>
    {
        public EstabelecimentoConfiguration()
        {
            HasKey(p => p.EstabelecimentoId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(250);

            Property(p => p.Valor)
                .IsRequired();

            HasRequired(p => p.Pessoa)
                .WithMany()
                .HasForeignKey(p => p.PessoaId);
        }
    }
}
