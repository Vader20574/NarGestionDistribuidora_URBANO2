using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios.Interfaces.FacturaElectronica.Peticiones;
using Servicios.Interfaces.FacturaElectronica.Respuestas;

namespace Servicios.Interfaces.Factura
{
   public interface IGestorDeFacturacionElectronica
    {
        HDocumentoRegistrado CrearHdocumento(NuevaHdocumento nuevoHdocumento);
        DDocumentoRegistrado CrearDdocumento(NuevaDDocumento nuevoDdocumento);
        CDocumentoRegistrado CrearCDocumento(NuevaCDocumento nuevoCdocumento);

        void AnularFE(string serie, string numero, string tipodoc);
        void ModificarEstado(string serie, string numero);
    }
}
