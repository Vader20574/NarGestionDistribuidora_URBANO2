using AutoMapper;
using Dominio.Contextos;
using Dominio.Entidades.Modelo;
using Servicios.Interfaces.PromoDeSoles;
using Servicios.Interfaces.PromoSubCat;
using Servicios.Interfaces.PromoSubCat.Peticiones;
using Servicios.Interfaces.PromoSubCat.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDePromoSubCat : IGestorDePromoSubCat
    {
        public PromoSubCatRegistrado Actualizar(PromoSubCatActualizar registroParaActualizar)
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                PromoSubCat actCliente = db.PromoSubCat.Find(registroParaActualizar.CODPROMO);

                actCliente.CODEMPRESA = registroParaActualizar.CODEMPRESA;
                actCliente.CODPROMO = registroParaActualizar.CODPROMO;
                actCliente.DESPROMO = registroParaActualizar.CODPROMO;
                actCliente.PRECIO_PROMO = registroParaActualizar.PRECIO_PROMO;
                actCliente.CODLINEA= registroParaActualizar.CODLINEA;
                actCliente.CODSUBLINEA= registroParaActualizar.CODSUBLINEA;
                actCliente.CODPRESVTA = registroParaActualizar.CODPRESVTA;
                actCliente.ESCALA = registroParaActualizar.ESCALA;
                actCliente.DESDE_SOLES_ART = registroParaActualizar.DESDE_SOLES_ART;
                actCliente.HASTA_SOLES_ART = registroParaActualizar.HASTA_SOLES_ART;
                actCliente.SOLES_ART_VTA = registroParaActualizar.SOLES_ART_VTA;
                actCliente.CODARTI_PROMO = registroParaActualizar.CODARTI_PROMO;
                actCliente.CODPRESPROM = registroParaActualizar.CODPRESPROM;
                actCliente.CANT_ARTI_PROMO = registroParaActualizar.CANT_ARTI_PROMO;
                actCliente.STOCK_PROMO = registroParaActualizar.STOCK_PROMO;
                actCliente.FEC_INI = registroParaActualizar.FEC_INI;
                actCliente.FEC_FIN = registroParaActualizar.FEC_FIN;
                actCliente.activar = registroParaActualizar.activar;
                actCliente.XCLIENTE = registroParaActualizar.XCLIENTE;
                actCliente.XTIPOPRE = registroParaActualizar.XTIPOPRE;
                actCliente.XCATEGORIA = registroParaActualizar.XCATEGORIA;
                actCliente.XSUBCATEGORIA = registroParaActualizar.XSUBCATEGORIA;

                db.SaveChanges();
                return Mapper.Map<PromoSubCatRegistrado>(actCliente);
            }
        }

        public void Borrar(int IdDelRegistro)
        {
            throw new NotImplementedException();
        }

        public void Borrar(string codemp, string codpromo)
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                PromoSubCat promosubcatdelete = new PromoSubCat() { CODPROMO = codpromo.ToString() };
                db.PromoSubCat.Attach(promosubcatdelete);
                db.PromoSubCat.Remove(promosubcatdelete);
                db.SaveChanges();

            }
        }

        public List<PromoSubCatRegistrado> Filtrar(PromoSubCatRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public PromoSubCatRegistrado FindById(string Id)
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                return Mapper.Map<PromoSubCatRegistrado>(db.PromoSubCat.Find(Id));
            }
        }

        public List<PromoSubCatRegistrado> Listar()
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                return db.PromoSubCat.ToList().Select(x => Mapper.Map<PromoSubCatRegistrado>(x)).ToList();
            }
        }

        public PromoSubCatRegistrado Registrar(PromoSubCatNuevo registroNuevo)
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                PromoSubCat nuevoPromoDeSoles = Mapper.Map<PromoSubCat>(registroNuevo);
                db.PromoSubCat.Add(nuevoPromoDeSoles);
                db.SaveChanges();
                return Mapper.Map<PromoSubCatRegistrado>(nuevoPromoDeSoles);
            }
        }
    }
}
