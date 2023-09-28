using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.Jefe_Equipo.Peticiones;
using Servicios.Interfaces.Jefe_Equipo.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Jefe_Equipo
{
    public interface IGestorDeJefe_Equipo : IMantenimientoBase<Jefe_EquipoNuevo, Jefe_EquipoActualizar, Jefe_EquipoRegistro>
    {
        Jefe_EquipoRegistro FindById(int Id);
    }
}
