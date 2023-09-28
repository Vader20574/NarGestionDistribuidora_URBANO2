using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios.Interfaces.Ciudad;
using Servicios.Interfaces.Ciudad.Peticiones;
using Servicios.Interfaces.Ciudad.Respuesta;
using CapaDatafirst;
using AutoMapper;

namespace Servicios.Implementacion
{
    public class GestorDeCiudad : IGestorDeCiudad
    {
        public CiudadRegistrado Actualizar(CiudadActualizar registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int IdDelRegistro)
        {
            throw new NotImplementedException();
        }

        public List<CiudadRegistrado> Filtrar(CiudadRegistrado registroGuardos)
        {
            

            using (NARGESTEntities db = new NARGESTEntities())
            {
                //return db.CIUDAD.ToList().Select(x => Mapper.Map<CiudadRegistrado>(x)).ToList();


                return db.CIUDAD.Where(x => (x.iddepa.Contains(registroGuardos.iddepa.ToString())) && x.CODPAIS.Contains(registroGuardos.CODPAIS.ToString()))
                                        .ToList()
                                        .Select(x => Mapper.Map<CiudadRegistrado>(x))
                                        .ToList();


            }

            
        }

        public List<CiudadRegistrado> Listar()
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.CIUDAD.ToList().Select(x => Mapper.Map<CiudadRegistrado>(x)).ToList();


            }
        }

        public CiudadRegistrado Registrar(CiudadNuevo registroNuevo)
        {
            throw new NotImplementedException();
        }
    }
}
