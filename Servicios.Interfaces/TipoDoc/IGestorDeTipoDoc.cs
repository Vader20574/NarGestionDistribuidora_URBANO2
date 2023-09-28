using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.TipoDoc.Peticiones;
using Servicios.Interfaces.TipoDoc.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.TipoDoc
{
   public interface IGestorDeTipoDoc : IMantenimientoBase<TipoDocNuevo, TipoDocActualizar, TipoDocRegistrado>
    {
    }
}
