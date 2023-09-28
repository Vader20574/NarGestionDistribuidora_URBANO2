namespace Dominio.Contextos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tablaequipo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Equipo",
                c => new
                    {
                        Codigo = c.String(nullable: false, maxLength: 128),
                        Descripcion = c.String(),
                        Descripcion2 = c.String(),
                    })
                .PrimaryKey(t => t.Codigo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Equipo");
        }
    }
}
