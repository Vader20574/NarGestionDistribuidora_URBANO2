using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios.Interfaces.Ruta;
using Servicios.Interfaces.Ruta.Peticiones;
using Servicios.Interfaces.Ruta.Respuestas;
using CapaDatafirst;
using AutoMapper;

namespace Servicios.Implementacion
{
    public class GestorDeRuta : IGestorDeRuta
    {
        public RutaRegistrado Actualizar(RutaActualizar registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int IdDelRegistro)
        {
            throw new NotImplementedException();
        }

        public List<RutaRegistrado> Filtrar(RutaRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public List<RutaRegistrado> Listar()
        {

            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.RUTA.ToList().Select(x => Mapper.Map<RutaRegistrado>(x)).ToList();
            }
          

        }

        public RutaRegistrado Registrar(RutaNuevo registroNuevo)
        {
            throw new NotImplementedException();
        }
    }
}
