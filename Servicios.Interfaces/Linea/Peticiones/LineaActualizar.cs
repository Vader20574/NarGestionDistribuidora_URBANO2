using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Linea.Peticiones
{
    public class LineaActualizar
    {

        public string CODEMPRESA { get; set; }
        public string CODLINEA { get; set; }
        public string DESLINEA { get; set; }
        public Nullable<bool> ESTADO { get; set; }
        public Nullable<bool> TRANS { get; set; }
        public Nullable<System.DateTime> DATETRANS { get; set; }
        public string CODTIPOPROD { get; set; }
        public decimal CORRELATIVO { get; set; }



    }
}
