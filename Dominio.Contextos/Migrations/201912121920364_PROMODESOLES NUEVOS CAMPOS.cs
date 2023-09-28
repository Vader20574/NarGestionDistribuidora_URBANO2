namespace Dominio.Contextos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PROMODESOLESNUEVOSCAMPOS : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PromoDeSoles", "XTIPOPRE", c => c.Boolean(nullable: false));
            AddColumn("dbo.PromoDeSoles", "XCLIENTE", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PromoDeSoles", "XCLIENTE");
            DropColumn("dbo.PromoDeSoles", "XTIPOPRE");
        }
    }
}
