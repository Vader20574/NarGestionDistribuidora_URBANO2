using AutoMapper;
using CapaDatafirst;
using Servicios.Interfaces.Zona;
using Servicios.Interfaces.Zona.Peticiones;
using Servicios.Interfaces.Zona.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDeZona : IGestorDeZona
    {
        public ZonaRegistrado Actualizar(ZonaActualizar registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int IdDelRegistro)
        {
            throw new NotImplementedException();
        }

        public List<ZonaRegistrado> Filtrar(ZonaRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public List<ZonaRegistrado> Listar()
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.Zonas.ToList().Select(x => Mapper.Map<ZonaRegistrado>(x)).ToList();
            }
        }

        public ZonaRegistrado Registrar(ZonaNuevo registroNuevo)
        {
            throw new NotImplementedException();
        }
    }
}
