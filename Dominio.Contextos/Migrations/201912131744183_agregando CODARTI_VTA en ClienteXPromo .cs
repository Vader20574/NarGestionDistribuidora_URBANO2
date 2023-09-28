namespace Dominio.Contextos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregandoCODARTI_VTAenClienteXPromo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClienteXPromo", "CODARTI_VTA", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClienteXPromo", "CODARTI_VTA");
        }
    }
}
