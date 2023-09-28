using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Pais.Peticiones
{
    public class PaisNuevo
    {

        public Nullable<System.DateTime> DATETRANS { get; set; }
        public Nullable<bool> TRANS { get; set; }
        public Nullable<bool> ESTADO { get; set; }
        public string DESPAIS { get; set; }
        public string CODPAIS { get; set; }
        public string COD_EMPRESA { get; set; }


    }
}
