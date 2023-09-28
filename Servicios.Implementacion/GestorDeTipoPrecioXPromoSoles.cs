using AutoMapper;
using Dominio.Contextos;
using Dominio.Entidades.Modelo;
using Servicios.Interfaces.TipoPrecioXPromoSoles;
using Servicios.Interfaces.TipoPrecioXPromoSoles.Peticiones;
using Servicios.Interfaces.TipoPrecioXPromoSoles.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDeTipoPrecioXPromoSoles : IGestorDeTipoPrecioXPromoSoles
    {
        public TipoPrecioXPromoSolesReg Actualizar(TipoPrecioXPromoSolesAct registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int IdDelRegistro)
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                var tipoprecpromo = db.TipoPrecioXPromoSoles.FirstOrDefault(x => x.Id == IdDelRegistro);// object your want to delete
                if (tipoprecpromo != null)
                {
                    db.TipoPrecioXPromoSoles.Remove(tipoprecpromo);
                    db.SaveChanges();
                }
            }
        }

        public List<TipoPrecioXPromoSolesReg> Filtrar(TipoPrecioXPromoSolesReg registroGuardos)
        {
            throw new NotImplementedException();
        }

        public List<TipoPrecioXPromoSolesReg> Listar()
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                return db.TipoPrecioXPromoSoles.ToList().Select(x => Mapper.Map<TipoPrecioXPromoSolesReg>(x)).ToList();

            }
        }

        public List<TipoPrecioXPromoSolesReg> Listar(string codempresa, string codpromo, string codigo)
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                return db.TipoPrecioXPromoSoles.Where(x => (x.CODEMPRESA.Contains(codempresa)) && (x.CODARTI.Contains(codpromo)) && (x.CODIGO.Contains(codigo))).ToList().Select(x => Mapper.Map<TipoPrecioXPromoSolesReg>(x)).ToList();
            }
        }

        public TipoPrecioXPromoSolesReg Registrar(TipoPrecioXPromoSolesNuevo registroNuevo)
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                TipoPrecioXPromoSoles nuevoEquipo = Mapper.Map<TipoPrecioXPromoSoles>(registroNuevo);
                db.TipoPrecioXPromoSoles.Add(nuevoEquipo);
                db.SaveChanges();
                return Mapper.Map<TipoPrecioXPromoSolesReg>(nuevoEquipo);
            }
        }
    }
}
