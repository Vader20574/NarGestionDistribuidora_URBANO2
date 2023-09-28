using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios.Interfaces.TipoNegocio.Peticiones;
using Servicios.Interfaces.TipoNegocio.Respuestas;
using Servicios.Interfaces.TipoPrecio;
using CapaDatafirst;
using AutoMapper;
using Servicios.Interfaces.TipoPrecio.Peticiones;
using Servicios.Interfaces.TipoPrecio.Respuestas;

namespace Servicios.Implementacion
{
    public class GestorDeTipoPrecio : IGestorDeTipoPrecio
    {
        public TipoPrecioRegistrado Actualizar(TipoPrecioActualizar registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int IdDelRegistro)
        {
            throw new NotImplementedException();
        }

        public List<TipoPrecioRegistrado> Filtrar(TipoPrecioRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public List<TipoPrecioRegistrado> Listar()
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.TIPOPRE.ToList().Select(x => Mapper.Map<TipoPrecioRegistrado>(x)).ToList();

            }
        }

        public TipoPrecioRegistrado Registrar(TipoPrecioNuevo registroNuevo)
        {
            throw new NotImplementedException();
        }
    }
}
