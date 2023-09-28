using AutoMapper;
using CapaDatafirst;
using Servicios.Interfaces.SegmentoCliente;
using Servicios.Interfaces.SegmentoCliente.Peticiones;
using Servicios.Interfaces.SegmentoCliente.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorSegmentoCliente : IGestorSegmentoCliente
    {
        public SegmentoClienteRegistrado Actualizar(SegmentoClienteActualizar registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int IdDelRegistro)
        {
            throw new NotImplementedException();
        }

        public List<SegmentoClienteRegistrado> Filtrar(SegmentoClienteRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public List<SegmentoClienteRegistrado> Listar()
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.SEGMENTO_CLIENTE.ToList().Select(x => Mapper.Map<SegmentoClienteRegistrado>(x)).ToList();


            }
        }

        public SegmentoClienteRegistrado Registrar(SegmentoClienteNuevo registroNuevo)
        {
            throw new NotImplementedException();
        }
    }
}
