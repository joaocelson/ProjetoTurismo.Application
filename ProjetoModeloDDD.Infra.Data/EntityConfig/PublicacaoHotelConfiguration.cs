
using System.Data.Entity.ModelConfiguration;
using TurismoDDD.Domain.Entities;

namespace TurismoDDD.Infra.Data.EntityConfig
{
    public class PublicacaoConfiguration : EntityTypeConfiguration<Publicacao>
    {
        public PublicacaoConfiguration()
        {
            HasKey(p => p.PublicacaoId);

            //Property(p => p.Usuario.UsuarioId)
            //    .IsRequired();

            //HasRequired(p => p.Usuario)
            //    .WithMany()
            //    .HasForeignKey(p => p.Usuario.UsuarioId);
        }
    }
}
