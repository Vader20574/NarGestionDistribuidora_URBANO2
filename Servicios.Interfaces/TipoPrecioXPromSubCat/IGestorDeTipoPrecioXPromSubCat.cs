using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.TipoPrecioXPromocion.Respuestas;
using Servicios.Interfaces.TipoPrecioXPromSubCat.Peticiones;
using Servicios.Interfaces.TipoPrecioXPromSubCat.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.TipoPrecioXPromSubCat
{
    public interface IGestorDeTipoPrecioXPromSubCat : IMantenimientoBase<TipoPrecioXPromSubCatNuevo, TipoPrecioXPromSubCatActualizar, TipoPrecioXPromSubCatRegistrado>
    {

        List<TipoPrecioXPromSubCatRegistrado> Listar(string codempresa, string codpromo, string codigo);

    }
}
