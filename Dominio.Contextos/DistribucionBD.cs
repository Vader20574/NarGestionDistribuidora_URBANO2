using Dominio.Entidades.Distribucion;
using Dominio.Entidades.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Contextos
{
    public class DistribucionBD : DbContext
    {

        private static readonly string NOMBRE_CADENA_CONEXION = "Distribucion";

        public DistribucionBD() : base(NOMBRE_CADENA_CONEXION)
        {
            ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = 5000;
        }


        public DbSet<HDocumento> HDocumento_ { get; set; }
        public DbSet<DDocumento> DDocumento_ { get; set; }

        public DbSet<VentaAnulados> VentaAnulados { get; set; }
        public DbSet<Cierre_Inv_Gloria> Cierre_Inv_Gloria { get; set; }
        public DbSet<Cierre_Inv_Protisa> Cierre_Inv_Protisa { get; set; }

        public DbSet<VentaCabFE> VentaCabFE { get; set; }
        public DbSet<VentaDetFE> VentaDetFE { get; set; }
        public DbSet<Equipo> Equipo { get; set; }
        public DbSet<Jefe_Equipo> Jefe_Equipo { get; set; }
        public DbSet<Equipo_Vendedor> Equipo_Vendedor { get; set; }
        public DbSet<CentroCostoPromo> CentroCostoPromo { get; set; }
        public DbSet<PromoDeSoles> PromoDeSoles { get; set; }
        public DbSet<ClienteXPromo> ClienteXPromo { get; set; }
        public DbSet<PromoSubCat> PromoSubCat { get; set; }
        public DbSet<TipoPrecioXPromoSubCatSoles> TipoPrecioXPromoSubCatSoles { get; set; }
        public DbSet<TipoPrecioXPromoSoles> TipoPrecioXPromoSoles { get; set; }

        public DbSet<CDocumento> CDocumento { get; set; }

        public DbSet<Supervisor> Supervisor { get; set; }
        public DbSet<SupervisorVendedor> SupervisorVendedor { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Properties<decimal>().Configure(config => config.HasPrecision(18, 6));
            modelBuilder.Entity<HDocumento>().Property(p => p.esta_pod).HasColumnType("VARCHAR").HasMaxLength(1);
            modelBuilder.Entity<HDocumento>().Property(p => p.DarBaja).HasColumnType("VARCHAR").HasMaxLength(1);
            modelBuilder.Entity<HDocumento>().Property(p => p.ProcesarBaja).HasColumnType("VARCHAR").HasMaxLength(1);
            modelBuilder.Entity<HDocumento>().Property(p => p.Envio_xml).HasColumnType("VARCHAR").HasMaxLength(1);
            modelBuilder.Entity<HDocumento>().Property(p => p.ValorResumen).HasColumnType("VARCHAR").HasMaxLength(600);
            modelBuilder.Entity<HDocumento>().Property(p => p.ValorHash).HasColumnType("VARCHAR").HasMaxLength(600);
            modelBuilder.Entity<HDocumento>().Property(p => p.Codigo_local).HasColumnType("VARCHAR").HasMaxLength(6);
            modelBuilder.Entity<HDocumento>().Property(p => p.hora).HasColumnType("VARCHAR").HasMaxLength(8);
            modelBuilder.Entity<DDocumento>().Property(p => p.codigo_sunat).HasColumnType("VARCHAR").HasMaxLength(8);
            modelBuilder.Entity<DDocumento>().Property(p => p.codigo_gsi).HasColumnType("VARCHAR").HasMaxLength(4);
            modelBuilder.Entity<Equipo_Vendedor>().Property(p => p.CodVend).HasColumnType("VARCHAR").HasMaxLength(4);
            modelBuilder.Entity<PromoDeSoles>().Property(p => p.CODPROMO).HasColumnType("VARCHAR").HasMaxLength(50);




        }

    }
}
