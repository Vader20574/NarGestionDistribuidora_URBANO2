using Servicios.Interfaces.Pais;
using Servicios.Interfaces.Pais.Peticiones;
using Servicios.Interfaces.Pais.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatafirst;
using AutoMapper;

namespace Servicios.Implementacion
{
    public class GestorDePais : IGestorDePais

    {
        public PaisRegistrado Actualizar(PaisActualizar registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int IdDelRegistro)
        {
            throw new NotImplementedException();
        }

        public List<PaisRegistrado> Filtrar(PaisRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public List<PaisRegistrado> Listar()
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.PAIS.ToList().Select(x=> Mapper.Map<PaisRegistrado>(x)).ToList();
            }

        }

        public PaisRegistrado Registrar(PaisNuevo registroNuevo)
        {
            throw new NotImplementedException();
        }
    }
}
