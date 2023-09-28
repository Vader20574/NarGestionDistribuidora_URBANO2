using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.Moneda.Peticiones;
using Servicios.Interfaces.Moneda.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Moneda
{
   public interface IGestorDeMoneda : IMantenimientoBase<MonedaNuevo, MonedaActualizar, MonedaRegistrado>
    {
    }
}
