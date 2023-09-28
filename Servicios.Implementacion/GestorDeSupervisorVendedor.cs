using AutoMapper;
using Dominio.Contextos;
using Dominio.Contextos.Models;
using Dominio.Entidades.Modelo;
using Microsoft.EntityFrameworkCore;
using Servicios.Interfaces.SupervisorVendedor;
using Servicios.Interfaces.SupervisorVendedor.Peticiones;
using Servicios.Interfaces.SupervisorVendedor.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDeSupervisorVendedor : IGestorDeSupervisorVendedor
    {

        public SupervisorVendedorRegistrado Actualizar(SupervisorVendedorActualizar registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int IdDelRegistro)
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                
                    var entity = db.Set<SupervisorVendedor>().AsNoTracking().FirstOrDefault(e => e.Id == IdDelRegistro);
                    db.Set<SupervisorVendedor>().Attach(entity);
                    db.Set<SupervisorVendedor>().Remove(entity);
                    db.SaveChanges();
                    
              
            }



        }

        public bool Borrar2(int IdDelRegistro)
        {

           

            using (DistribucionBD db = new DistribucionBD())
            {
                try
                {
                    var entity = db.Set<SupervisorVendedor>().AsNoTracking().FirstOrDefault(e => e.Id == IdDelRegistro);
                    db.Set<SupervisorVendedor>().Attach(entity);
                    db.Set<SupervisorVendedor>().Remove(entity);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }




        }

        public  void BorrarxCodSupervisor(string IdDelRegistro)
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                SupervisorVendedor nuevaLinea = new SupervisorVendedor() { Codsupervisor = IdDelRegistro.ToString() };
                db.SupervisorVendedor.Attach(nuevaLinea);
                db.SupervisorVendedor.Remove(nuevaLinea);
                db.SaveChanges();
            }
        }

        public List<SupervisorVendedorRegistrado> Filtrar(SupervisorVendedorRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public List<SupervisorVendedorRegistrado> Listar()
        {
            throw new NotImplementedException();
        }

        public List<SupervisorVendedorRegistrado> ListarxCodSupervisor(string codsuperv)
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                return db.SupervisorVendedor.Where(p => p.Codsupervisor == codsuperv).AsNoTracking().ToList().Select(x => Mapper.Map<SupervisorVendedorRegistrado>(x)).ToList();
            }
        }

        public SupervisorVendedorRegistrado Registrar(SupervisorVendedorNuevo registroNuevo)
        {

            using (DistribucionBD db = new DistribucionBD())
            {
                SupervisorVendedor nuevoPromoDeSoles = Mapper.Map<SupervisorVendedor>(registroNuevo);
                db.SupervisorVendedor.Add(nuevoPromoDeSoles);
                db.SaveChanges();
                return Mapper.Map<SupervisorVendedorRegistrado>(nuevoPromoDeSoles);
            }

        }
    }
}
