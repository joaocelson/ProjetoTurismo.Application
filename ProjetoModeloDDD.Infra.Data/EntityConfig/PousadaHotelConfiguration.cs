
using System.Data.Entity.ModelConfiguration;
using TurismoDDD.Domain.Entities;

namespace TurismoDDD.Infra.Data.EntityConfig
{
    public class PousadaHotelConfiguration : EntityTypeConfiguration<PousadaHotel>
    {
        public PousadaHotelConfiguration()
        {
            HasKey(p => p.PousadaHotelId);

            //Property(p => p.EstabelecimentoId)
            //    .IsRequired();

            //HasRequired(p => p.Usuario)
            //    .WithMany()
            //    .HasForeignKey(p => p.UsuarioId);
        }
    }
}
