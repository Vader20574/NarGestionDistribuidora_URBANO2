using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.SubLinea.Peticiones
{
    public class SubLineaActualizar
    {
        public string CODEMPRESA { get; set; }
        public string CODSUBLINEA { get; set; }
        public string DESSUBLINEA { get; set; }
        public Nullable<bool> ESTADO { get; set; }
        public Nullable<bool> TRANS { get; set; }
        public Nullable<System.DateTime> DATETRANS { get; set; }
        public string CODLINEA { get; set; }
        public string PLCODI { get; set; }
    }
}
