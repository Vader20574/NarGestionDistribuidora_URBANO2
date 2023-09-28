namespace Dominio.Contextos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creandotablaSupervisorySupervisorVendedor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Supervisor",
                c => new
                    {
                        Codsuperv = c.String(nullable: false, maxLength: 128),
                        Codempresa = c.String(),
                        Dssuperv = c.String(),
                        Direccion = c.String(),
                        nrofac = c.Decimal(nullable: false, precision: 18, scale: 6),
                        nrobol = c.Decimal(nullable: false, precision: 18, scale: 6),
                        nroped = c.Decimal(nullable: false, precision: 18, scale: 6),
                        nrofacRef = c.Decimal(nullable: false, precision: 18, scale: 6),
                        nrobolRef = c.Decimal(nullable: false, precision: 18, scale: 6),
                        nropedRef = c.Decimal(nullable: false, precision: 18, scale: 6),
                        EDESE = c.Boolean(nullable: false),
                        GIEF = c.Boolean(nullable: false),
                        GIEB = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Codsuperv);
            
            CreateTable(
                "dbo.SupervisorVendedor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codempresa = c.String(),
                        Codsupervisor = c.String(maxLength: 128),
                        Codvendedor = c.String(),
                        Dsvend = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Supervisor", t => t.Codsupervisor)
                .Index(t => t.Codsupervisor);
            
            AlterColumn("dbo.CDocumento", "monto_cuota", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AlterColumn("dbo.DDocumento", "prod_precio", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AlterColumn("dbo.DDocumento", "prod_desct", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AlterColumn("dbo.DDocumento", "prod_cant", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AlterColumn("dbo.DDocumento", "igv", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AlterColumn("dbo.DDocumento", "percepcion", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AlterColumn("dbo.HDocumento", "peso_kg", c => c.Decimal(precision: 18, scale: 6));
            AlterColumn("dbo.HDocumento", "Grabado", c => c.Decimal(precision: 18, scale: 6));
            AlterColumn("dbo.HDocumento", "IGV", c => c.Decimal(precision: 18, scale: 6));
            AlterColumn("dbo.HDocumento", "Total", c => c.Decimal(precision: 18, scale: 6));
            AlterColumn("dbo.HDocumento", "Inafecto", c => c.Decimal(precision: 18, scale: 6));
            AlterColumn("dbo.HDocumento", "Exonerado", c => c.Decimal(precision: 18, scale: 6));
            AlterColumn("dbo.HDocumento", "percepcion", c => c.Decimal(precision: 18, scale: 6));
            AlterColumn("dbo.HDocumento", "total_credito", c => c.Decimal(precision: 18, scale: 6));
            AlterColumn("dbo.PromoDeSoles", "PRECIO_PROMO", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AlterColumn("dbo.PromoDeSoles", "DESDE_SOLES_ART", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AlterColumn("dbo.PromoDeSoles", "HASTA_SOLES_ART", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AlterColumn("dbo.PromoDeSoles", "SOLES_ART_VTA", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AlterColumn("dbo.PromoDeSoles", "CANT_ARTI_PROMO", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AlterColumn("dbo.PromoDeSoles", "STOCK_PROMO", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AlterColumn("dbo.PromoSubCat", "PRECIO_PROMO", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AlterColumn("dbo.PromoSubCat", "DESDE_SOLES_ART", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AlterColumn("dbo.PromoSubCat", "HASTA_SOLES_ART", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AlterColumn("dbo.PromoSubCat", "SOLES_ART_VTA", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AlterColumn("dbo.PromoSubCat", "CANT_ARTI_PROMO", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AlterColumn("dbo.PromoSubCat", "STOCK_PROMO", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AlterColumn("dbo.VentaCabFE", "TOTBAS", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AlterColumn("dbo.VentaCabFE", "SUBTOTBAS", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AlterColumn("dbo.VentaCabFE", "IGVBAS", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AlterColumn("dbo.VentaDetFE", "TOTBAS", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AlterColumn("dbo.VentaDetFE", "MONTODESCBAS", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AlterColumn("dbo.VentaDetFE", "CANTIDAD", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AlterColumn("dbo.VentaDetFE", "SUBTOTBAS", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AlterColumn("dbo.VentaDetFE", "IGVBAS", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AlterColumn("dbo.VentaDetFE", "PRECIO", c => c.Decimal(nullable: false, precision: 18, scale: 6));
            AlterColumn("dbo.VentaDetFE", "PORCENDESC", c => c.Decimal(nullable: false, precision: 18, scale: 6));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SupervisorVendedor", "Codsupervisor", "dbo.Supervisor");
            DropIndex("dbo.SupervisorVendedor", new[] { "Codsupervisor" });
            AlterColumn("dbo.VentaDetFE", "PORCENDESC", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AlterColumn("dbo.VentaDetFE", "PRECIO", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AlterColumn("dbo.VentaDetFE", "IGVBAS", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AlterColumn("dbo.VentaDetFE", "SUBTOTBAS", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AlterColumn("dbo.VentaDetFE", "CANTIDAD", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AlterColumn("dbo.VentaDetFE", "MONTODESCBAS", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AlterColumn("dbo.VentaDetFE", "TOTBAS", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AlterColumn("dbo.VentaCabFE", "IGVBAS", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AlterColumn("dbo.VentaCabFE", "SUBTOTBAS", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AlterColumn("dbo.VentaCabFE", "TOTBAS", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AlterColumn("dbo.PromoSubCat", "STOCK_PROMO", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AlterColumn("dbo.PromoSubCat", "CANT_ARTI_PROMO", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AlterColumn("dbo.PromoSubCat", "SOLES_ART_VTA", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AlterColumn("dbo.PromoSubCat", "HASTA_SOLES_ART", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AlterColumn("dbo.PromoSubCat", "DESDE_SOLES_ART", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AlterColumn("dbo.PromoSubCat", "PRECIO_PROMO", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AlterColumn("dbo.PromoDeSoles", "STOCK_PROMO", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AlterColumn("dbo.PromoDeSoles", "CANT_ARTI_PROMO", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AlterColumn("dbo.PromoDeSoles", "SOLES_ART_VTA", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AlterColumn("dbo.PromoDeSoles", "HASTA_SOLES_ART", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AlterColumn("dbo.PromoDeSoles", "DESDE_SOLES_ART", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AlterColumn("dbo.PromoDeSoles", "PRECIO_PROMO", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AlterColumn("dbo.HDocumento", "total_credito", c => c.Decimal(precision: 12, scale: 6));
            AlterColumn("dbo.HDocumento", "percepcion", c => c.Decimal(precision: 12, scale: 6));
            AlterColumn("dbo.HDocumento", "Exonerado", c => c.Decimal(precision: 12, scale: 6));
            AlterColumn("dbo.HDocumento", "Inafecto", c => c.Decimal(precision: 12, scale: 6));
            AlterColumn("dbo.HDocumento", "Total", c => c.Decimal(precision: 12, scale: 6));
            AlterColumn("dbo.HDocumento", "IGV", c => c.Decimal(precision: 12, scale: 6));
            AlterColumn("dbo.HDocumento", "Grabado", c => c.Decimal(precision: 12, scale: 6));
            AlterColumn("dbo.HDocumento", "peso_kg", c => c.Decimal(precision: 12, scale: 6));
            AlterColumn("dbo.DDocumento", "percepcion", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AlterColumn("dbo.DDocumento", "igv", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AlterColumn("dbo.DDocumento", "prod_cant", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AlterColumn("dbo.DDocumento", "prod_desct", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AlterColumn("dbo.DDocumento", "prod_precio", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AlterColumn("dbo.CDocumento", "monto_cuota", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            DropTable("dbo.SupervisorVendedor");
            DropTable("dbo.Supervisor");
        }
    }
}
