namespace Dominio.Contextos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Agregarcampo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DDocumento", "obse", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DDocumento", "obse");
        }
    }
}
