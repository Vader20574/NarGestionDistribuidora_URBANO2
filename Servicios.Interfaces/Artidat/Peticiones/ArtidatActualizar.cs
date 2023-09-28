using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Artidat.Peticiones
{
    public class ArtidatActualizar
    {

        public string CODEMPRESA { get; set; }
        public string CODALMACEN { get; set; }
        public string CODARTI { get; set; }
        public Nullable<System.DateTime> DATETRANS { get; set; }
        public Nullable<bool> TRANS { get; set; }
        public Nullable<bool> ESTADO { get; set; }
        public Nullable<System.DateTime> ULTSAL { get; set; }
        public Nullable<System.DateTime> ULTING { get; set; }
        public Nullable<decimal> COSTEXTRM { get; set; }
        public Nullable<decimal> COSTEXTRU { get; set; }
        public Nullable<decimal> COSTBASEM { get; set; }
        public Nullable<decimal> COSTBASEU { get; set; }
        public Nullable<decimal> STKINIM { get; set; }
        public Nullable<decimal> STKINIU { get; set; }
        public Nullable<decimal> STKACTM { get; set; }
        public Nullable<decimal> STKACTU { get; set; }
        public Nullable<decimal> STKMAXM { get; set; }
        public Nullable<decimal> STKMAXU { get; set; }
        public Nullable<decimal> STKMINM { get; set; }
        public Nullable<decimal> STKMINU { get; set; }
        public string UBICAJE { get; set; }
        public string NROING { get; set; }
        public string NROSAL { get; set; }
        public Nullable<System.DateTime> FECH_COMP { get; set; }


    }
}
