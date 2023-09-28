

using AutoMapper;
using CapaDatafirst;
using Servicios.Interfaces.Departamento;
using Servicios.Interfaces.Departamento.Peticiones;
using Servicios.Interfaces.Departamento.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDeDepartamento : IGestorDeDepartamento
    {
        public DepartamentoRegistrado Actualizar(DepartamentoActualizar registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int IdDelRegistro)
        {
            throw new NotImplementedException();
        }

        public List<DepartamentoRegistrado> Filtrar(DepartamentoRegistrado registroGuardos)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.paisdepa.Where(x=>(x.codpais.Contains(registroGuardos.codpais.ToString()))).
                    ToList().Select(x => Mapper.Map<DepartamentoRegistrado>(x)).ToList();
            }
        }

        public List<DepartamentoRegistrado> Listar()
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.paisdepa.ToList().Select(x => Mapper.Map<DepartamentoRegistrado>(x)).ToList();
            }
        }

        public DepartamentoRegistrado Registrar(DepartamentoNuevo registroNuevo)
        {
            throw new NotImplementedException();
        }
    }
}
