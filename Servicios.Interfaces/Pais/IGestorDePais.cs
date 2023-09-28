using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.Pais.Peticiones;
using Servicios.Interfaces.Pais.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Pais
{
    public interface IGestorDePais : IMantenimientoBase<PaisNuevo, PaisActualizar, PaisRegistrado>
    {


    }
}
