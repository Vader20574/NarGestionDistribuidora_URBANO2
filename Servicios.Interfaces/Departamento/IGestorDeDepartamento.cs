using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.Departamento.Peticiones;
using Servicios.Interfaces.Departamento.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Departamento
{
    public interface IGestorDeDepartamento : IMantenimientoBase<DepartamentoNuevo, DepartamentoActualizar, DepartamentoRegistrado>
    {
    }
}
