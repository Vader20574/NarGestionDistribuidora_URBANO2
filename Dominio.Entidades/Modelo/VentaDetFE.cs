using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.Modelo
{
    public class VentaDetFE : EntidadBase
    {

        public string CODEMPRESA { get; set; }
        public string CODTIPODOC { get; set; }
        public string NRODOCU { get; set; }
        public string CODARTI { get; set; }
        public string ITEM { get; set; }
        public decimal TOTBAS { get; set; }
        public decimal MONTODESCBAS { get; set; }
        public string CODPROMO { get; set; }
        public string CODTIPOPRE { get; set; }

        public decimal CANTIDAD { get; set; }
        public decimal SUBTOTBAS { get; set; }
        public decimal IGVBAS { get; set; }
        public decimal PRECIO { get; set; }
        public decimal PORCENDESC { get; set; }
        public string CODPRES { get; set; }
        public string DESARTI { get; set; }

    }
}
