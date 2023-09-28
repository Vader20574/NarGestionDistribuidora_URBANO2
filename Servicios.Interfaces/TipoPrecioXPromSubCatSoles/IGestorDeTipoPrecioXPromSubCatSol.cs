using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.TipoPrecioXPromSubCatSoles.Peticiones;
using Servicios.Interfaces.TipoPrecioXPromSubCatSoles.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.TipoPrecioXPromSubCatSoles
{
    public interface IGestorDeTipoPrecioXPromSubCatSol : IMantenimientoBase<TipoPrecioXPromSubCatSolNuevo, TipoPrecioXPromSubCatSolAct, TipoPrecioXPromSubCatSolReg>
    {

        List<TipoPrecioXPromSubCatSolReg> Listar(string codempresa, string codlinea, string codigo);
    }
}
