using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.FacturaElectronica.Respuestas
{
   public class DDocumentoRegistrado
    {
        public int id { get; set; }
        public int codi_cab { get; set; }
        public string prod_codi { get; set; }
        public string prod_descr { get; set; }
        public string prod_unid { get; set; }
        public decimal prod_precio { get; set; }
        public decimal prod_desct { get; set; }
        public decimal prod_cant { get; set; }
        public decimal igv { get; set; }
        public decimal percepcion { get; set; }
        public string tipo_igv { get; set; }
        public string obse { get; set; }
        public string codigo_sunat { get; set; }
        public string codigo_gsi { get; set; }

    }
}
