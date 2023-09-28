using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.TipoPagoXPromSubCat.Peticiones;
using Servicios.Interfaces.TipoPagoXPromSubCat.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.TipoPagoXPromSubCat
{
    public interface IGestorDeTipoPagoXPromSubCat : IMantenimientoBase<TipoPagoXPromSubCatNuevo, TipoPagoXPromSubCatActualizar, TipoPagoXPromSubCatRegistrado>
    {
        List<TipoPagoXPromSubCatRegistrado> Listar(string codpromo);

    }
}
