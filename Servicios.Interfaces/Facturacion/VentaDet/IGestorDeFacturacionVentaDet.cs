using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.Facturacion.VentaDet.Peticiones;
using Servicios.Interfaces.Facturacion.VentaDet.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Facturacion.VentaDet
{
    public interface IGestorDeFacturacionVentaDet : IMantenimientoBase<NuevaVentaDet, VentaDetActualizar, VentaDetRegistrado>
    {
    }
}
