using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.Modelo
{
    public class Equipo 
    {
        [Key]
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Descripcion2 { get; set; }

        
    }
}
