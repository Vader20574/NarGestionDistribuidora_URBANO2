using Servicios.Interfaces.ClienteXPromoSubCat.Peticiones;
using Servicios.Interfaces.ClienteXPromoSubCat.Respuestas;
using Servicios.Interfaces.Compartido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.ClienteXPromoSubCat
{
    public interface IGestorClienteXPromoSubCat : IMantenimientoBase<ClienteXPromoSubCatNuevo, ClienteXPromoSubCatActualizar, ClienteXPromoSubCatRegistrado>
    {
        List<ClienteXPromoSubCatRegistrado> Listar(string codpromo);
    }
}
