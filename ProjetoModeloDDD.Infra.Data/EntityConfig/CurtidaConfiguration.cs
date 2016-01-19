
using System.Data.Entity.ModelConfiguration;
using TurismoDDD.Domain.Entities;

namespace TurismoDDD.Infra.Data.EntityConfig
{
    public class CurtidaConfiguration : EntityTypeConfiguration<Curtida>
    {
        public CurtidaConfiguration()
        {
            HasKey(p => p.CurtidaId);

            //Property(p => p.Usuario.UsuarioId)
            //    .IsRequired();

            //HasRequired(p => p.Usuario)
            //    .WithMany()
            //    .HasForeignKey(p => p.Usuario.UsuarioId);
        }
    }
}
