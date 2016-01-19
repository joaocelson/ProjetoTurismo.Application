
using System.Data.Entity.ModelConfiguration;
using TurismoDDD.Domain.Entities;

namespace TurismoDDD.Infra.Data.EntityConfig
{
    public class TipoFotoConfiguration : EntityTypeConfiguration<TipoFoto>
    {
        public TipoFotoConfiguration()
        {
            HasKey(p => p.TipoFotoId);

        }
    }
}
