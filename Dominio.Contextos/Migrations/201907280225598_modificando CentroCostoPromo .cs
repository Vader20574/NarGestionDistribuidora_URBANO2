namespace Dominio.Contextos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modificandoCentroCostoPromo : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.CentroCostoPromo");
            AddColumn("dbo.CentroCostoPromo", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.CentroCostoPromo", "Id");
            DropColumn("dbo.CentroCostoPromo", "CodCentroProm");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CentroCostoPromo", "CodCentroProm", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("dbo.CentroCostoPromo");
            DropColumn("dbo.CentroCostoPromo", "Id");
            AddPrimaryKey("dbo.CentroCostoPromo", "CodCentroProm");
        }
    }
}
