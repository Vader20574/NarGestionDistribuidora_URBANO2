namespace Dominio.Contextos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UPLinea_ventaAnulado : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VentaAnulados", "CODLINEA", c => c.String());
            DropColumn("dbo.VentaAnulados", "LINEA");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VentaAnulados", "LINEA", c => c.String());
            DropColumn("dbo.VentaAnulados", "CODLINEA");
        }
    }
}
