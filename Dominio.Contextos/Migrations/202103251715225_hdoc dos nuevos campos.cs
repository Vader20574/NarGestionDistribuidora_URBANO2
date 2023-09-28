namespace Dominio.Contextos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hdocdosnuevoscampos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HDocumento", "Forma_pago", c => c.String());
            AddColumn("dbo.HDocumento", "total_credito", c => c.Decimal(precision: 12, scale: 6));
        }
        
        public override void Down()
        {
            DropColumn("dbo.HDocumento", "total_credito");
            DropColumn("dbo.HDocumento", "Forma_pago");
        }
    }
}
