using AutoMapper;
using CapaDatafirst;
using Servicios.Interfaces.TipoCredito;
using Servicios.Interfaces.TipoCredito.Peticiones;
using Servicios.Interfaces.TipoCredito.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDeTipoCredito : IGestorDeTipoCredito
    {
        public TipoCreditoRegistrado Actualizar(TipoCreditoActualizar registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int IdDelRegistro)
        {
            throw new NotImplementedException();
        }

        public List<TipoCreditoRegistrado> Filtrar(TipoCreditoRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public List<TipoCreditoRegistrado> Listar()
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.TIPCREDF.ToList().Select(x => Mapper.Map<TipoCreditoRegistrado>(x)).ToList();
            }
        }

        public TipoCreditoRegistrado Registrar(TipoCreditoNuevo registroNuevo)
        {
            throw new NotImplementedException();
        }
    }
}
