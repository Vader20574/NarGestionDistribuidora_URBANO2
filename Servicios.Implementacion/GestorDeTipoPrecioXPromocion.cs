using AutoMapper;
using CapaDatafirst;
using Dominio.Contextos;
using Dominio.Entidades.Modelo;
using Servicios.Interfaces.TipoPrecioXPromocion;
using Servicios.Interfaces.TipoPrecioXPromocion.Peticiones;
using Servicios.Interfaces.TipoPrecioXPromocion.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDeTipoPrecioXPromocion : IGestorDeTipoPrecioXPromocion
    {
        public TipoPrecioXPromRegistrado Actualizar(TipoPrecioXPromActualizar registroParaActualizar)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {

                throw new NotImplementedException();

            }
        }

        public void Borrar(int IdDelRegistro)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                var tipoprecpromo = db.TipoPrecioXPromocions.FirstOrDefault(x => x.Id== IdDelRegistro);// object your want to delete
                if (tipoprecpromo != null)
                {
                    db.TipoPrecioXPromocions.Remove(tipoprecpromo);
                    db.SaveChanges();
                }
            }
        }

      

        public List<TipoPrecioXPromRegistrado> Filtrar(TipoPrecioXPromRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public List<TipoPrecioXPromRegistrado> Listar()
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.TipoPrecioXPromocions.ToList().Select(x => Mapper.Map<TipoPrecioXPromRegistrado>(x)).ToList();

            }
        }

        public List<TipoPrecioXPromRegistrado> Listar(string codempresa, string codpromo, string codigo)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.TipoPrecioXPromocions.Where(x => (x.CODEMPRESA.Contains(codempresa)) && (x.CODPROMO.Contains(codpromo)) && (x.CODIGO.Contains(codigo))).ToList().Select(x => Mapper.Map<TipoPrecioXPromRegistrado>(x)).ToList();

            }
        }

        public TipoPrecioXPromRegistrado Registrar(TipoPrecioXPromNuevo registroNuevo)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                TipoPrecioXPromocion nuevoEquipo = Mapper.Map<TipoPrecioXPromocion>(registroNuevo);
                db.TipoPrecioXPromocions.Add(nuevoEquipo);
                db.SaveChanges();
                return Mapper.Map<TipoPrecioXPromRegistrado>(nuevoEquipo);
            }
        }

       
    }
}
