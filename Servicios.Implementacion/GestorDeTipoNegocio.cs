using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios.Interfaces.TipoNegocio;
using Servicios.Interfaces.TipoNegocio.Peticiones;
using Servicios.Interfaces.TipoNegocio.Respuestas;
using CapaDatafirst;
using AutoMapper;

namespace Servicios.Implementacion
{
    public class GestorDeTipoNegocio : IGestorDeTipoNegocio
    {
        public TipoNegocioRegistrado Actualizar(TipoNegocioActualizar registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int IdDelRegistro)
        {
            throw new NotImplementedException();
        }

        public List<TipoNegocioRegistrado> Filtrar(TipoNegocioRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public List<TipoNegocioRegistrado> Listar()
        {

            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.TIPONEGOCIO.ToList().Select(x => Mapper.Map<TipoNegocioRegistrado>(x)).ToList();
            }

        }

        public TipoNegocioRegistrado Registrar(TipoNegocioNuevo registroNuevo)
        {
            throw new NotImplementedException();
        }
    }
}
