namespace Revisao.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTablePessoaFisica : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PessoaFisica",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CPF = c.String(),
                        Nome = c.String(),
                        SobreNome = c.String(),
                        Sexo = c.String(),
                        Celular = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PessoaFisica");
        }
    }
}
