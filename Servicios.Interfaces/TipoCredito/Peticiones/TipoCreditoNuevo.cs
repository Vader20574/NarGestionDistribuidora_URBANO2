using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.TipoCredito.Peticiones
{
    public class TipoCreditoNuevo
    {

        public string COD_EMPRESA { get; set; }
        public string TIPCREDFAC { get; set; }
        public string DESCREDFAC { get; set; }
        public Nullable<int> NRDIAS { get; set; }
        public Nullable<bool> TRANS { get; set; }
        public Nullable<System.DateTime> DATETRANS { get; set; }
        public Nullable<bool> estado { get; set; }

    }
}
