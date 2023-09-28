using Servicios.Interfaces.ClienteXPromo.Peticiones;
using Servicios.Interfaces.ClienteXPromo.Respuestas;
using Servicios.Interfaces.Compartido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.ClienteXPromo
{
    public interface IGestorClienteXPromo : IMantenimientoBase<ClienteXPromoNuevo, ClienteXPromoAct, ClienteXPromoRegistrado>
    {
        List<ClienteXPromoRegistrado> Listar(string codpromo);

    }
}
