using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.Supervisor.Peticiones;
using Servicios.Interfaces.Supervisor.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Supervisor
{
   public interface IGestorDeSupervisor : IMantenimientoBase<SupervisorNuevo, SupervisorActualizar, SupervisorRegistrado>
    {
        void Borrar(string IdDelRegistro);

    }
}
