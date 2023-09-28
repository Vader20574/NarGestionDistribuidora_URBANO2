namespace Dominio.Contextos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregarcodtipopreenVENTADETFE : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VentaDetFE", "CODTIPOPRE", c => c.String());
            DropColumn("dbo.VentaDetFE", "CODPRES");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VentaDetFE", "CODPRES", c => c.String());
            DropColumn("dbo.VentaDetFE", "CODTIPOPRE");
        }
    }
}
