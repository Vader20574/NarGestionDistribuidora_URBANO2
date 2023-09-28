using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Ciudad.Peticiones
{
    public class CiudadNuevo
    {
        public string CODCIUDAD { get; set; }
        public string DESCIUDAD { get; set; }
        public string CODPAIS { get; set; }
        public string iddepa { get; set; }
        public Nullable<bool> estado { get; set; }
        public Nullable<System.DateTime> datetrans { get; set; }
        public Nullable<bool> trans { get; set; }
        public string CODEMPRESA { get; set; }

    }
}
