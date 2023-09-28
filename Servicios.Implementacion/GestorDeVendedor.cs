using AutoMapper;
using CapaDatafirst;
using Servicios.Interfaces.Vendedor;
using Servicios.Interfaces.Vendedor.Peticiones;
using Servicios.Interfaces.Vendedor.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDeVendedor : IGestorDeVendedor
    {
        public VendedorRegistrado Actualizar(VendedorActualizar registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int IdDelRegistro)
        {
            throw new NotImplementedException();
        }

        public List<VendedorRegistrado> Filtrar(VendedorRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public List<VendedorRegistrado> Listar()
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.VENDEDOR.OrderBy(x => x.DSVEND).ToList().Select(x => Mapper.Map<VendedorRegistrado>(x)).ToList();
            }
        }

        public VendedorRegistrado Registrar(VendedorNuevo registroNuevo)
        {
            throw new NotImplementedException();
        }
    }
}
