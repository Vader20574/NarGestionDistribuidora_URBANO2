using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.SupervisorVendedor.Peticiones;
using Servicios.Interfaces.SupervisorVendedor.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.SupervisorVendedor
{
    public interface IGestorDeSupervisorVendedor : IMantenimientoBase<SupervisorVendedorNuevo, SupervisorVendedorActualizar, SupervisorVendedorRegistrado>
    {
        List<SupervisorVendedorRegistrado> ListarxCodSupervisor(string codsuperv);

        bool Borrar2(int IdDelRegistro);
        void BorrarxCodSupervisor(string IdDelRegistro);

    }
}
