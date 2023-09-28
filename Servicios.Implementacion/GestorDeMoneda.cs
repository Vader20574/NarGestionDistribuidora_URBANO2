using AutoMapper;
using CapaDatafirst;
using Servicios.Interfaces.Moneda;
using Servicios.Interfaces.Moneda.Peticiones;
using Servicios.Interfaces.Moneda.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDeMoneda : IGestorDeMoneda
    {
        public MonedaRegistrado Actualizar(MonedaActualizar registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int IdDelRegistro)
        {
            throw new NotImplementedException();
        }

        public List<MonedaRegistrado> Filtrar(MonedaRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public List<MonedaRegistrado> Listar()
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.Moneda.ToList().Select(x => Mapper.Map<MonedaRegistrado>(x)).ToList();
            }
        }

        public MonedaRegistrado Registrar(MonedaNuevo registroNuevo)
        {
            throw new NotImplementedException();
        }
    }
}
