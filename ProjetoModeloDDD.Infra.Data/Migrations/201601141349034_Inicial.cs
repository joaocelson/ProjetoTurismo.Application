namespace TurismoDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
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
                        PessoaId = c.Int(nullable: false),
                        TipoEstabelecimentoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EstabelecimentoId)
                .ForeignKey("dbo.Pessoa", t => t.PessoaId)
                .ForeignKey("dbo.TipoEstabelecimento", t => t.TipoEstabelecimentoId)
                .Index(t => t.PessoaId)
                .Index(t => t.TipoEstabelecimentoId);
            
            CreateTable(
                "dbo.Pessoa",
                c => new
                    {
                        PessoaId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 150, unicode: false),
                        Sobrenome = c.String(nullable: false, maxLength: 150, unicode: false),
                        Email = c.String(nullable: false, maxLength: 100, unicode: false),
                        DataCadastro = c.DateTime(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PessoaId);
            
            CreateTable(
                "dbo.TipoEstabelecimento",
                c => new
                    {
                        TipoEstabelecimentoId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 250, unicode: false),
                    })
                .PrimaryKey(t => t.TipoEstabelecimentoId);
            
            CreateTable(
                "dbo.TipoPessoa",
                c => new
                    {
                        TipoPessoaId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 100, unicode: false),
                        DataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TipoPessoaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Estabelecimento", "TipoEstabelecimentoId", "dbo.TipoEstabelecimento");
            DropForeignKey("dbo.Estabelecimento", "PessoaId", "dbo.Pessoa");
            DropIndex("dbo.Estabelecimento", new[] { "TipoEstabelecimentoId" });
            DropIndex("dbo.Estabelecimento", new[] { "PessoaId" });
            DropTable("dbo.TipoPessoa");
            DropTable("dbo.TipoEstabelecimento");
            DropTable("dbo.Pessoa");
            DropTable("dbo.Estabelecimento");
        }
    }
}
