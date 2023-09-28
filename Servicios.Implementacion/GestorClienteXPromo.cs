using AutoMapper;
using Dominio.Contextos;
using Dominio.Entidades.Modelo;
using Servicios.Interfaces.ClienteXPromo;
using Servicios.Interfaces.ClienteXPromo.Peticiones;
using Servicios.Interfaces.ClienteXPromo.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorClienteXPromo : IGestorClienteXPromo
    {
        public ClienteXPromoRegistrado Actualizar(ClienteXPromoAct registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int IdDelRegistro)
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                ClienteXPromo clidepdelete = new ClienteXPromo() { Id = IdDelRegistro };
                db.ClienteXPromo.Attach(clidepdelete);
                db.ClienteXPromo.Remove(clidepdelete);
                db.SaveChanges();

            }
        }



        public List<ClienteXPromoRegistrado> Filtrar(ClienteXPromoRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public List<ClienteXPromoRegistrado> Listar()
        {
            throw new NotImplementedException();
        }

        public List<ClienteXPromoRegistrado> Listar(string codpromo)
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                return db.ClienteXPromo.Where(x => (x.CODPROMO.Contains(codpromo))).ToList().Select(x => Mapper.Map<ClienteXPromoRegistrado>(x)).ToList();

            }
        }

        public ClienteXPromoRegistrado Registrar(ClienteXPromoNuevo registroNuevo)
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                ClienteXPromo nuevoClienteXPromo = Mapper.Map<ClienteXPromo>(registroNuevo);
                db.ClienteXPromo.Add(nuevoClienteXPromo);
                db.SaveChanges();
                return Mapper.Map<ClienteXPromoRegistrado>(nuevoClienteXPromo);
            }
        }
    }
}
