using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.TipoPagoXPromocion.Peticiones;
using Servicios.Interfaces.TipoPagoXPromocion.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.TipoPagoXPromocion
{
    public interface IGestorDeTipoPagoXProm : IMantenimientoBase<TipoPagoXPromNuevo, TipoPagoXPromActualizar, TipoPagoXPromRegistrado>
    {

        List<TipoPagoXPromRegistrado> Listar( string codpromo);
   

    }
}
