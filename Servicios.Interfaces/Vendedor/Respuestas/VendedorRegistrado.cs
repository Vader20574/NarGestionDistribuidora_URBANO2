using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Vendedor.Respuestas
{
    public class VendedorRegistrado
    {
        public string CODEMPRESA { get; set; }
        public string CODVEND { get; set; }
        public string DSVEND { get; set; }
        public string DNI { get; set; }
        public string DIRECCION { get; set; }

        public bool ESTADO { get; set; }
        public string TELEFONO { get; set; }
        public DateTime FECHA_REF { get; set; }
        public string CODZONA { get; set; }
        public string CODCIUDAD { get; set; }
        public string COD_FV { get; set; }
        public string COD_ZV { get; set; }
        public decimal NROPEDIDO { get; set; }
        public bool TIPOVEND { get; set; }

        public decimal LINEACRED { get; set; }
        public string TIPOCOMISION { get; set; }

    }
}
