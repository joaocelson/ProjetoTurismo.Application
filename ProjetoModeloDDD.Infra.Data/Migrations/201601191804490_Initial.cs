namespace TurismoDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Estabelecimento",
                c => new
                    {
                        EstabelecimentoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 250, unicode: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Disponivel = c.Boolean(nullable: false),
                        Descricacao = c.String(maxLength: 100, unicode: false),
                        NomeFotoPerfil = c.String(maxLength: 100, unicode: false),
                        UsuarioId = c.Int(nullable: false),
                        TipoEstabelecimentoId = c.Int(nullable: false),
                        ChaleId = c.Int(),
                        NumeroQuartos = c.Int(),
                        NumeroVagasGaragem = c.Int(),
                        NumeroPessoas = c.Int(),
                        PousadaHotelId = c.Int(),
                        NumeroQuartos1 = c.Int(),
                        NumeroVagasGaragem1 = c.Int(),
                        NumeroPessoas1 = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        estabelecimento_EstabelecimentoId = c.Int(),
                        estabelecimento_EstabelecimentoId1 = c.Int(),
                    })
                .PrimaryKey(t => t.EstabelecimentoId)
                .ForeignKey("dbo.TipoEstabelecimento", t => t.TipoEstabelecimentoId)
                .ForeignKey("dbo.Usuario", t => t.UsuarioId)
                .ForeignKey("dbo.Estabelecimento", t => t.estabelecimento_EstabelecimentoId)
                .ForeignKey("dbo.Estabelecimento", t => t.estabelecimento_EstabelecimentoId1)
                .Index(t => t.UsuarioId)
                .Index(t => t.TipoEstabelecimentoId)
                .Index(t => t.estabelecimento_EstabelecimentoId)
                .Index(t => t.estabelecimento_EstabelecimentoId1);
            
            CreateTable(
                "dbo.TipoEstabelecimento",
                c => new
                    {
                        TipoEstabelecimentoId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 250, unicode: false),
                    })
                .PrimaryKey(t => t.TipoEstabelecimentoId);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 150, unicode: false),
                        Email = c.String(nullable: false, maxLength: 100, unicode: false),
                        Password = c.String(maxLength: 100, unicode: false),
                        DataCadastro = c.DateTime(nullable: false),
                        DataInativacao = c.DateTime(nullable: false),
                        FotoPerfilId_FotoId = c.Int(),
                    })
                .PrimaryKey(t => t.UsuarioId)
                .ForeignKey("dbo.Foto", t => t.FotoPerfilId_FotoId)
                .Index(t => t.FotoPerfilId_FotoId);
            
            CreateTable(
                "dbo.Foto",
                c => new
                    {
                        FotoId = c.Int(nullable: false, identity: true),
                        NomeFoto = c.Int(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        DataInativacao = c.DateTime(nullable: false),
                        TipoFotoId_TipoFotoId = c.Int(),
                        Publicacao_PublicacaoId = c.Int(),
                    })
                .PrimaryKey(t => t.FotoId)
                .ForeignKey("dbo.TipoFoto", t => t.TipoFotoId_TipoFotoId)
                .ForeignKey("dbo.Publicacao", t => t.Publicacao_PublicacaoId)
                .Index(t => t.TipoFotoId_TipoFotoId)
                .Index(t => t.Publicacao_PublicacaoId);
            
            CreateTable(
                "dbo.TipoFoto",
                c => new
                    {
                        TipoFotoId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 100, unicode: false),
                        DataInativacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TipoFotoId);
            
            CreateTable(
                "dbo.Curtida",
                c => new
                    {
                        CurtidaId = c.Int(nullable: false, identity: true),
                        DataInativacao = c.DateTime(nullable: false),
                        DataCurtida = c.DateTime(nullable: false),
                        Publicacao_PublicacaoId = c.Int(),
                        Usuario_UsuarioId = c.Int(),
                    })
                .PrimaryKey(t => t.CurtidaId)
                .ForeignKey("dbo.Publicacao", t => t.Publicacao_PublicacaoId)
                .ForeignKey("dbo.Usuario", t => t.Usuario_UsuarioId)
                .Index(t => t.Publicacao_PublicacaoId)
                .Index(t => t.Usuario_UsuarioId);
            
            CreateTable(
                "dbo.Publicacao",
                c => new
                    {
                        PublicacaoId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 100, unicode: false),
                        DataInativacao = c.DateTime(nullable: false),
                        DataPublicacao = c.DateTime(nullable: false),
                        Usuario_UsuarioId = c.Int(),
                    })
                .PrimaryKey(t => t.PublicacaoId)
                .ForeignKey("dbo.Usuario", t => t.Usuario_UsuarioId)
                .Index(t => t.Usuario_UsuarioId);
            
            CreateTable(
                "dbo.Telefone",
                c => new
                    {
                        TelefoneId = c.Int(nullable: false, identity: true),
                        NumeroTelefone = c.String(maxLength: 100, unicode: false),
                        DataInativacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TelefoneId);
            
            CreateTable(
                "dbo.TipoUsuario",
                c => new
                    {
                        TipoUsuarioId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 100, unicode: false),
                        DataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TipoUsuarioId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Curtida", "Usuario_UsuarioId", "dbo.Usuario");
            DropForeignKey("dbo.Publicacao", "Usuario_UsuarioId", "dbo.Usuario");
            DropForeignKey("dbo.Foto", "Publicacao_PublicacaoId", "dbo.Publicacao");
            DropForeignKey("dbo.Curtida", "Publicacao_PublicacaoId", "dbo.Publicacao");
            DropForeignKey("dbo.Estabelecimento", "estabelecimento_EstabelecimentoId1", "dbo.Estabelecimento");
            DropForeignKey("dbo.Estabelecimento", "estabelecimento_EstabelecimentoId", "dbo.Estabelecimento");
            DropForeignKey("dbo.Estabelecimento", "UsuarioId", "dbo.Usuario");
            DropForeignKey("dbo.Estabelecimento", "TipoEstabelecimentoId", "dbo.TipoEstabelecimento");
            DropForeignKey("dbo.Usuario", "FotoPerfilId_FotoId", "dbo.Foto");
            DropForeignKey("dbo.Foto", "TipoFotoId_TipoFotoId", "dbo.TipoFoto");
            DropIndex("dbo.Publicacao", new[] { "Usuario_UsuarioId" });
            DropIndex("dbo.Curtida", new[] { "Usuario_UsuarioId" });
            DropIndex("dbo.Curtida", new[] { "Publicacao_PublicacaoId" });
            DropIndex("dbo.Foto", new[] { "Publicacao_PublicacaoId" });
            DropIndex("dbo.Foto", new[] { "TipoFotoId_TipoFotoId" });
            DropIndex("dbo.Usuario", new[] { "FotoPerfilId_FotoId" });
            DropIndex("dbo.Estabelecimento", new[] { "estabelecimento_EstabelecimentoId1" });
            DropIndex("dbo.Estabelecimento", new[] { "estabelecimento_EstabelecimentoId" });
            DropIndex("dbo.Estabelecimento", new[] { "TipoEstabelecimentoId" });
            DropIndex("dbo.Estabelecimento", new[] { "UsuarioId" });
            DropTable("dbo.TipoUsuario");
            DropTable("dbo.Telefone");
            DropTable("dbo.Publicacao");
            DropTable("dbo.Curtida");
            DropTable("dbo.TipoFoto");
            DropTable("dbo.Foto");
            DropTable("dbo.Usuario");
            DropTable("dbo.TipoEstabelecimento");
            DropTable("dbo.Estabelecimento");
        }
    }
}
