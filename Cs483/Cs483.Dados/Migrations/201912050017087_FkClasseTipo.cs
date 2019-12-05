namespace Cs483.Dados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FkClasseTipo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produtoes", "Tipo_Id", c => c.Int());
            CreateIndex("dbo.Produtoes", "Tipo_Id");
            AddForeignKey("dbo.Produtoes", "Tipo_Id", "dbo.ClasseTipoes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produtoes", "Tipo_Id", "dbo.ClasseTipoes");
            DropIndex("dbo.Produtoes", new[] { "Tipo_Id" });
            DropColumn("dbo.Produtoes", "Tipo_Id");
        }
    }
}
