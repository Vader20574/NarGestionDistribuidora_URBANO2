using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.Vendedor.Peticiones;
using Servicios.Interfaces.Vendedor.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Vendedor
{
    public interface IGestorDeVendedor : IMantenimientoBase<VendedorNuevo, VendedorActualizar, VendedorRegistrado>
    {
    }
}
