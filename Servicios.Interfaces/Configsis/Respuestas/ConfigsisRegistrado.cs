using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Configsis.Respuestas
{
    public class ConfigsisRegistrado
    {
        public string COD_EMPRESA { get; set; }
        public string CDMONBASE { get; set; }
        public string CDMONEXTR { get; set; }
        public System.DateTime FECHAPROC { get; set; }
        public decimal DECICANT { get; set; }
        public decimal DECICOST { get; set; }
        public decimal DECIPREC { get; set; }
        public decimal DECIRESU { get; set; }
        public decimal PORCENIGV { get; set; }
        public bool UNICNROFACBOL { get; set; }
        public string EMPRESA { get; set; }
        public string PTOCIERREFINDIA { get; set; }
        public bool SALIDAIMP { get; set; }
        public byte[] TSTAMP { get; set; }
        public bool TRANS { get; set; }
        public Nullable<System.DateTime> DATETRANS { get; set; }
        public Nullable<bool> ESTADO { get; set; }
        public string CODPAIS { get; set; }
        public string CODTIPOPAGO { get; set; }
        public Nullable<bool> codclie { get; set; }
        public bool MULT_NTACRED_X_NROREF { get; set; }
        public decimal NRODESPACHO { get; set; }
        public decimal NROVENTA { get; set; }
        public decimal NROCOBRANZA { get; set; }
        public Nullable<bool> ACTIVABD { get; set; }
        public Nullable<bool> ACTICAJA { get; set; }
        public Nullable<int> LIMCREDTO { get; set; }
        public Nullable<decimal> coeficiente { get; set; }
        public Nullable<decimal> PREC_BOLETA { get; set; }
        public Nullable<decimal> PREC_FACTURA { get; set; }
        public Nullable<decimal> PREC_NOTAPEDIDO { get; set; }
        public Nullable<decimal> PORCDESCUENTO { get; set; }
        public string CodAlmacen { get; set; }
        public string NPTIENDA { get; set; }
        public Nullable<int> NROCOTIZACION { get; set; }
        public Nullable<decimal> MARGENMIN { get; set; }
        public Nullable<bool> TIPODESC { get; set; }
        public Nullable<int> DiaCStk { get; set; }
        public string CORREO { get; set; }
        public string URL { get; set; }
        public string UBIGEO { get; set; }
        public string CERTELECT { get; set; }
        public string DIRECCION { get; set; }
        public Nullable<bool> EMIFACT { get; set; }
        public string resolucion { get; set; }
        public string consulta { get; set; }
        public string CodHash { get; set; }
        public string TipoOperacion { get; set; }
        public string CODDOMFISCAL { get; set; }
        public string RUTA_ARCHIVO { get; set; }
        public Nullable<decimal> MARGENMIN_PD { get; set; }
        public string nropedido { get; set; }
        public string NOSERIE { get; set; }
        public Nullable<int> CodClienteDep { get; set; }
        public Nullable<int> CodClientePri { get; set; }
    }
}
