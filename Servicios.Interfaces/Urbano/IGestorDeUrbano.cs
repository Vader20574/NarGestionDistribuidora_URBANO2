using Servicios.Interfaces.Urbano.Peticiones;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicios.Interfaces.Urbano
{
    public interface IGestorDeUrbano
    {

        Clientex select_clientex(string codcliente);
    }
}
