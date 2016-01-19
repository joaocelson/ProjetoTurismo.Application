
using System.Data.Entity.ModelConfiguration;
using TurismoDDD.Domain.Entities;

namespace TurismoDDD.Infra.Data.EntityConfig
{
    public class ChaleConfiguration : EntityTypeConfiguration<Chale>
    {
        public ChaleConfiguration()
        {
            HasKey(p => p.ChaleId);

            Property(p => p.EstabelecimentoId)
                .IsRequired();

            HasRequired(p => p.Usuario)
                .WithMany()
                .HasForeignKey(p => p.UsuarioId);
        }
    }
}
