using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.TipoPrecio.Peticiones
{
   public class TipoPrecioActualizar
    {

        public Nullable<System.DateTime> DATETRANS { get; set; }
        public Nullable<bool> TRANS { get; set; }
        public string DSTIPOPRE { get; set; }
        public string CODTIPOPRE { get; set; }
        public string codmon { get; set; }
        public Nullable<bool> estado { get; set; }
        public string CODEMPRESA { get; set; }
        public Nullable<bool> APLIOTROSCTO { get; set; }
        public string DS { get; set; }


    }
}
