using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.SubEmpresaXLinea.Peticiones
{
    public class SubEmpXLineaNuevo
    {
        public bool GIDS { get; set; }

        public string LineaCodlinea { get; set; }
        public int SubEmpresaId { get; set; }
    }
}
