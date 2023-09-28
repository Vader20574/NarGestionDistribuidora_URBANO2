using AutoMapper;
using Dominio.Contextos;
using Dominio.Entidades.Modelo;
using Servicios.Interfaces.PromoDeSoles;
using Servicios.Interfaces.PromoDeSoles.Peticiones;
using Servicios.Interfaces.PromoDeSoles.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorPromoDeSoles : IGestorPromoDeSoles
    {
        public Interfaces.PromoDeSoles.Respuestas.PromoDeSolesRegistrado Actualizar(PromoDeSolesActualizar registroParaActualizar)
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                PromoDeSoles actCliente = db.PromoDeSoles.Find(registroParaActualizar.CODPROMO);

                actCliente.CODEMPRESA = registroParaActualizar.CODEMPRESA;
                actCliente.CODPROMO = registroParaActualizar.CODPROMO;
                actCliente.DESPROMO = registroParaActualizar.CODPROMO;
                actCliente.PRECIO_PROMO = registroParaActualizar.PRECIO_PROMO;
                actCliente.CODARTI_VTA = registroParaActualizar.CODARTI_VTA;
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

                db.SaveChanges();
                return Mapper.Map<PromoDeSolesRegistrado>(actCliente);
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
                PromoDeSoles clidepdelete = new PromoDeSoles() { CODPROMO = codpromo.ToString() };
                db.PromoDeSoles.Attach(clidepdelete);
                db.PromoDeSoles.Remove(clidepdelete);
                db.SaveChanges();

            }
        }

        public List<Interfaces.PromoDeSoles.Respuestas.PromoDeSolesRegistrado> Filtrar(Interfaces.PromoDeSoles.Respuestas.PromoDeSolesRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public PromoDeSolesRegistrado FindById(string Id)
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                return Mapper.Map<PromoDeSolesRegistrado>(db.PromoDeSoles.Find(Id));
            }
        }

        public List<Interfaces.PromoDeSoles.Respuestas.PromoDeSolesRegistrado> Listar()
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                return db.PromoDeSoles.ToList().Select(x => Mapper.Map<PromoDeSolesRegistrado>(x)).ToList();
            }
        }

        public Interfaces.PromoDeSoles.Respuestas.PromoDeSolesRegistrado Registrar(PromoDeSolesNuevo registroNuevo)
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                PromoDeSoles nuevoPromoDeSoles = Mapper.Map<PromoDeSoles>(registroNuevo);
                db.PromoDeSoles.Add(nuevoPromoDeSoles);
                db.SaveChanges();
                return Mapper.Map<PromoDeSolesRegistrado>(nuevoPromoDeSoles);
            }
        }
    }
}
