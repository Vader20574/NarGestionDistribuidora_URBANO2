namespace Dominio.Contextos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creartablaCDocumento : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CDocumento",
                c => new
                    {
                        cred_codi = c.Int(nullable: false, identity: true),
                        codi_cab = c.Int(nullable: false),
                        num_cuota = c.Int(nullable: false),
                        monto_cuota = c.Decimal(nullable: false, precision: 12, scale: 6),
                        fecha_vence = c.DateTime(),
                    })
                .PrimaryKey(t => t.cred_codi);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CDocumento");
        }
    }
}
