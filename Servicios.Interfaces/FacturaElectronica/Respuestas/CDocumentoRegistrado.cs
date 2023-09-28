using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.FacturaElectronica.Respuestas
{
    public class CDocumentoRegistrado
    {
        public int cred_codi { get; set; }
        public int codi_cab { get; set; }
        public int num_cuota { get; set; }
        public decimal monto_cuota { get; set; }
        public DateTime? fecha_vence { get; set; }
    }
}
