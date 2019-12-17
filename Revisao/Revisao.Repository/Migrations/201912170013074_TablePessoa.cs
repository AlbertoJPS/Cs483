namespace Revisao.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablePessoa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pessoa",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        CPF = c.String(),
                        CNPJ = c.String(),
                        NomeFantasia = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pessoa");
        }
    }
}
