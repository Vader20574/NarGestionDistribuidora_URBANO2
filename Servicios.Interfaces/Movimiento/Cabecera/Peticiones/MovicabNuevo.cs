using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Servicios.Interfaces.Movimiento.Cabecera.Peticiones
{
   
   public class MovicabNuevo
    {

        public string CODEMPRESA { get; set; }
        public decimal NROMOVI { get; set; }
        public string CDALMACEN { get; set; }
        public string CDTIPOMOV { get; set; }
        public string CDPROVEE { get; set; }
        public string CDTIPODOC { get; set; }
        public Nullable<int> INOUT { get; set; }
        public string NRODOC { get; set; }
        public System.DateTime FECDOCUM { get; set; }
        public System.DateTime FECPROCESO { get; set; }
        public string ESTADO { get; set; }
        public string CDMONEDA { get; set; }
        public decimal SUBTOTBAS { get; set; }
        public decimal SUBTOTEXT { get; set; }
        public Nullable<decimal> CAMBIO { get; set; }
        public decimal IGVBAS { get; set; }
        public decimal IGVEXT { get; set; }
        public decimal TOTBAS { get; set; }
        public decimal TOTEXT { get; set; }
        public decimal PORCENDESC { get; set; }
        public decimal MONTODESCBAS { get; set; }
        public decimal MONTODESCEXT { get; set; }
        public string ALMATRAN { get; set; }
        public string USERID { get; set; }
        public string PERIODO { get; set; }
        public string EJERCICIO { get; set; }
        public byte[] TSTAMP { get; set; }
        public Nullable<System.DateTime> DATETRANS { get; set; }
        public string OBS { get; set; }
        public string cdalmacensal { get; set; }
        public Nullable<bool> CRED { get; set; }
        public string tipocred { get; set; }
        public string PTOVTA { get; set; }
        public decimal FLETE { get; set; }
        public bool TRANS { get; set; }
        public Nullable<decimal> PERCEPCION { get; set; }
        public Nullable<decimal> DETRACCION { get; set; }
        public Nullable<System.DateTime> FECHARECEPC { get; set; }
        public Nullable<int> INOUT2 { get; set; }
        public string text1 { get; set; }
        public string text2 { get; set; }
        public string text3 { get; set; }
        public Nullable<bool> cost { get; set; }

    }
}
