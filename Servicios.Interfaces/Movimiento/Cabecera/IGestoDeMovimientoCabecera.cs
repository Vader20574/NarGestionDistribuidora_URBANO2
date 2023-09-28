
using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.Movimiento.Cabecera.Peticiones;
using Servicios.Interfaces.Movimiento.Cabecera.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Movimiento.Cabecera
{
   public  interface IGestoDeMovimientoCabecera : IMantenimientoBase<MovicabNuevo, MovicabParaActualizar, MovicabRegistrado>
    {
    }
}
