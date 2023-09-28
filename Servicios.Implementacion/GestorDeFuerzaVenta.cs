using AutoMapper;
using CapaDatafirst;
using Servicios.Interfaces.FuerzaVenta;
using Servicios.Interfaces.FuerzaVenta.Peticiones;
using Servicios.Interfaces.FuerzaVenta.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDeFuerzaVenta : IGestorDeFuerzaVenta
    {
        public FuerzaVentaRegistrado Actualizar(FuerzaVentaActualizar registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int IdDelRegistro)
        {
            throw new NotImplementedException();
        }

        public List<FuerzaVentaRegistrado> Filtrar(FuerzaVentaRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public List<FuerzaVentaRegistrado> Listar()
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.FUERZAVENTA.ToList().Select(x => Mapper.Map<FuerzaVentaRegistrado>(x)).ToList();
            }

        }

        public FuerzaVentaRegistrado Registrar(FuerzaVentaNuevo registroNuevo)
        {
            throw new NotImplementedException();
        }
    }
}
