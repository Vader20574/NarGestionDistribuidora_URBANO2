using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.TmpStockPedido.Peticiones;
using Servicios.Interfaces.TmpStockPedido.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.TmpStockPedido
{
    public interface IGestorDeTmpStockPedido : IMantenimientoBase<TmpStockPedidoNuevo, TmpStockPedidoActualizar, TmpStockPedidoRegistrado>
    {
        List<TmpStockPedidoRegistrado> Listar(string codempresa, int Correl);
        int Extraer_Stock(string codarti, string alm, string correl);
        void UPDATE_TMP_STOCKPEDIDO(string codemp, int correl, string codarti, decimal stk);

    }
}
