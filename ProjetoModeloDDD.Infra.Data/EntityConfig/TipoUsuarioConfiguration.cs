using System.Data.Entity.ModelConfiguration;
using TurismoDDD.Domain.Entities;

namespace TurismoDDD.Infra.Data.EntityConfig
{
    public class TipoUsuarioConfiguration : EntityTypeConfiguration<TipoUsuario>
    {
        public TipoUsuarioConfiguration()
        {
            HasKey(c => c.TipoUsuarioId);

            Property(c => c.Descricao)
                .IsRequired();
        }
    }
}
