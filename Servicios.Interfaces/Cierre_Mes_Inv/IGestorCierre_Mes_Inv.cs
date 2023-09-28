using Servicios.Interfaces.Cierre_Mes_Inv.Peticiones;
using Servicios.Interfaces.Cierre_Mes_Inv.Respuestas;
using Servicios.Interfaces.Compartido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Cierre_Mes_Inv
{
    public interface IGestorCierre_Mes_Inv : IMantenimientoBase<Cierre_Mes_InvNuevo, Cierre_Mes_InvActualizar, Cierre_Mes_InvRegistrado>
    {

        List<ListAñoMes> ExtraerAñoMes(string codEmpresa);
    }
}
