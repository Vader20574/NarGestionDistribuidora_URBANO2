namespace Dominio.Contextos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ventacabfe_envio : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VentaCabFE", "ENVIO", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.VentaCabFE", "ENVIO");
        }
    }
}
