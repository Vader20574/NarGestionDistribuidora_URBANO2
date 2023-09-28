namespace Dominio.Contextos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creartablaClienteXPromo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClienteXPromo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CODPROMO = c.String(),
                        CODCLIENTE = c.String(),
                        DiaHoraDeCreacion = c.DateTime(nullable: false),
                        UltimaDiaDeEdicion = c.DateTime(nullable: false),
                        FueBorrado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ClienteXPromo");
        }
    }
}
