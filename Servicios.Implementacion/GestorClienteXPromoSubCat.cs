using AutoMapper;
using CapaDatafirst;
using Servicios.Interfaces.ClienteXPromoSubCat;
using Servicios.Interfaces.ClienteXPromoSubCat.Peticiones;
using Servicios.Interfaces.ClienteXPromoSubCat.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorClienteXPromoSubCat : IGestorClienteXPromoSubCat
    {
        public ClienteXPromoSubCatRegistrado Actualizar(ClienteXPromoSubCatActualizar registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int IdDelRegistro)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                CLIENTEXPROMOSUBCAT clidepdelete = new CLIENTEXPROMOSUBCAT() { ID = IdDelRegistro };
                db.CLIENTEXPROMOSUBCATs.Attach(clidepdelete);
                db.CLIENTEXPROMOSUBCATs.Remove(clidepdelete);
                db.SaveChanges();

            }
        }

        public List<ClienteXPromoSubCatRegistrado> Filtrar(ClienteXPromoSubCatRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public List<ClienteXPromoSubCatRegistrado> Listar()
        {
            throw new NotImplementedException();
        }

        public List<ClienteXPromoSubCatRegistrado> Listar(string codpromo)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.CLIENTEXPROMOSUBCATs.Where(x => (x.CODPROMO.Contains(codpromo))).ToList().Select(x => Mapper.Map<ClienteXPromoSubCatRegistrado>(x)).ToList();

            }
        }

        public ClienteXPromoSubCatRegistrado Registrar(ClienteXPromoSubCatNuevo registroNuevo)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                CLIENTEXPROMOSUBCAT nuevoClienteXPromo = Mapper.Map<CLIENTEXPROMOSUBCAT>(registroNuevo);
                db.CLIENTEXPROMOSUBCATs.Add(nuevoClienteXPromo);
                db.SaveChanges();
                return Mapper.Map<ClienteXPromoSubCatRegistrado>(nuevoClienteXPromo);
            }
        }
    }
}
