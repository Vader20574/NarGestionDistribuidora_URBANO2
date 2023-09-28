using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.TipoPrecio.Peticiones;
using Servicios.Interfaces.TipoPrecio.Respuestas;

namespace Servicios.Interfaces.TipoPrecio
{
    public interface IGestorDeTipoPrecio : IMantenimientoBase<TipoPrecioNuevo, TipoPrecioActualizar, TipoPrecioRegistrado>
    {

    }
}
