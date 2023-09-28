using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.EquipoVendedor.Peticiones;
using Servicios.Interfaces.EquipoVendedor.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.EquipoVendedor
{
    public interface IGestoDeEquipoVendedor : IMantenimientoBase<Equipo_VendedorNuevo, Equipo_VendedorActualizar, Equipo_VendedorRegistrado>
    {
        Equipo_VendedorRegistrado FindById(int Id);

    }
}
