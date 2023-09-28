using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.Ruta.Peticiones;
using Servicios.Interfaces.Ruta.Respuestas;

namespace Servicios.Interfaces.Ruta
{
   public interface IGestorDeRuta :IMantenimientoBase<RutaNuevo,RutaActualizar, RutaRegistrado>
    {
    }
}
