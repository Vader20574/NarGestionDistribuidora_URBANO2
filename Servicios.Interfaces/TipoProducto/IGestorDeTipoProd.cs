using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.TipoProducto.Peticiones;
using Servicios.Interfaces.TipoProducto.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.TipoProducto
{
    public interface IGestorDeTipoProd : IMantenimientoBase<TipoProdNuevo, TipoProdActualizar, TipoProdRegistrado>
    {

    }
}
