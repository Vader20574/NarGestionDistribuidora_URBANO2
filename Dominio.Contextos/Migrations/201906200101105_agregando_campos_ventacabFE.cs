namespace Dominio.Contextos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregando_campos_ventacabFE : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VentaCabFE", "NUMDOC", c => c.String());
            AddColumn("dbo.VentaCabFE", "SERIE", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.VentaCabFE", "SERIE");
            DropColumn("dbo.VentaCabFE", "NUMDOC");
        }
    }
}
