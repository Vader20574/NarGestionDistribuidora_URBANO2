using AutoMapper;
using Dominio.Contextos;
using Dominio.Contextos.Models;
using Dominio.Entidades.Modelo;
using Servicios.Interfaces.Supervisor;
using Servicios.Interfaces.Supervisor.Peticiones;
using Servicios.Interfaces.Supervisor.Respuestas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDeSupervisor : IGestorDeSupervisor
    {
        public SupervisorRegistrado Actualizar(SupervisorActualizar registroParaActualizar)
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                Supervisor nuevoSupervisor = db.Supervisor.Find(registroParaActualizar.Codsuperv);
                nuevoSupervisor.Dssuperv = registroParaActualizar.Dssuperv;
                nuevoSupervisor.Direccion = registroParaActualizar.Direccion;
                nuevoSupervisor.nrofac = registroParaActualizar.nrofac;
                nuevoSupervisor.nrobol = registroParaActualizar.nrobol;
                nuevoSupervisor.nrofacRef = registroParaActualizar.nrofacRef;
                nuevoSupervisor.nrobolRef = registroParaActualizar.nrobolRef;
                nuevoSupervisor.EDESE = registroParaActualizar.EDESE;
                nuevoSupervisor.GIEF = registroParaActualizar.GIEF;
                nuevoSupervisor.GIEB = registroParaActualizar.GIEB;
        db.SaveChanges();

                return Mapper.Map<SupervisorRegistrado>(nuevoSupervisor);

            }


        }

        public void Borrar(int IdDelRegistro)
        {
            throw new NotImplementedException();
        }

        public void Borrar(string IdDelRegistro)
        {
    

            using (DistribucionBD db = new DistribucionBD())
            {
                Supervisor equipodelete = new Supervisor() { Codsuperv = IdDelRegistro };
                db.Supervisor.Attach(equipodelete);
                db.Supervisor.Remove(equipodelete);
                db.SaveChanges();
            }


        }

        public List<SupervisorRegistrado> Filtrar(SupervisorRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public List<SupervisorRegistrado> Listar()
        {

            using (DistribucionBD db = new DistribucionBD())
            {
          
                return db.Supervisor.ToList().Select(x => Mapper.Map<SupervisorRegistrado>(x)).ToList();
            }

        }

        public SupervisorRegistrado Registrar(SupervisorNuevo registroNuevo)
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                Supervisor nuevoPromoDeSoles = Mapper.Map<Supervisor>(registroNuevo);
                db.Supervisor.Add(nuevoPromoDeSoles);
                db.SaveChanges();
                return Mapper.Map<SupervisorRegistrado>(nuevoPromoDeSoles);
            }
        }


    }
}
