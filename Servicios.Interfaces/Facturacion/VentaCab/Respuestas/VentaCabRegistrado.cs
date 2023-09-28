using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Facturacion.VentaCab.Respuestas
{
    public class VentaCabRegistrado
    {
        public string CODEMPRESA { get; set; }
        public string CODTIPODOC { get; set; }
        public string NRODOCU { get; set; }
        public string CODMON { get; set; }
        public Nullable<decimal> CAMBIO { get; set; }
        public string CODTIPOPAGO { get; set; }
        public string CODVEND { get; set; }
        public string ESTADO { get; set; }
        public System.DateTime FECDOCUM { get; set; }
        public System.DateTime FECPROCESO { get; set; }
        public string CODIMPUESTO { get; set; }
        public decimal TOTBAS { get; set; }
        public Nullable<decimal> TOTEXT { get; set; }
        public decimal SUBTOTBAS { get; set; }
        public Nullable<decimal> SUBTOTEXT { get; set; }
        public decimal IGVBAS { get; set; }
        public Nullable<decimal> IGVEXT { get; set; }
        public decimal TOTNOAFECTBAS { get; set; }
        public decimal TOTNOAFECTEXT { get; set; }
        public decimal PORCENDESC1 { get; set; }
        public decimal PORCENDESC2 { get; set; }
        public decimal TOTDESCBAS { get; set; }
        public decimal TOTDESCEXT { get; set; }
        public decimal TOTVUELTOBAS { get; set; }
        public decimal TOTVUELTOEXT { get; set; }
        public decimal TOTCASHBAS { get; set; }
        public decimal TOTCASHEXT { get; set; }
        public string CODCLIENTE { get; set; }
        public string RUCCLIENTE { get; set; }
        public string DESCLIENTE { get; set; }
        public string DIRCLIENTE { get; set; }
        public bool CIERREZ { get; set; }
        public string CDUSUARIO { get; set; }
        public string NROPTOVTA { get; set; }
        public Nullable<System.DateTime> FECANULA { get; set; }
        public string CDTIPOANULA { get; set; }
        public string CDZONA { get; set; }
        public string NROGUIA { get; set; }
        public byte[] TSTAMP { get; set; }
        public string CODDEP { get; set; }
        public string OBSERV { get; set; }
        public Nullable<bool> POSTPAGO { get; set; }
        public Nullable<decimal> IPERCEP { get; set; }
        public string Hora { get; set; }
        public Nullable<decimal> DESC_FINANCIERO { get; set; }
        public string EXISTE { get; set; }
        public string ENVIO { get; set; }
        public string CODHASH { get; set; }
        public string NUMDOC { get; set; }
        public string SERIE { get; set; }
        public int ID { get; set; }
    }
}
