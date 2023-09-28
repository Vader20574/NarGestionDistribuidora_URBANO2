using AutoMapper;
using CapaDatafirst;
using Servicios.Interfaces.Cierre_Mes_Inv;
using Servicios.Interfaces.Cierre_Mes_Inv.Peticiones;
using Servicios.Interfaces.Cierre_Mes_Inv.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{

    public class GestorDeCierre_Mes_Inv : IGestorCierre_Mes_Inv
    {
        public Cierre_Mes_InvRegistrado Actualizar(Cierre_Mes_InvActualizar registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int IdDelRegistro)
        {
            throw new NotImplementedException();
        }

        public List<ListAñoMes> ExtraerAñoMes(string codEmpresa)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return (db.SP_EXTRAER_AÑO_MES(codEmpresa)).ToList().Select(x => Mapper.Map<ListAñoMes>(x)).ToList();
            }
        }
        public List<Cierre_Mes_InvRegistrado> Filtrar(Cierre_Mes_InvRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public List<Cierre_Mes_InvRegistrado> Listar()
        {
            throw new NotImplementedException();
        }

        public Cierre_Mes_InvRegistrado Registrar(Cierre_Mes_InvNuevo registroNuevo)
        {
            throw new NotImplementedException();
        }
    }
}
