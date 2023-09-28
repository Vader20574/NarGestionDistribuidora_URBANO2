namespace Dominio.Contextos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambie_TipoPrecioXPromoSubCatSoles : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TipoPrecioXPromoSubCatSoles", "CODLINEA", c => c.String());
            AddColumn("dbo.TipoPrecioXPromoSubCatSoles", "DESLINEA", c => c.String());
            DropColumn("dbo.TipoPrecioXPromoSubCatSoles", "CODPROMO");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TipoPrecioXPromoSubCatSoles", "CODPROMO", c => c.String());
            DropColumn("dbo.TipoPrecioXPromoSubCatSoles", "DESLINEA");
            DropColumn("dbo.TipoPrecioXPromoSubCatSoles", "CODLINEA");
        }
    }
}
