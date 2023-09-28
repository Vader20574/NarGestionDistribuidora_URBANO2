using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.TipoNegocio.Peticiones;
using Servicios.Interfaces.TipoNegocio.Respuestas;

namespace Servicios.Interfaces.TipoNegocio
{
    public interface IGestorDeTipoNegocio:IMantenimientoBase<TipoNegocioNuevo, TipoNegocioActualizar, TipoNegocioRegistrado>
    {

    }
}
