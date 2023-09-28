using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Vendedor.Peticiones
{
    public class VendedorActualizar
    {
        public string CODEMPRESA { get; set; }
        public string CODVEND { get; set; }
        public string DSVEND { get; set; }
        public string DNI { get; set; }
        public string DIRECCION { get; set; }
        public Nullable<bool> ESTADO { get; set; }
        public Nullable<System.DateTime> DATETRANS { get; set; }
        public Nullable<bool> trans { get; set; }
        public string TELEFONO { get; set; }
        public Nullable<System.DateTime> FECHA_REF { get; set; }
        public string CODZONA { get; set; }
        public string CODCIUDAD { get; set; }
        public string COD_FV { get; set; }
        public string COD_ZV { get; set; }
        public decimal NROPEDIDO { get; set; }
        public Nullable<bool> TIPOVEND { get; set; }
        public Nullable<decimal> LINEACRED { get; set; }
        public string TIPOCOMISION { get; set; }

    }
}
