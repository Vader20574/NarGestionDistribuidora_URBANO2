using Servicios.Interfaces.CentroCostoPromo.Peticiones;
using Servicios.Interfaces.CentroCostoPromo.Respuestas;
using Servicios.Interfaces.Compartido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.CentroCostoPromo
{
    public interface IGestorDeCentroCostoPromo : IMantenimientoBase<Peticiones.CentroCostoPromoNuevo, CentroCostoPromoActualizar, CentroCostoPromoRegistrado>
    {
        CentroCostoPromoRegistrado FindById(int Id);

    }
}
