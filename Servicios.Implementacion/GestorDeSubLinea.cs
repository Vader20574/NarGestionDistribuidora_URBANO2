using AutoMapper;
using CapaDatafirst;
using Servicios.Interfaces.SubLinea;
using Servicios.Interfaces.SubLinea.Peticiones;
using Servicios.Interfaces.SubLinea.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDeSubLinea : IGestorDeSubLinea
    {
        public SubLineaRegistrado Actualizar(SubLineaActualizar registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int IdDelRegistro)
        {
            throw new NotImplementedException();
        }

        public List<SubLineaRegistrado> Filtrar(SubLineaRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public List<SubLineaRegistrado> Listar()
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.SUBLINEAs.ToList().Select(x => Mapper.Map<SubLineaRegistrado>(x)).ToList();
            }
        }

        public List<SubLineaRegistrado> Listar(string codlinea)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
          
                return db.SUBLINEAs.Where(x => (x.CODLINEA.Contains(codlinea))).ToList().Select(x => Mapper.Map<SubLineaRegistrado>(x)).ToList();

            }
        }

        public SubLineaRegistrado Registrar(SubLineaNuevo registroNuevo)
        {
            throw new NotImplementedException();
        }
    }
}
