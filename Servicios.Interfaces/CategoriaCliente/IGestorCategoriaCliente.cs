using Servicios.Interfaces.CategoriaCliente.Peticiones;
using Servicios.Interfaces.CategoriaCliente.Respuestas;
using Servicios.Interfaces.Compartido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.CategoriaCliente
{
   public interface IGestorCategoriaCliente : IMantenimientoBase<CategoriaClienteNuevo, CategoriaClienteActualizar, CategoriaClienteRegistrado>
    {
    }
}
