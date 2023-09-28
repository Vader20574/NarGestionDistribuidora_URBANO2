namespace Dominio.Contextos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creandotablaPromoDeSoles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PromoDeSoles",
                c => new
                    {
                        CODPROMO = c.String(nullable: false, maxLength: 50, unicode: false),
                        CODEMPRESA = c.String(),
                        DESPROMO = c.String(),
                        PRECIO_PROMO = c.Decimal(nullable: false, precision: 12, scale: 6),
                        CODZONA = c.String(),
                        CODARTI_VTA = c.String(),
                        CODPRESVTA = c.String(),
                        ESCALA = c.Boolean(nullable: false),
                        DESDE_SOLES_ART = c.Decimal(nullable: false, precision: 12, scale: 6),
                        HASTA_SOLES_ART = c.Decimal(nullable: false, precision: 12, scale: 6),
                        SOLES_ART_VTA = c.Decimal(nullable: false, precision: 12, scale: 6),
                        CODARTI_PROMO = c.String(),
                        CODPRESPROM = c.String(),
                        CANT_ARTI_PROMO = c.Decimal(nullable: false, precision: 12, scale: 6),
                        STOCK_PROMO = c.Decimal(nullable: false, precision: 12, scale: 6),
                        FEC_INI = c.DateTime(nullable: false),
                        FEC_FIN = c.DateTime(nullable: false),
                        activar = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CODPROMO);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PromoDeSoles");
        }
    }
}
