using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.TmpStockPedido.Peticiones
{
    public class TmpStockPedidoActualizar
    {

        public int CORREL { get; set; }
        public string CODEMPRESA { get; set; }
        public string CODARTI { get; set; }
        public string DESARTI { get; set; }
        public decimal STOCK_PEDIDO_UND { get; set; }
        public decimal STOCK_ACT_UND { get; set; }
        public decimal STOCK_FALT_UND { get; set; }
        public decimal STOCK_FALT_PAQ { get; set; }
        public string CODPRESM { get; set; }
        public string CODPRESU { get; set; }
        public string DESPRESU { get; set; }
        public string DESPRESM { get; set; }
        public string NUM_PEDIDO { get; set; }
        public int Id { get; set; }

    }
}
