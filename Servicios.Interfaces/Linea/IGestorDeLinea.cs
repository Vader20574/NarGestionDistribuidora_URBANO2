using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.Linea.Peticiones;
using Servicios.Interfaces.Linea.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Linea
{
    public interface IGestorDeLinea : IMantenimientoBase<LineaNuevo, LineaActualizar, LineaRegistrado>
    {
    }
}
