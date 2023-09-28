using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.Facturacion.VentaCab.Peticiones;
using Servicios.Interfaces.Facturacion.VentaCab.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Facturacion.VentaCab
{
   public interface IGestorDeFacturacionVentaCab 
    {
        VentaCabRegistrado CrearVentaCab(NuevaVentacab registroNuevo);
        List<VentaCabRegistrado> Filtrar(VentaCabRegistrado registroGuardos);
        void Borrar(NuevaVentacab registroGuardos);
        VentaCabRegistrado Actualizar(VentacabActualizar registroParaActualizar);

    }
}
