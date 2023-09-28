namespace Dominio.Contextos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregarcodpromoenVENTADETFE : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VentaDetFE", "CODPROMO", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.VentaDetFE", "CODPROMO");
        }
    }
}
