using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.FuerzaVenta.Peticiones;
using Servicios.Interfaces.FuerzaVenta.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.FuerzaVenta
{
    public interface IGestorDeFuerzaVenta : IMantenimientoBase<FuerzaVentaNuevo, FuerzaVentaActualizar, FuerzaVentaRegistrado>
    {
    }
}
