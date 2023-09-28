using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.EntregaMercas.Peticiones;
using Servicios.Interfaces.EntregaMercas.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.EntregaMercas
{
    public interface IGestorDeEntregaMerca : IMantenimientoBase<EntregaMercaNuevo, EntregaMercaActualizar, EntregaMercaRegistrado>
    {
    }
}
