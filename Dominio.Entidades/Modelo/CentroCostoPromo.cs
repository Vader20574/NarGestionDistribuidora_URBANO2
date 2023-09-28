using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.Modelo
{
   public class CentroCostoPromo
    {
        [Key]
        public int Id { get; set; }
        public string NombCentroProm { get; set; }
    }
}
