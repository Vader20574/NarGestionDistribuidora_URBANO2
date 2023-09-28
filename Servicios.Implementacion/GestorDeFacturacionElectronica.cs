using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using Servicios.Interfaces.Factura;
using Servicios.Interfaces.FacturaElectronica.Respuestas;
using Servicios.Interfaces.FacturaElectronica.Peticiones;
using Dominio.Contextos;
using Dominio.Entidades.Distribucion;
using System.Data.Entity;

namespace Servicios.Implementacion
{
    public class GestorDeFacturacionElectronica : IGestorDeFacturacionElectronica
    {
        public void AnularFE(string serie, string numero, string tipodoc)
        {
            using (DistribucionBD Bd = new DistribucionBD())
            {
                bool existe = Bd.HDocumento_.Any(x => x.serie == serie && x.nume == numero && x.comp == tipodoc && x.DarBaja != "1");
                if (existe == true)
                {
                    HDocumento hdocumento = Bd.HDocumento_.FirstOrDefault(x => x.serie.Equals(serie) && x.nume.Equals(numero) && x.comp.Equals(tipodoc) && (x.DarBaja!="1"));
                    hdocumento.DarBaja = "1";
                    hdocumento.MotivoBaja = "Anulacion";
                    hdocumento.ProcesarBaja = "0";
                    Bd.Entry(hdocumento);
                    Bd.SaveChanges();
                }

            }
        }

        public CDocumentoRegistrado CrearCDocumento(NuevaCDocumento nuevoCdocumento)
        {
            var ddocumento = Mapper.Map<CDocumento>(nuevoCdocumento);
            using (DistribucionBD Bd = new DistribucionBD())
            {
                Bd.CDocumento.Add(ddocumento);
                Bd.SaveChanges();
            }
            return Mapper.Map<CDocumentoRegistrado>(ddocumento);
        }

        public DDocumentoRegistrado CrearDdocumento(NuevaDDocumento nuevoDdocumento)
        {
            var ddocumento = Mapper.Map<DDocumento>(nuevoDdocumento);
            using (DistribucionBD Bd = new DistribucionBD())
            {
                    Bd.DDocumento_.Add(ddocumento);
                    Bd.SaveChanges();
            }
            return Mapper.Map<DDocumentoRegistrado>(ddocumento);
        }
       

        public HDocumentoRegistrado CrearHdocumento(NuevaHdocumento nuevoHdocumento)
        {
          var hdocumento = Mapper.Map<HDocumento>(nuevoHdocumento);
          using (DistribucionBD Bd = new DistribucionBD())
          {
               
                    Bd.HDocumento_.Add(hdocumento);
                    Bd.SaveChanges();
         }
         return Mapper.Map<HDocumentoRegistrado>(hdocumento);
       }

        public void ModificarEstado(string serie, string numero)
        {
            using (DistribucionBD Bd = new DistribucionBD())
            {
             
                HDocumento hdocumento = Bd.HDocumento_.FirstOrDefault(x => x.serie.Equals(serie) && x.nume.Equals(numero));
                hdocumento.esta_pod = "0";
                Bd.Entry(hdocumento);
                Bd.SaveChanges();
                
            }
        }

        
    }
}
