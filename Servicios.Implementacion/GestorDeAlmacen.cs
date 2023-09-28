using AutoMapper;
using CapaDatafirst;
using Servicios.Interfaces.Almacen;
using Servicios.Interfaces.Almacen.Peticiones;
using Servicios.Interfaces.Almacen.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDeAlmacen : IGestorDeAlmacen
    {
        public AlmacenRegistrado Actualizar(AlmacenActualizar registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int IdDelRegistro)
        {
            throw new NotImplementedException();
        }

        public List<AlmacenRegistrado> Filtrar(AlmacenRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public List<AlmacenRegistrado> Listar()
        {
           using(NARGESTEntities db =  new NARGESTEntities())
            {
                return db.ALMACEN.ToList().Select(x => Mapper.Map<AlmacenRegistrado>(x)).ToList();
            }
        }

        public AlmacenRegistrado Registrar(AlmacenNuevo registroNuevo)
        {
            throw new NotImplementedException();
        }
    }
}
