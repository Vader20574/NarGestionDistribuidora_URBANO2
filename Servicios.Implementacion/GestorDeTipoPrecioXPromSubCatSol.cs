using AutoMapper;
using Dominio.Contextos;
using Dominio.Entidades.Modelo;
using Servicios.Interfaces.TipoPrecioXPromSubCatSoles;
using Servicios.Interfaces.TipoPrecioXPromSubCatSoles.Peticiones;
using Servicios.Interfaces.TipoPrecioXPromSubCatSoles.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDeTipoPrecioXPromSubCatSol : IGestorDeTipoPrecioXPromSubCatSol
    {
        public TipoPrecioXPromSubCatSolReg Actualizar(TipoPrecioXPromSubCatSolAct registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int IdDelRegistro)
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                var tipoprecpromo = db.TipoPrecioXPromoSubCatSoles.FirstOrDefault(x => x.ID == IdDelRegistro);// object your want to delete
                if (tipoprecpromo != null)
                {
                    db.TipoPrecioXPromoSubCatSoles.Remove(tipoprecpromo);
                    db.SaveChanges();
                }
            }
        }

        public List<TipoPrecioXPromSubCatSolReg> Filtrar(TipoPrecioXPromSubCatSolReg registroGuardos)
        {
            throw new NotImplementedException();
        }

        public List<TipoPrecioXPromSubCatSolReg> Listar()
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                return db.TipoPrecioXPromoSubCatSoles.ToList().Select(x => Mapper.Map<TipoPrecioXPromSubCatSolReg>(x)).ToList();

            }
        }

        public List<TipoPrecioXPromSubCatSolReg> Listar(string codempresa, string codlinea, string codigo)
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                return db.TipoPrecioXPromoSubCatSoles.Where(x => (x.CODEMPRESA.Contains(codempresa)) && (x.CODLINEA.Contains(codlinea)) && (x.CODIGO.Contains(codigo))).ToList().Select(x => Mapper.Map<TipoPrecioXPromSubCatSolReg>(x)).ToList();

            }
        }

        public TipoPrecioXPromSubCatSolReg Registrar(TipoPrecioXPromSubCatSolNuevo registroNuevo)
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                TipoPrecioXPromoSubCatSoles nuevoPromoSubCatDeSoles = Mapper.Map<TipoPrecioXPromoSubCatSoles>(registroNuevo);
                db.TipoPrecioXPromoSubCatSoles.Add(nuevoPromoSubCatDeSoles);
                db.SaveChanges();
                return Mapper.Map<TipoPrecioXPromSubCatSolReg>(nuevoPromoSubCatDeSoles);
            }
        }
    }
}
