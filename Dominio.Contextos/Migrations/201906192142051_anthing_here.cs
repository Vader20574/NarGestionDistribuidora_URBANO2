namespace Dominio.Contextos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class anthing_here : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VentaCabFE",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CODEMPRESA = c.String(),
                        CODTIPODOC = c.String(),
                        NRODOCU = c.String(),
                        CODCLIENTE = c.String(),
                        CODDEP = c.String(),
                        FECDOCUM = c.DateTime(nullable: false),
                        CODTIPOPAGO = c.String(),
                        NROGUIA = c.String(),
                        DiaHoraDeCreacion = c.DateTime(nullable: false),
                        UltimaDiaDeEdicion = c.DateTime(nullable: false),
                        FueBorrado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VentaDetFE",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CODEMPRESA = c.String(),
                        CODTIPODOC = c.String(),
                        NRODOCU = c.String(),
                        CODARTI = c.String(),
                        ITEM = c.String(),
                        CODPRES = c.String(),
                        TOTBAS = c.Decimal(nullable: false, precision: 12, scale: 6),
                        MONTODESCBAS = c.Decimal(nullable: false, precision: 12, scale: 6),
                        DiaHoraDeCreacion = c.DateTime(nullable: false),
                        UltimaDiaDeEdicion = c.DateTime(nullable: false),
                        FueBorrado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.VentaDetFE");
            DropTable("dbo.VentaCabFE");
        }
    }
}
