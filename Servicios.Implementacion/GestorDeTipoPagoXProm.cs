using AutoMapper;
using CapaDatafirst;
using Servicios.Interfaces.TipoPagoXPromocion;
using Servicios.Interfaces.TipoPagoXPromocion.Peticiones;
using Servicios.Interfaces.TipoPagoXPromocion.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDeTipoPagoXProm : IGestorDeTipoPagoXProm
    {
        public TipoPagoXPromRegistrado Actualizar(TipoPagoXPromActualizar registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int IdDelRegistro)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                var tipopagopromo = db.TipoPagoXPromocions.FirstOrDefault(x => x.Id == IdDelRegistro);// object your want to delete
                if (tipopagopromo != null)
                {
                    db.TipoPagoXPromocions.Remove(tipopagopromo);
                    db.SaveChanges();
                }
            }
        }



        public List<TipoPagoXPromRegistrado> Filtrar(TipoPagoXPromRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public List<TipoPagoXPromRegistrado> Listar()
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.TipoPagoXPromocions.ToList().Select(x => Mapper.Map<TipoPagoXPromRegistrado>(x)).ToList();

            }
        }

        public List<TipoPagoXPromRegistrado> Listar(string codpromo)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.TipoPagoXPromocions.Where(x => (x.CODPROMO.Contains(codpromo)) ).ToList().Select(x => Mapper.Map<TipoPagoXPromRegistrado>(x)).ToList();

            }
        }

        public TipoPagoXPromRegistrado Registrar(TipoPagoXPromNuevo registroNuevo)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                TipoPagoXPromocion nuevoEquipo = Mapper.Map<TipoPagoXPromocion>(registroNuevo);
                db.TipoPagoXPromocions.Add(nuevoEquipo);
                db.SaveChanges();
                return Mapper.Map<TipoPagoXPromRegistrado>(nuevoEquipo);
            }
        }
    }
}
