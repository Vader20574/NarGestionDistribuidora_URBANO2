using Servicios.Interfaces.TipoProducto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios.Interfaces.TipoProducto.Peticiones;
using Servicios.Interfaces.TipoProducto.Respuestas;
using AutoMapper;
using CapaDatafirst;

namespace Servicios.Implementacion
{
    public class GestorDeTipoProd : IGestorDeTipoProd
    {
        public TipoProdRegistrado Actualizar(TipoProdActualizar registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int IdDelRegistro)
        {
            throw new NotImplementedException();
        }

        public List<TipoProdRegistrado> Filtrar(TipoProdRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public List<TipoProdRegistrado> Listar()
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.TIPOPROD.ToList().Select(x => Mapper.Map<TipoProdRegistrado>(x)).ToList();
            }
        }

        public TipoProdRegistrado Registrar(TipoProdNuevo registroNuevo)
        {
            throw new NotImplementedException();
        }
    }
}
