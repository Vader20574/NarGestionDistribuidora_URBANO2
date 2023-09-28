using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.SubEmpresa.Peticiones
{
    public class SubEmpresaNuevo
    {

        public string Nombre { get; set; }

        public decimal nrofac { get; set; }
        public decimal nrobol { get; set; }
        public decimal nroped { get; set; }

        public decimal nrofacRef { get; set; }
        public decimal nrobolRef { get; set; }
        public decimal nropedRef { get; set; }

        public bool EDESE { get; set; }
        public bool NGIE { get; set; }

    }
}
