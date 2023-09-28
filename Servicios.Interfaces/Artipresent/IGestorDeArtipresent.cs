using Servicios.Interfaces.Artipresent.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Artipresent
{
    public interface IGestorDeArtipresent
    {
        List<SelectPRECIART_Presentxproc2_Resp> SelectPRECIART_Presentxproc2(string cODEMPRESA, string cDARTI);
        List<SelectPRECIART_Presentxproc2_Resp> SelectPRECIART_PresentxprocSUBCAT(string CODEMPRESA, string CODLINEA, string SUBCODLINEA);
    }
}
