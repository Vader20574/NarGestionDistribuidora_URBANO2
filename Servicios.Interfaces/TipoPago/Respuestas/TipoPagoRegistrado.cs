using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.TipoPago.Respuestas
{
    public class TipoPagoRegistrado
    {

        public Nullable<System.DateTime> DATETRANS { get; set; }
        public Nullable<bool> ESTADO { get; set; }
        public Nullable<bool> TRANS { get; set; }
        public string DSTIPOPAGO { get; set; }
        public string CODTIPOPAGO { get; set; }
        public string CODEMPRESA { get; set; }

    }
}
