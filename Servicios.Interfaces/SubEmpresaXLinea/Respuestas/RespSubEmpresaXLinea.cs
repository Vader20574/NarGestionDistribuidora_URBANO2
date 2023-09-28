using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.SubEmpresaXLinea.Respuestas
{
    public class RespSubEmpresaXLinea
    {
        public int Id { get; set; }
        public string empresa { get; set; }
        public string deslinea { get; set; }
        public bool GIDS { get; set; }
    }
}
