using AutoMapper;
using CapaDatafirst;
using Servicios.Interfaces.TipoPrecioXPromocion.Respuestas;
using Servicios.Interfaces.TipoPrecioXPromSubCat;
using Servicios.Interfaces.TipoPrecioXPromSubCat.Peticiones;
using Servicios.Interfaces.TipoPrecioXPromSubCat.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDeTipoPrecioXPromSubCat : IGestorDeTipoPrecioXPromSubCat
    {
        public TipoPrecioXPromSubCatRegistrado Actualizar(TipoPrecioXPromSubCatActualizar registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int IdDelRegistro)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                var tipoprecpromo = db.TipoPrecioXPromocionSubCats.FirstOrDefault(x => x.ID == IdDelRegistro);// object your want to delete
                if (tipoprecpromo != null)
                {
                    db.TipoPrecioXPromocionSubCats.Remove(tipoprecpromo);
                    db.SaveChanges();
                }
            }
        }

        public List<TipoPrecioXPromSubCatRegistrado> Filtrar(TipoPrecioXPromSubCatRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public List<TipoPrecioXPromSubCatRegistrado> Listar()
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.TipoPrecioXPromocionSubCats.ToList().Select(x => Mapper.Map<TipoPrecioXPromSubCatRegistrado>(x)).ToList();

            }
        }

        public List<TipoPrecioXPromSubCatRegistrado> Listar(string codempresa, string codpromo, string codigo)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.TipoPrecioXPromocionSubCats.Where(x => (x.CODEMPRESA.Contains(codempresa)) && (x.CODPROMO.Contains(codpromo)) && (x.CODIGO.Contains(codigo))).ToList().Select(x => Mapper.Map<TipoPrecioXPromSubCatRegistrado>(x)).ToList();

            }
        }

        public TipoPrecioXPromSubCatRegistrado Registrar(TipoPrecioXPromSubCatNuevo registroNuevo)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                TipoPrecioXPromocionSubCat nuevoEquipo = Mapper.Map<TipoPrecioXPromocionSubCat>(registroNuevo);
                db.TipoPrecioXPromocionSubCats.Add(nuevoEquipo);
                db.SaveChanges();
                return Mapper.Map<TipoPrecioXPromSubCatRegistrado>(nuevoEquipo);
            }
        }
    }
}
