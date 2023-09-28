using AutoMapper;
using Dominio.Contextos;
using Dominio.Entidades.Modelo;
using Servicios.Interfaces.CentroCostoPromo;
using Servicios.Interfaces.CentroCostoPromo.Peticiones;
using Servicios.Interfaces.CentroCostoPromo.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDeCentroCostoPromo : IGestorDeCentroCostoPromo
    {
        public CentroCostoPromoRegistrado Actualizar(CentroCostoPromoActualizar registroParaActualizar)
        {
            using (DistribucionBD db = new DistribucionBD())
            {

                CentroCostoPromo nuevoCentro = db.CentroCostoPromo.Find(registroParaActualizar.Id);
                nuevoCentro.NombCentroProm = registroParaActualizar.NombCentroProm;
                db.SaveChanges();

                return Mapper.Map<CentroCostoPromoRegistrado>(nuevoCentro);
            }
        }

        public void Borrar(int IdDelRegistro)
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                CentroCostoPromo CentroCostoPromodelete = new CentroCostoPromo() { Id = IdDelRegistro };
                db.CentroCostoPromo.Attach(CentroCostoPromodelete);
                db.CentroCostoPromo.Remove(CentroCostoPromodelete);
                db.SaveChanges();

            }
        }

        public List<CentroCostoPromoRegistrado> Filtrar(CentroCostoPromoRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public CentroCostoPromoRegistrado FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<CentroCostoPromoRegistrado> Listar()
        {
            using (DistribucionBD db = new DistribucionBD())
            {

                return db.CentroCostoPromo.ToList()
                            .Select(x => Mapper.Map<CentroCostoPromoRegistrado>(x))
                            .ToList();
            }
        }

        public CentroCostoPromoRegistrado Registrar(CentroCostoPromoNuevo registroNuevo)
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                CentroCostoPromo nuevoCentroCostoPromo = Mapper.Map<CentroCostoPromo>(registroNuevo);
                db.CentroCostoPromo.Add(nuevoCentroCostoPromo);
                db.SaveChanges();
                return Mapper.Map<CentroCostoPromoRegistrado>(nuevoCentroCostoPromo);
            }
        }
    }
}
