namespace TurismoDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipoEstabelecimento",
                c => new
                    {
                        TipoEstabelecimentoId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 250, unicode: false),
                    })
                .PrimaryKey(t => t.TipoEstabelecimentoId);
            
            AddColumn("dbo.Estabelecimento", "Descricacao", c => c.String(maxLength: 100, unicode: false));
            AddColumn("dbo.Estabelecimento", "NomeFotoPerfil", c => c.String(maxLength: 100, unicode: false));
            AddColumn("dbo.Estabelecimento", "TipoEstabelecimentoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Estabelecimento", "TipoEstabelecimentoId");
            AddForeignKey("dbo.Estabelecimento", "TipoEstabelecimentoId", "dbo.TipoEstabelecimento", "TipoEstabelecimentoId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Estabelecimento", "TipoEstabelecimentoId", "dbo.TipoEstabelecimento");
            DropIndex("dbo.Estabelecimento", new[] { "TipoEstabelecimentoId" });
            DropColumn("dbo.Estabelecimento", "TipoEstabelecimentoId");
            DropColumn("dbo.Estabelecimento", "NomeFotoPerfil");
            DropColumn("dbo.Estabelecimento", "Descricacao");
            DropTable("dbo.TipoEstabelecimento");
        }
    }
}
