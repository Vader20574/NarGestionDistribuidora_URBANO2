using Servicios.Interfaces.CliDep.Peticiones;
using Servicios.Interfaces.CliDep.Respuestas;
using Servicios.Interfaces.Compartido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.CliDep
{
   public interface IGestorDeCliDep : IMantenimientoBase<CliDepNuevo, CliDepActualizar, CliDepRegistrado>
    {
        CliDepRegistrado FindById(string Id);

        List<CliDepRegistrado> ListarXCodCliente(CliDepRegistrado clidepregistrados);
        List<CliDepRegistradoMasOK> ListarXCodDep(CliDepRegistradoMasOK clidepregistrados);
        string Busq_dep_cliente(string codempresa, string codcliente);

        void EliminarClidep(string codempresa, string coddep);

        string Busq_dep_DatoAdjunto(string codempresa, string datoadjunto);
        string Busq_dep_DatoAdjunto2(string codempresa, string datoadjunto, string codclidep);

    }



}
