using AutoMapper;
using Dominio.Contextos;
using Dominio.Entidades.Modelo;
using Servicios.Interfaces.Equipo.Respuestas;
using Servicios.Interfaces.Jefe_Equipo;
using Servicios.Interfaces.Jefe_Equipo.Peticiones;
using Servicios.Interfaces.Jefe_Equipo.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDeJefe_Equipo : IGestorDeJefe_Equipo

    {
        public Jefe_EquipoRegistro Actualizar(Jefe_EquipoActualizar registroParaActualizar)
        {
            using (DistribucionBD db = new DistribucionBD())
            {

                Jefe_Equipo actEquipoVend = db.Jefe_Equipo.Find(registroParaActualizar.Id);
                actEquipoVend.NombreJefe = registroParaActualizar.NombreJefe;
                actEquipoVend.DatosPersonales = registroParaActualizar.DatosPersonales;
        
                actEquipoVend.Fecha_Inicio = registroParaActualizar.Fecha_Inicio;
                actEquipoVend.Fecha_Fin = registroParaActualizar.Fecha_Fin;
                db.SaveChanges();

                return Mapper.Map<Jefe_EquipoRegistro>(actEquipoVend);
            }
        }

        public void Borrar(int IdDelRegistro)
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                Jefe_Equipo Jefe_Equipodelete = new Jefe_Equipo() { Id = IdDelRegistro };
                db.Jefe_Equipo.Attach(Jefe_Equipodelete);
                db.Jefe_Equipo.Remove(Jefe_Equipodelete);
                db.SaveChanges();

            }
        }

        public List<Jefe_EquipoRegistro> Filtrar(Jefe_EquipoRegistro registroGuardos)
        {
            throw new NotImplementedException();
        }

        public Jefe_EquipoRegistro FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Jefe_EquipoRegistro> Listar()
        {
            using (DistribucionBD db = new DistribucionBD())
            {

                return db.Jefe_Equipo.ToList()
                            .Select(x => Mapper.Map<Jefe_EquipoRegistro>(x))
                            .ToList();
            }
        }

        public Jefe_EquipoRegistro Registrar(Jefe_EquipoNuevo registroNuevo)
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                Jefe_Equipo nuevoEquipoVend = Mapper.Map<Jefe_Equipo>(registroNuevo);
                db.Jefe_Equipo.Add(nuevoEquipoVend);
                db.SaveChanges();
                return Mapper.Map<Jefe_EquipoRegistro>(nuevoEquipoVend);
            }
        }



    }
}
