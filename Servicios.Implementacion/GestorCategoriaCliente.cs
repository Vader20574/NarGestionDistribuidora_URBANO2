using AutoMapper;
using CapaDatafirst;
using Servicios.Interfaces.CategoriaCliente;
using Servicios.Interfaces.CategoriaCliente.Peticiones;
using Servicios.Interfaces.CategoriaCliente.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{

    public class GestorCategoriaCliente : IGestorCategoriaCliente
    {
        public CategoriaClienteRegistrado Actualizar(CategoriaClienteActualizar registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int IdDelRegistro)
        {
            throw new NotImplementedException();
        }

        public List<CategoriaClienteRegistrado> Filtrar(CategoriaClienteRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public List<CategoriaClienteRegistrado> Listar()
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.CATEGORIA_CLIENTE.ToList().Select(x => Mapper.Map<CategoriaClienteRegistrado>(x)).ToList();
            }
        }

        public CategoriaClienteRegistrado Registrar(CategoriaClienteNuevo registroNuevo)
        {
            throw new NotImplementedException();
        }
    }
}
