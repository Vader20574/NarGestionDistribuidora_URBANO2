using AutoMapper;
using CapaDatafirst;
using Servicios.Interfaces.Configsis;
using Servicios.Interfaces.Configsis.Peticiones;
using Servicios.Interfaces.Configsis.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDeConfigsis : IGestorDeConfigsis
    {
        public ConfigsisRegistrado Actualizar(ConfigsisActualizar registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public ConfigsisRegistrado Actualizar_codclientedep(ConfigsisRegistrado configsis_registrado)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                CONFIGSIS nuevoConfigsis = db.CONFIGSIS.Find(configsis_registrado.COD_EMPRESA);
                nuevoConfigsis.CodClienteDep = configsis_registrado.CodClienteDep + 1;
                db.SaveChanges();
                return Mapper.Map<ConfigsisRegistrado>(nuevoConfigsis);
            }
        }

        public ConfigsisRegistrado Actualizar_codclientepri(ConfigsisRegistrado configsis_registrado)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                CONFIGSIS nuevoConfigsis = db.CONFIGSIS.Find(configsis_registrado.COD_EMPRESA);
                nuevoConfigsis.CodClientePri = configsis_registrado.CodClientePri + 1;
                db.SaveChanges();
                return Mapper.Map<ConfigsisRegistrado>(nuevoConfigsis);
            }
        }

        public void Borrar(int IdDelRegistro)
        {
            throw new NotImplementedException();
        }

        public List<ConfigsisRegistrado> Filtrar(ConfigsisRegistrado registroGuardos)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.CONFIGSIS.Where(x => x.COD_EMPRESA.Contains(registroGuardos.COD_EMPRESA.ToString()))
                                         .ToList()
                                         .Select(x => Mapper.Map<ConfigsisRegistrado>(x))
                                         .ToList();
            }
        }

        public ConfigsisRegistrado FindById(string Id)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return Mapper.Map<ConfigsisRegistrado>(db.CONFIGSIS.Find(Id));
            }

        }

        public List<ConfigsisRegistrado> Listar()
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.CONFIGSIS.ToList().Select(x => Mapper.Map<ConfigsisRegistrado>(x)).ToList();
            }
        }

        public ConfigsisRegistrado Registrar(ConfigsisNuevo registroNuevo)
        {
            throw new NotImplementedException();
        }
    }
}
