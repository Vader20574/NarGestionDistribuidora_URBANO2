using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.VentaxCobrar
{
   public interface IGestorDeVentaxCobrar
    {
        void ModificarCodVend( string TipoDoc, decimal NroDoc, string codClienteDep, string CodVend);
    }
}
