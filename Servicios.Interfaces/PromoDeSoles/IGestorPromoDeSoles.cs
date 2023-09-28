using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.PromoDeSoles.Peticiones;
using Servicios.Interfaces.PromoDeSoles.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.PromoDeSoles
{
    public interface IGestorPromoDeSoles : IMantenimientoBase<PromoDeSolesNuevo, PromoDeSolesActualizar, PromoDeSolesRegistrado>
    {
        PromoDeSolesRegistrado FindById(string Id);
        void Borrar(string codemp, string codpromo);
    }
}
