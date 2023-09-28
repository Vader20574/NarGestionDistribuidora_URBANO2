using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.Configsis.Peticiones;
using Servicios.Interfaces.Configsis.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Configsis
{
    public interface IGestorDeConfigsis : IMantenimientoBase<ConfigsisNuevo, ConfigsisActualizar, ConfigsisRegistrado>
    {

        ConfigsisRegistrado FindById(string Id);
        ConfigsisRegistrado Actualizar_codclientedep(ConfigsisRegistrado configsis_registrado);
        ConfigsisRegistrado Actualizar_codclientepri(ConfigsisRegistrado configsis_registrado);

    }
}
