using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.Modelo
{
    public class VentaCabFE : EntidadBase
    {
        public string CODEMPRESA { get; set; }
        public string CODTIPODOC { get; set; }
        public string NRODOCU { get; set; }
        public string CODCLIENTE { get; set; }
        public string CODDEP { get; set; }
        public DateTime FECDOCUM { get; set; }
        public string CODTIPOPAGO { get; set; }
        public string NROGUIA { get; set; }
        public string NUMDOC { get; set; }
        public string SERIE { get; set; }

        public decimal TOTBAS { get; set; }
        public decimal SUBTOTBAS { get; set; }
        public decimal IGVBAS { get; set; }

        public string RUCCLIENTE { get; set; }
        public string DESCLIENTE { get; set; }
        public string DIRCLIENTE { get; set; }
        public string codvend { get; set; }

        public string ENVIO { get; set; }
        


    }
}
