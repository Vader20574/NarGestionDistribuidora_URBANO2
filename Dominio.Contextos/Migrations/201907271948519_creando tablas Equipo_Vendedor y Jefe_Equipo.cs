namespace Dominio.Contextos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creandotablasEquipo_VendedoryJefe_Equipo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Equipo_Vendedor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CodEquipo = c.String(maxLength: 128),
                        CodVend = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Equipo", t => t.CodEquipo)
                .Index(t => t.CodEquipo);
            
            CreateTable(
                "dbo.Jefe_Equipo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreJefe = c.String(),
                        DatosPersonales = c.String(),
                        CodEquipoVend = c.Int(nullable: false),
                        Fecha_Inicio = c.DateTime(nullable: false),
                        Fecha_Fin = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Equipo_Vendedor", t => t.CodEquipoVend, cascadeDelete: true)
                .Index(t => t.CodEquipoVend);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jefe_Equipo", "CodEquipoVend", "dbo.Equipo_Vendedor");
            DropForeignKey("dbo.Equipo_Vendedor", "CodEquipo", "dbo.Equipo");
            DropIndex("dbo.Jefe_Equipo", new[] { "CodEquipoVend" });
            DropIndex("dbo.Equipo_Vendedor", new[] { "CodEquipo" });
            DropTable("dbo.Jefe_Equipo");
            DropTable("dbo.Equipo_Vendedor");
        }
    }
}
