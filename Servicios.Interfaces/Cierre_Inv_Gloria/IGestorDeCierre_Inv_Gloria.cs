using Servicios.Interfaces.Cierre_Inv_Gloria.Peticiones;
using Servicios.Interfaces.Cierre_Inv_Gloria.Respuestas;
using Servicios.Interfaces.Compartido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Cierre_Inv_Gloria
{
    public interface IGestorDeCierre_Inv_Gloria : IMantenimientoBase<Cierre_Inv_GloriaNuevo, Cierre_Inv_GloriaActualizar, Cierre_Inv_GloriaRegistrado>
    {
        void BorrarTodo();

    }
}
