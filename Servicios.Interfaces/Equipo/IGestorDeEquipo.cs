using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.Equipo.Peticiones;
using Servicios.Interfaces.Equipo.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Equipo
{
    public interface IGestorDeEquipo : IMantenimientoBase<EquipoNuevo, EquipoActualizar, EquipoRegistrado>
    {
        void Borrar(string CodCliente);
        EquipoRegistrado FindById(string Id);
    }
}
