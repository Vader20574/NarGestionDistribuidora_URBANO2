using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.Distribucion
{
    public class CDocumento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int cred_codi { get; set; }
        public int codi_cab { get; set; }
        public int num_cuota { get; set; }
        public decimal monto_cuota { get; set; }
        public DateTime? fecha_vence { get; set; }
    }
}
