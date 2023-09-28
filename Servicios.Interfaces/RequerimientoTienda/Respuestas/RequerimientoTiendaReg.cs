using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.RequerimientoTienda.Respuestas
{
    public class RequerimientoTiendaReg
    {
        public DateTime Fecdocum { get; set; }
        public string Dstipodoc { get; set; }
        public string Nrodocu { get; set; }
        public string Cdusuario { get; set; }
        public string Codvend { get; set; }
        public string Dsvend { get; set; }
        public string Nroptovta { get; set; }
        public string Codlinea { get; set; }
        public string Deslinea { get; set; }
        public string Codsublinea { get; set; }
        public string Dessublinea { get; set; }
        public string Codarti { get; set; }
        public string Desarti { get; set; }
        public string Codpres { get; set; }
        public string Presentacion { get; set; }
        public string Estado { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Preciovta { get; set; }
        public decimal Igvbas { get; set; }
        public decimal Subtotbas { get; set; }
        public decimal TotalSoles { get; set; }
        public decimal? Factor { get; set; }
        public decimal? UndMin { get; set; }
        public decimal? Costbaseu { get; set; }
        public decimal? TotalCosto { get; set; }
        public decimal? Ub { get; set; }
        public decimal? Margen { get; set; }
        public int Id { get; set; }
    }
}
