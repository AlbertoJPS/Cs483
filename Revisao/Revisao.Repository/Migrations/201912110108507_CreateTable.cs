namespace Revisao.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.PessoaFisica", newName: "Pessoa");
            AddColumn("dbo.Pessoa", "CNPJ", c => c.String());
            AddColumn("dbo.Pessoa", "NomeFantasia", c => c.String());
            AddColumn("dbo.Pessoa", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropTable("dbo.PessoaJuridica");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PessoaJuridica",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CNPJ = c.String(),
                        NomeFantasia = c.String(),
                        Nome = c.String(),
                        SobreNome = c.String(),
                        Sexo = c.String(),
                        Celular = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Pessoa", "Discriminator");
            DropColumn("dbo.Pessoa", "NomeFantasia");
            DropColumn("dbo.Pessoa", "CNPJ");
            RenameTable(name: "dbo.Pessoa", newName: "PessoaFisica");
        }
    }
}
