using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.Distrito.Peticiones;
using Servicios.Interfaces.Distrito.Respuestas;

namespace Servicios.Interfaces.Distrito
{
    public interface IGestorDeDistrito : IMantenimientoBase<DistritoNuevo, DistritoActualizar, DistritoRegistrado>
    {
    }
}
