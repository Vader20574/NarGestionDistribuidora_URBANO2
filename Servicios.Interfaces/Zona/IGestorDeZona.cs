using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.Zona.Peticiones;
using Servicios.Interfaces.Zona.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Zona
{
    public interface IGestorDeZona : IMantenimientoBase<ZonaNuevo, ZonaActualizar, ZonaRegistrado>
    {
    }
}
