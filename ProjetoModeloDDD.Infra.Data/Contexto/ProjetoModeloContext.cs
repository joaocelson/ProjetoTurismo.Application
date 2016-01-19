using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Infra.Data.EntityConfig;

namespace TurismoDDD.Infra.Data.Contexto
{
    public class ProjetoModeloContext : DbContext
    {
        public ProjetoModeloContext()
            : base("TurismoDDD")
        {

        }

        public DbSet<Casa> Casas { get; set; }
        public DbSet<Chale> Chales { get; set; }
        public DbSet<Curtida> Curtidas { get; set; }
        public DbSet<Estabelecimento> Estabelecimentos { get; set; }
        public DbSet<Foto> Fotos { get; set; }
        public DbSet<PousadaHotel> PousadaHoteis { get; set; }
        public DbSet<Publicacao> Publicacoes { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<TipoFoto> TipoFotos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public DbSet<TipoEstabelecimento> TipoEstabelecimentos { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new CasaConfiguration());
            modelBuilder.Configurations.Add(new ChaleConfiguration());
            modelBuilder.Configurations.Add(new CurtidaConfiguration());
            modelBuilder.Configurations.Add(new EstabelecimentoConfiguration());
            modelBuilder.Configurations.Add(new FotoConfiguration());
            modelBuilder.Configurations.Add(new PousadaHotelConfiguration());
            modelBuilder.Configurations.Add(new PublicacaoConfiguration());
            modelBuilder.Configurations.Add(new TelefoneConfiguration());
            modelBuilder.Configurations.Add(new TipoFotoConfiguration());
            modelBuilder.Configurations.Add(new TipoEstabelecimentoConfiguration());
            modelBuilder.Configurations.Add(new TipoUsuarioConfiguration());
            modelBuilder.Configurations.Add(new UsuarioConfiguration());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }



    }
}
