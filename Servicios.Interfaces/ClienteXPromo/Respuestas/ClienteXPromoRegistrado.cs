using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.ClienteXPromo.Respuestas
{
   public  class ClienteXPromoRegistrado
    {
        public string ID { get; set; }
        public string CODPROMO { get; set; }
        public string CODCLIENTE { get; set; }
        public string RAZONSOCIAL { get; set; }
        public string CODARTI_VTA { get; set; }
    }
}
