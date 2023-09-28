using Servicios.Interfaces.ClieFuerza.Peticiones;
using Servicios.Interfaces.ClieFuerza.Respuestas;
using Servicios.Interfaces.Compartido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.ClieFuerza
{
   public interface IGestorDeClieFuerza : IMantenimientoBase<ClieFuerzaNuevo, ClieFuerzaActualizar, ClieFuerzaRegistrado>
    {


        List<ClieFuerzaListar> ListarXClieFuerza(ClieFuerzaRegistrado cliefuerzaregistrados);
        //List<ClieFuerzaListar> ListarXCodCliente(ClieFuerzaRegistrado cliefuerzaregistrados);

        void EliminarXCliente(string codcliente);

    }
}
