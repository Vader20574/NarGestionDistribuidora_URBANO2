using AutoMapper;
using CapaDatafirst;
using Servicios.Interfaces.TipoPagoXPromSubCat;
using Servicios.Interfaces.TipoPagoXPromSubCat.Peticiones;
using Servicios.Interfaces.TipoPagoXPromSubCat.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDeTipoPagoXPromSubCat : IGestorDeTipoPagoXPromSubCat
    {
        public TipoPagoXPromSubCatRegistrado Actualizar(TipoPagoXPromSubCatActualizar registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int IdDelRegistro)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                var tipopagopromo = db.TipoPagoXPromocionSubs.FirstOrDefault(x => x.ID == IdDelRegistro);// object your want to delete
                if (tipopagopromo != null)
                {
                    db.TipoPagoXPromocionSubs.Remove(tipopagopromo);
                    db.SaveChanges();
                }
            }
        }

        public List<TipoPagoXPromSubCatRegistrado> Filtrar(TipoPagoXPromSubCatRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public List<TipoPagoXPromSubCatRegistrado> Listar()
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.TipoPagoXPromocionSubs.ToList().Select(x => Mapper.Map<TipoPagoXPromSubCatRegistrado>(x)).ToList();

            }
        }

        public List<TipoPagoXPromSubCatRegistrado> Listar(string codpromo)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.TipoPagoXPromocionSubs.Where(x => (x.CODPROMO==codpromo)).ToList().Select(x => Mapper.Map<TipoPagoXPromSubCatRegistrado>(x)).ToList();

            }
        }

        public TipoPagoXPromSubCatRegistrado Registrar(TipoPagoXPromSubCatNuevo registroNuevo)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                TipoPagoXPromocionSub nuevoEquipo = Mapper.Map<TipoPagoXPromocionSub>(registroNuevo);
                db.TipoPagoXPromocionSubs.Add(nuevoEquipo);
                db.SaveChanges();
                return Mapper.Map<TipoPagoXPromSubCatRegistrado>(nuevoEquipo);
            }
        }
    }
}
