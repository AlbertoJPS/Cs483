namespace Cs483.Dados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableClasseTipo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClasseTipoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ClasseTipoes");
        }
    }
}
