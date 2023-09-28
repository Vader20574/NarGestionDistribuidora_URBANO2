using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.Modelo
{
    public class SupervisorVendedor
    {
        public int Id { get; set; }
        public string Codempresa { get; set; }
        [ForeignKey("Supervisor")]
        public string Codsupervisor { get; set; }
        public string Codvendedor { get; set; }
        public string Dsvend { get; set; }
        public virtual Supervisor Supervisor { get; set; }
    }
}
