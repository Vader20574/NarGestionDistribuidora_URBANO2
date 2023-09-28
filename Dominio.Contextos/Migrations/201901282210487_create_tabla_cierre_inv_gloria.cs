namespace Dominio.Contextos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_tabla_cierre_inv_gloria : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cierre_Inv_Gloria",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AÑO = c.String(),
                        MES = c.String(),
                        ARTICULO = c.String(),
                        STOCK = c.Int(nullable: false),
                        ALMACEN = c.String(),
                        FECHA = c.DateTime(nullable: false),
                        DiaHoraDeCreacion = c.DateTime(nullable: false),
                        UltimaDiaDeEdicion = c.DateTime(nullable: false),
                        FueBorrado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cierre_Inv_Gloria");
        }
    }
}
