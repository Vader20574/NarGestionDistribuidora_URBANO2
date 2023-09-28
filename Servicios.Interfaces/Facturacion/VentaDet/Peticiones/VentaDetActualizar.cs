using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Facturacion.VentaDet.Peticiones
{
    public class VentaDetActualizar
    {

        public string CODEMPRESA { get; set; }
        public string CODTIPODOC { get; set; }
        public string NRODOCU { get; set; }
        public decimal ITEM { get; set; }
        public string CODARTI { get; set; }
        public string DESARTI { get; set; }
        public string CODTIPOMED { get; set; }
        public string DESTIPOMED { get; set; }
        public string CODMON { get; set; }
        public string CODALMACEN { get; set; }
        public string ESTADO { get; set; }
        public string CODPRES { get; set; }
        public string DESPRES { get; set; }
        public decimal CANTIDAD { get; set; }
        public decimal PRECIO { get; set; }
        public decimal PRECIOVTA { get; set; }
        public decimal TOTBAS { get; set; }
        public Nullable<decimal> TOTEXT { get; set; }
        public decimal IGVBAS { get; set; }
        public Nullable<decimal> IGVEXT { get; set; }
        public decimal SUBTOTBAS { get; set; }
        public Nullable<decimal> SUBTOTEXT { get; set; }
        public decimal COSTOBAS { get; set; }
        public decimal COSTOEXT { get; set; }
        public System.DateTime FECDOCUM { get; set; }
        public System.DateTime FECPROCESO { get; set; }
        public string CODIMPUESTO { get; set; }
        public bool FORMU { get; set; }
        public string cdusuario { get; set; }
        public Nullable<bool> CONSUMO { get; set; }
        public bool INVFISI { get; set; }
        public Nullable<decimal> MONTODESCBAS { get; set; }
        public Nullable<decimal> PORCENDESC { get; set; }
        public string NROPTOVTA { get; set; }
        public Nullable<bool> TIPOMEDIDA { get; set; }
        public string NROGUIA { get; set; }
        public string CODPROMO { get; set; }

        public string CODFACELEC { get; set; }

        public decimal PERCEPCION { get; set; }

        public string TIPO_IGV { get; set; }
    }
}
