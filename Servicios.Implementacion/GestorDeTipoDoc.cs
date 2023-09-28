using Servicios.Interfaces.TipoDoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios.Interfaces.TipoDoc.Peticiones;
using Servicios.Interfaces.TipoDoc.Respuestas;
using CapaDatafirst;
using AutoMapper;

namespace Servicios.Implementacion
{
    public class GestorDeTipoDoc : IGestorDeTipoDoc
    {
        public TipoDocRegistrado Actualizar(TipoDocActualizar registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int IdDelRegistro)
        {
            throw new NotImplementedException();
        }

        public List<TipoDocRegistrado> Filtrar(TipoDocRegistrado registroGuardos)
        {
           throw new NotImplementedException();
        }

        public List<TipoDocRegistrado> Listar()
        {
           
           using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.TIPODOC.ToList().Select(x => Mapper.Map<TipoDocRegistrado>(x)).ToList();

            }
        }

        public TipoDocRegistrado Registrar(TipoDocNuevo registroNuevo)
        {
            throw new NotImplementedException();
        }
    }
}
