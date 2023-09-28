namespace Dominio.Contextos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creando_TipoPrecioXPromoSubCatSoles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipoPrecioXPromoSubCatSoles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CODEMPRESA = c.String(),
                        CODPROMO = c.String(),
                        CODTIPOPRE = c.String(),
                        DSTIPOPRE = c.String(),
                        CODIGO = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TipoPrecioXPromoSubCatSoles");
        }
    }
}
