using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.TipoPrecioXPromocion.Peticiones;
using Servicios.Interfaces.TipoPrecioXPromocion.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.TipoPrecioXPromocion
{
    public interface IGestorDeTipoPrecioXPromocion : IMantenimientoBase<TipoPrecioXPromNuevo, TipoPrecioXPromActualizar, TipoPrecioXPromRegistrado>
    {

        List<TipoPrecioXPromRegistrado> Listar(string codempresa, string codpromo, string codigo);

 

    }
}
