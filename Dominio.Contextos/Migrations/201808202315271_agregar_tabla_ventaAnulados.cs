namespace Dominio.Contextos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregar_tabla_ventaAnulados : DbMigration
    {
        public override void Up()
        {

            CreateTable(
                "dbo.VentaAnulados",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CODTIPODOC = c.String(),
                        NRODOCU = c.String(),
                        DiaHoraDeCreacion = c.DateTime(nullable: false),
                        UltimaDiaDeEdicion = c.DateTime(nullable: false),
                        FueBorrado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.VentaAnulados");
            DropTable("dbo.HDocumento");
            DropTable("dbo.DDocumento");
        }
    }
}
