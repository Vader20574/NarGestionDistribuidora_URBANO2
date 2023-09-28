using AutoMapper;
using Dominio.Contextos;
using Dominio.Entidades.Modelo;
using Servicios.Interfaces.Equipo;
using Servicios.Interfaces.Equipo.Peticiones;
using Servicios.Interfaces.Equipo.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDeEquipo : IGestorDeEquipo
    {
        public EquipoRegistrado Actualizar(EquipoActualizar registroParaActualizar)
        {
            using (DistribucionBD db = new DistribucionBD())
            {

                Equipo nuevoEquipo = db.Equipo.Find(registroParaActualizar.Codigo);
                nuevoEquipo.Descripcion= registroParaActualizar.Descripcion;
                nuevoEquipo.Descripcion2 = registroParaActualizar.Descripcion2;
            
                db.SaveChanges();

                return Mapper.Map<EquipoRegistrado>(nuevoEquipo);
            }
        }


        public void Borrar(string CodCliente)
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                Equipo equipodelete = new Equipo() {  Codigo = CodCliente.ToString() };
                db.Equipo.Attach(equipodelete);
                db.Equipo.Remove(equipodelete);
                db.SaveChanges();

            }
        }

        public void Borrar(int IdDelRegistro)
        {
            throw new NotImplementedException();
        }

        public List<EquipoRegistrado> Filtrar(EquipoRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public EquipoRegistrado FindById(string Id)
        {
            using (DistribucionBD db = new DistribucionBD())
            {

                return Mapper.Map<EquipoRegistrado>(db.Equipo.Find(Id));
            }

        }

        public List<EquipoRegistrado> Listar()
        {
            using (DistribucionBD db = new DistribucionBD())
            {

                return db.Equipo.ToList()
                            .Select(x => Mapper.Map<EquipoRegistrado>(x))
                            .ToList();
            }
        }

        public EquipoRegistrado Registrar(EquipoNuevo registroNuevo)
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                Equipo nuevoEquipo = Mapper.Map<Equipo>(registroNuevo);
                db.Equipo.Add(nuevoEquipo);
                db.SaveChanges();
                return Mapper.Map<EquipoRegistrado>(nuevoEquipo);
            }
        }
    }
}
