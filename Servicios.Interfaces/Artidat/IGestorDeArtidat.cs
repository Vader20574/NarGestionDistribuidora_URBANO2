using Servicios.Interfaces.Artidat.Peticiones;
using Servicios.Interfaces.Artidat.Respuestas;
using Servicios.Interfaces.Compartido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Artidat
{
    public interface IGestorDeArtidat : IMantenimientoBase<ArtidatNuevo, ArtidatActualizar, ArtidatRegistrado>
    {

    }
}
