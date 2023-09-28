using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.TipoCredito.Peticiones;
using Servicios.Interfaces.TipoCredito.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.TipoCredito
{
    public interface IGestorDeTipoCredito : IMantenimientoBase<TipoCreditoNuevo, TipoCreditoActualizar, TipoCreditoRegistrado>
    {
    }
}
