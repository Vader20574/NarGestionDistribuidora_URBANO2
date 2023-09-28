namespace Dominio.Contextos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Linea_ventaAnulado : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VentaAnulados", "LINEA", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.VentaAnulados", "LINEA");
        }
    }
}
