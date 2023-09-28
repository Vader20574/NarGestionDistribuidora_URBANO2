using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Moneda.Peticiones
{
    public class MonedaNuevo
    {

        public Nullable<System.DateTime> datetrans { get; set; }
        public Nullable<bool> trans { get; set; }
        public string simbolo { get; set; }
        public string dsmoneda { get; set; }
        public string codmon { get; set; }
        public string CODEMPRESA { get; set; }
        public Nullable<bool> estado { get; set; }
    }
}
