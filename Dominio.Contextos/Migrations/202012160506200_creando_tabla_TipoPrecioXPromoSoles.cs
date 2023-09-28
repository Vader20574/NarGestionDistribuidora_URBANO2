namespace Dominio.Contextos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creando_tabla_TipoPrecioXPromoSoles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipoPrecioXPromoSoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CODEMPRESA = c.String(),
                        CODARTI = c.String(),
                        DESARTI = c.String(),
                        CODTIPOPRE = c.String(),
                        DSTIPOPRE = c.String(),
                        CODIGO = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TipoPrecioXPromoSoles");
        }
    }
}
