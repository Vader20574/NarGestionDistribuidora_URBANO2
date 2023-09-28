using CapaDatafirst;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.Modelo
{
    public class Equipo_Vendedor
    {
        public int Id { get; set; }
        [ForeignKey("Equipo")]
        public string CodEquipo { get; set; }
        public string CodVend { get; set; }
        public virtual Equipo Equipo { get; set; }
    
    }
}
