namespace Dominio.Contextos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateEquipo_Vendedor : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Equipo_Vendedor", "CodVend", c => c.String(maxLength: 4, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Equipo_Vendedor", "CodVend", c => c.String());
        }
    }
}
