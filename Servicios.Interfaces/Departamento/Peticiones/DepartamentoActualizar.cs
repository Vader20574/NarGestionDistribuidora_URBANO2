using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Departamento.Peticiones
{
    public class DepartamentoActualizar
    {
        public string iddepa { get; set; }
        public string depa { get; set; }
        public string codpais { get; set; }
        public string codempresa { get; set; }
        public Nullable<bool> trans { get; set; }
        public Nullable<System.DateTime> datetrans { get; set; }

    }
}
