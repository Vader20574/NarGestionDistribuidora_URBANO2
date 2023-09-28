using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaCliente.Facturacion.Respuestas
{
    public class RespBuscarDocRegistrado
    {
        public string Codempresa { get; set; }
        public string Codtipodoc { get; set; }
        public string Nrodocu { get; set; }
        public string Codtipopago { get; set; }
        public string Codvend { get; set; }
        public string Fecdocum { get; set; }
        public decimal Totbas { get; set; }
        public decimal Subtotbas { get; set; }
        public decimal Igvbas { get; set; }
        public string Codcliente { get; set; }
        public string Descliente { get; set; }
        public string Ruccliente { get; set; }
        public string Nroptovta { get; set; }
        public decimal Ipercep { get; set; }
        public string dni { get; set; }
        public string email { get; set; }
        public string Dircliente { get; set; }
        public string Estado { get; set; }
        public string Serie { get; set; }
        public string Numdoc { get; set; }
        public string tabla { get; set; }

    }
}
