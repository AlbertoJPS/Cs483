namespace Cs483.Dados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatetableProduto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Descricao = c.String(),
                        Marca = c.String(),
                        Fabricante = c.String(),
                        Valor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produtoes");
        }
    }
}
