using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.SupervisorVendedor.Respuestas
{
    public class SupervisorVendedorRegistrado
    {
        public int Id { get; set; }
        public string Codempresa { get; set; }
        public string Codsupervisor { get; set; }
        public string Codvendedor { get; set; }
        public string Dsvend { get; set; }
    }
}
