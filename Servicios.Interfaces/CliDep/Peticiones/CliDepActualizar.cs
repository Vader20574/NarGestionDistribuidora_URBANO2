using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.CliDep.Peticiones
{
    public class CliDepActualizar
    {

        public string CODEMPRESA { get; set; }
        public string CODDEP { get; set; }
        public string CODCLIENTE { get; set; }
        public bool ACTIVO { get; set; }
        public string CODRUTA { get; set; }
        public string CODDISTRITO { get; set; }
        public Nullable<decimal> MPERCEP { get; set; }
        public Nullable<bool> notapedido { get; set; }
        public Nullable<bool> ORT { get; set; }

      

    }
}
