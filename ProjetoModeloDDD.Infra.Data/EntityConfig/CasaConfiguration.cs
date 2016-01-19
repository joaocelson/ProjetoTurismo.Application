
using System.Data.Entity.ModelConfiguration;
using TurismoDDD.Domain.Entities;

namespace TurismoDDD.Infra.Data.EntityConfig
{
    public class CasaConfiguration : EntityTypeConfiguration<Casa>
    {
        public CasaConfiguration()
        {
            HasKey(p => p.CasaId);

            Property(p => p.EstabelecimentoId)
                .IsRequired();

            HasRequired(p => p.Usuario)
                .WithMany()
                .HasForeignKey(p => p.UsuarioId);
        }
    }
}
