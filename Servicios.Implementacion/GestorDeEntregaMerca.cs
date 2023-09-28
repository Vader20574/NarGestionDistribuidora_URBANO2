using AutoMapper;
using Dominio.Contextos;
using Servicios.Interfaces.EntregaMercas;
using Servicios.Interfaces.EntregaMercas.Peticiones;
using Servicios.Interfaces.EntregaMercas.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDeEntregaMerca : IGestorDeEntregaMerca
    {
        public EntregaMercaRegistrado Actualizar(EntregaMercaActualizar registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int IdDelRegistro)
        {
            throw new NotImplementedException();
        }

        public List<EntregaMercaRegistrado> Filtrar(EntregaMercaRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public List<EntregaMercaRegistrado> Listar()
        {
            throw new NotImplementedException();
        }

        public EntregaMercaRegistrado Registrar(EntregaMercaNuevo registroNuevo)
        {
            throw new NotImplementedException();
        }
    }
}
