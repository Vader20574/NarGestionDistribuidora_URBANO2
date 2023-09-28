using Servicios.Interfaces.Almacen.Peticiones;
using Servicios.Interfaces.Almacen.Respuestas;
using Servicios.Interfaces.Compartido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Almacen
{
    public interface IGestorDeAlmacen : IMantenimientoBase<AlmacenNuevo, AlmacenActualizar, AlmacenRegistrado>
    {
    }
}
