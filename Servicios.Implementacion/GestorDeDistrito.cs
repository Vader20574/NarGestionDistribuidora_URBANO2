using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios.Interfaces.Distrito;
using Servicios.Interfaces.Distrito.Peticiones;
using Servicios.Interfaces.Distrito.Respuestas;
using CapaDatafirst;
using AutoMapper;

namespace Servicios.Implementacion
{
    public class GestorDeDistrito : IGestorDeDistrito
    {
        public DistritoRegistrado Actualizar(DistritoActualizar registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int IdDelRegistro)
        {
            throw new NotImplementedException();
        }

        public List<DistritoRegistrado> Filtrar(DistritoRegistrado registroGuardos)
        {

            using (NARGESTEntities db = new NARGESTEntities())
            {

                return db.Distrito.Where(x => (x.CODPAIS.Contains(registroGuardos.CODPAIS.ToString())) && x.iddepa.Contains(registroGuardos.iddepa.ToString()) && x.codprovi.Contains(registroGuardos.codprovi.ToString()))
                                   .ToList()
                                   .Select(x => Mapper.Map<DistritoRegistrado>(x))
                                   .ToList();
            }

        }

        public List<DistritoRegistrado> Listar()
        {

            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.Distrito.ToList().Select(x => Mapper.Map<DistritoRegistrado>(x)).ToList();
            }


        }

        public DistritoRegistrado Registrar(DistritoNuevo registroNuevo)
        {
            throw new NotImplementedException();
        }
    }
}
