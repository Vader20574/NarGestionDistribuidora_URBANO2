using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.SegmentoCliente.Peticiones;
using Servicios.Interfaces.SegmentoCliente.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.SegmentoCliente
{
  public  interface IGestorSegmentoCliente : IMantenimientoBase<SegmentoClienteNuevo, SegmentoClienteActualizar, SegmentoClienteRegistrado>
    {
    }
}
