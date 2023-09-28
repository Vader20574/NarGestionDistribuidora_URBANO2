using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios.Interfaces.Ciudad.Peticiones;
using Servicios.Interfaces.Ciudad.Respuesta;
using Servicios.Interfaces.Compartido;


namespace Servicios.Interfaces.Ciudad
{
   public interface IGestorDeCiudad:IMantenimientoBase<CiudadNuevo, CiudadActualizar, CiudadRegistrado>
    {

    }
}
