using AutoMapper;
using CapaDatafirst;
using Servicios.Interfaces.Artipresent;
using Servicios.Interfaces.Artipresent.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDeArtipresent : IGestorDeArtipresent
    {
        public List<SelectPRECIART_Presentxproc2_Resp> SelectPRECIART_Presentxproc2(string cODEMPRESA, string cDARTI)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.SelectPRECIART_Presentxproc2(cODEMPRESA, cDARTI).ToList().Select(x => Mapper.Map<SelectPRECIART_Presentxproc2_Resp>(x)).ToList();
            }
        }

        public List<SelectPRECIART_Presentxproc2_Resp> SelectPRECIART_PresentxprocSUBCAT(string CODEMPRESA, string CODLINEA, string SUBCODLINEA)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.SelectPRECIART_PresentxprocSUBCAT(CODEMPRESA, CODLINEA, SUBCODLINEA).ToList().Select(x => Mapper.Map<SelectPRECIART_Presentxproc2_Resp>(x)).ToList();
            }

         
        }
    }
}
