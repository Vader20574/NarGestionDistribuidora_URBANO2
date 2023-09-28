using AutoMapper;
using CapaDatafirst;
using Servicios.Interfaces.TipoPago;
using Servicios.Interfaces.TipoPago.Peticiones;
using Servicios.Interfaces.TipoPago.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDeTipoPago : IGestorDeTipoPago
    {
        public TipoPagoRegistrado Actualizar(TipoPagoActualizar registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int IdDelRegistro)
        {
            throw new NotImplementedException();
        }

        public List<TipoPagoRegistrado> Filtrar(TipoPagoRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public List<TipoPagoRegistrado> Listar()
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.TIPO_PAGO.ToList().Select(x => Mapper.Map<TipoPagoRegistrado>(x)).ToList();
            }
        }

        public TipoPagoRegistrado Registrar(TipoPagoNuevo registroNuevo)
        {
            throw new NotImplementedException();
        }
    }
}
