using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.TipoPago.Peticiones;
using Servicios.Interfaces.TipoPago.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.TipoPago
{
   public interface IGestorDeTipoPago : IMantenimientoBase<TipoPagoNuevo, TipoPagoActualizar, TipoPagoRegistrado>
    {
    }
}
