using Servicios.Interfaces.Artidat;
using Servicios.Interfaces.Artidat.Peticiones;
using Servicios.Interfaces.Artidat.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CapaDatafirst;


namespace Servicios.Implementacion
{
    public class GestorDeArtidat : IGestorDeArtidat
    {
        public ArtidatRegistrado Actualizar(ArtidatActualizar registroParaActualizar)
        {



            using (NARGESTEntities db = new NARGESTEntities())
            {



                //ARTIDAT Actartidat = db.ARTIDAT.Find(x => x.CODARTI.Contains(registroParaActualizar.CODARTI) || x.CODALMACEN.Contains(registroParaActualizar.CODALMACEN.ToString()));
                //ARTIDAT Actartidat = db.ARTIDAT.Find(registroParaActualizar.CODALMACEN.ToString(), registroParaActualizar.CODARTI);
                //Actartidat.STKACTU = registroParaActualizar.STKACTU;
                //db.SaveChanges();
                //return Mapper.Map<ArtidatRegistrado>(Actartidat);




                ARTIDAT Actartidat = new ARTIDAT() { CODALMACEN = registroParaActualizar.CODALMACEN.ToString(), CODARTI = registroParaActualizar.CODARTI };
                db.ARTIDATs.Attach(Actartidat);
                Actartidat.STKACTU = registroParaActualizar.STKACTU;

                db.SaveChanges();
                return Mapper.Map<ArtidatRegistrado>(Actartidat);

            }
        }

        public void Borrar(int IdDelRegistro)
        {
            throw new NotImplementedException();
        }

        public List<ArtidatRegistrado> Filtrar(ArtidatRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public List<ArtidatRegistrado> Listar()
        {
            throw new NotImplementedException();
        }

        public ArtidatRegistrado Registrar(ArtidatNuevo registroNuevo)
        {
            throw new NotImplementedException();
        }
    }
}
