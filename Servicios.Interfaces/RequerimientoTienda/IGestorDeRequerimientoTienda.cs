using Servicios.Interfaces.RequerimientoTienda.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.RequerimientoTienda
{
    public interface IGestorDeRequerimientoTienda
    {
        List<RequerimientoTiendaReg> ListarRequerimientoTienda(string FecIni, string FecFin);
    }
}
