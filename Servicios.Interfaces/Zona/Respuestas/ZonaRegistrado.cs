using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Zona.Respuestas
{
    public class ZonaRegistrado
    {
        public Nullable<System.DateTime> datetrans { get; set; }
        public Nullable<bool> trans { get; set; }
        public Nullable<bool> estado { get; set; }
        public string deszona { get; set; }
        public string codzona { get; set; }
        public string CODEMPRESA { get; set; }
    }
}
