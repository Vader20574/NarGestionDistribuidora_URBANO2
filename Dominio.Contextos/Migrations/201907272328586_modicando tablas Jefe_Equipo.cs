namespace Dominio.Contextos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modicandotablasJefe_Equipo : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Jefe_Equipo", "CodEquipoVend", "dbo.Equipo_Vendedor");
            DropIndex("dbo.Jefe_Equipo", new[] { "CodEquipoVend" });
            AlterColumn("dbo.Jefe_Equipo", "CodEquipoVend", c => c.String(maxLength: 128));
            CreateIndex("dbo.Jefe_Equipo", "CodEquipoVend");
            AddForeignKey("dbo.Jefe_Equipo", "CodEquipoVend", "dbo.Equipo", "Codigo");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jefe_Equipo", "CodEquipoVend", "dbo.Equipo");
            DropIndex("dbo.Jefe_Equipo", new[] { "CodEquipoVend" });
            AlterColumn("dbo.Jefe_Equipo", "CodEquipoVend", c => c.Int(nullable: false));
            CreateIndex("dbo.Jefe_Equipo", "CodEquipoVend");
            AddForeignKey("dbo.Jefe_Equipo", "CodEquipoVend", "dbo.Equipo_Vendedor", "Id", cascadeDelete: true);
        }
    }
}
