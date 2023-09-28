namespace Dominio.Contextos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PromoSubCat_creando_xcaterio_xsubcaterio : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PromoSubCat", "XCATEGORIA", c => c.Boolean(nullable: false));
            AddColumn("dbo.PromoSubCat", "XSUBCATEGORIA", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PromoSubCat", "XSUBCATEGORIA");
            DropColumn("dbo.PromoSubCat", "XCATEGORIA");
        }
    }
}
