namespace Dominio.Contextos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class crearnuevoscamposenhdocumentoyddocumento : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DDocumento", "codigo_sunat", c => c.String(maxLength: 8, unicode: false));
            AddColumn("dbo.DDocumento", "codigo_gsi", c => c.String(maxLength: 4, unicode: false));
            AddColumn("dbo.HDocumento", "Codigo_local", c => c.String(maxLength: 6, unicode: false));
            AddColumn("dbo.HDocumento", "hora", c => c.String(maxLength: 8, unicode: false));
            DropColumn("dbo.DDocumento", "obse");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DDocumento", "obse", c => c.String(nullable: false));
            DropColumn("dbo.HDocumento", "hora");
            DropColumn("dbo.HDocumento", "Codigo_local");
            DropColumn("dbo.DDocumento", "codigo_gsi");
            DropColumn("dbo.DDocumento", "codigo_sunat");
        }
    }
}
