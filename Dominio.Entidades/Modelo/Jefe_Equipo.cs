using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.Modelo
{
    public class Jefe_Equipo
    {
        [Key]
        public int Id { get; set; }
        public string NombreJefe { get; set; }
        public string DatosPersonales { get; set; }
        [ForeignKey("Equipo")]
        public string CodEquipoVend { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Fin { get; set; }
        public virtual Equipo Equipo { get; set; }
    }
}
