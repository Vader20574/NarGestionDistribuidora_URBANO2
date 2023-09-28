namespace Dominio.Contextos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetablaClienteXPromo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClienteXPromo", "RAZONSOCIAL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClienteXPromo", "RAZONSOCIAL");
        }
    }
}
