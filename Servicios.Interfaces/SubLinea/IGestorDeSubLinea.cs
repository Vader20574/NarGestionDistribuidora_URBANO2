using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.SubLinea.Peticiones;
using Servicios.Interfaces.SubLinea.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.SubLinea
{
    public interface IGestorDeSubLinea : IMantenimientoBase<SubLineaNuevo, SubLineaActualizar, SubLineaRegistrado>
    {

        List<SubLineaRegistrado> Listar(string codlinea);

    }
}
