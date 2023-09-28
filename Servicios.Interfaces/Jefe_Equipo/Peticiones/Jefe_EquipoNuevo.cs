using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Jefe_Equipo.Peticiones
{
    public class Jefe_EquipoNuevo
    {
        public int Id { get; set; }
        public string NombreJefe { get; set; }
        public string DatosPersonales { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Fin { get; set; }
        public string CodEquipoVend { get; set; }
    }
}
