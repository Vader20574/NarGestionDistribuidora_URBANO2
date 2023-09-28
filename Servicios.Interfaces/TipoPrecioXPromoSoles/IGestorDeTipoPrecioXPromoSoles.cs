using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.TipoPrecioXPromoSoles.Peticiones;
using Servicios.Interfaces.TipoPrecioXPromoSoles.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.TipoPrecioXPromoSoles
{
    public interface IGestorDeTipoPrecioXPromoSoles : IMantenimientoBase<TipoPrecioXPromoSolesNuevo, TipoPrecioXPromoSolesAct, TipoPrecioXPromoSolesReg>
    {
        List<TipoPrecioXPromoSolesReg> Listar(string codempresa, string codpromo, string codigo);

    }
}
