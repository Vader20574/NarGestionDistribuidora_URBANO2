namespace Dominio.Contextos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creandoCentroCostoPromo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CentroCostoPromo",
                c => new
                    {
                        CodCentroProm = c.String(nullable: false, maxLength: 128),
                        NombCentroProm = c.String(),
                    })
                .PrimaryKey(t => t.CodCentroProm);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CentroCostoPromo");
        }
    }
}
