using CapaDatafirst;
using Servicios.Interfaces.Cliente.Peticiones;
using Servicios.Interfaces.Cliente.Respuestas;
using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.Facturacion.VentaCab.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Cliente
{
    public interface IGestorDeCliente : IMantenimientoBase<ClienteNuevo, ClienteActualizar, ClienteRegistrado>
    {
 
        List<ClienteRegistrado> FiltrarxTodos(ClienteRegistrado registroGuardos);

        List<CIienteSelecionado1> FiltrarxTodos2(CIienteSelecionado1 registroGuardos);

        ClienteRegistrado FindById(string Id);
        List<ClienteRegistrado> FiltrarxCodCliente(ClienteRegistrado registroGuardos);

        double CobranzaXCliente(string codempresa,string codcliente);
        decimal SumPedidos(string codcliente);

        List<ClienteRegistrado> FiltrarxDatoAdjunto1(string DatoAdjunto);
        List<ClienteRegistrado> FiltrarxDatoAdjunto2(string DatoAdjunto, string codcliente);
        //Var extraer_Año_Mes(string codempresa);  
        int Busq_clie_vta(string codempresa, string coddep,string ventacab);
        string Busq_clie_ped(string codempresa, string codcliente);


        void EliminarCliente(string codcliente);

        void EliminarSusClidep(string codempresa, string codcliente);

        int Busq_cliedep_vta(string codempresa, string coddep, string ventacab);

    }
}
