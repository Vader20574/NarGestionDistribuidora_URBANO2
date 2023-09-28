namespace Dominio.Contextos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambios_ventacabfe_ventadetfe : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VentaCabFE", "TOTBAS", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AddColumn("dbo.VentaCabFE", "SUBTOTBAS", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AddColumn("dbo.VentaCabFE", "IGVBAS", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AddColumn("dbo.VentaCabFE", "RUCCLIENTE", c => c.String());
            AddColumn("dbo.VentaCabFE", "DESCLIENTE", c => c.String());
            AddColumn("dbo.VentaCabFE", "DIRCLIENTE", c => c.String());
            AddColumn("dbo.VentaCabFE", "codvend", c => c.String());
            AddColumn("dbo.VentaDetFE", "CANTIDAD", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AddColumn("dbo.VentaDetFE", "SUBTOTBAS", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AddColumn("dbo.VentaDetFE", "IGVBAS", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AddColumn("dbo.VentaDetFE", "PRECIO", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AddColumn("dbo.VentaDetFE", "PORCENDESC", c => c.Decimal(nullable: false, precision: 12, scale: 6));
            AddColumn("dbo.VentaDetFE", "CODPRES", c => c.String());
            AddColumn("dbo.VentaDetFE", "DESARTI", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.VentaDetFE", "DESARTI");
            DropColumn("dbo.VentaDetFE", "CODPRES");
            DropColumn("dbo.VentaDetFE", "PORCENDESC");
            DropColumn("dbo.VentaDetFE", "PRECIO");
            DropColumn("dbo.VentaDetFE", "IGVBAS");
            DropColumn("dbo.VentaDetFE", "SUBTOTBAS");
            DropColumn("dbo.VentaDetFE", "CANTIDAD");
            DropColumn("dbo.VentaCabFE", "codvend");
            DropColumn("dbo.VentaCabFE", "DIRCLIENTE");
            DropColumn("dbo.VentaCabFE", "DESCLIENTE");
            DropColumn("dbo.VentaCabFE", "RUCCLIENTE");
            DropColumn("dbo.VentaCabFE", "IGVBAS");
            DropColumn("dbo.VentaCabFE", "SUBTOTBAS");
            DropColumn("dbo.VentaCabFE", "TOTBAS");
        }
    }
}
