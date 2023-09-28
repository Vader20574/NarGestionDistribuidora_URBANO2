using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.Distribucion
{
    public class DDocumento
    {
        [Key]
        public int id { get; set; }
        [Required]
        public int codi_cab { get; set; }
        [Required]
        public string prod_codi { get; set; }
        [Required]
        public string prod_descr { get; set; }
        [Required]
        public string prod_unid { get; set; }
        [Required]
        public decimal prod_precio { get; set; }
        [Required]
        public decimal prod_desct { get; set; }
        [Required]
        public decimal prod_cant { get; set; }
        [Required]
        public decimal igv { get; set; }
        [Required]
        public decimal percepcion { get; set; }
        [Required]
        public string tipo_igv { get; set; }
        [Required]
        public string obse { get; set; }
        public string codigo_sunat { get; set; }
        public string codigo_gsi { get; set; }
    }
}
