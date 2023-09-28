using AutoMapper;
using Dominio.Contextos;
using Dominio.Entidades.Modelo;
using Servicios.Interfaces.EquipoVendedor;
using Servicios.Interfaces.EquipoVendedor.Peticiones;
using Servicios.Interfaces.EquipoVendedor.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestoDeEquipoVendedor : IGestoDeEquipoVendedor
    {
        public Equipo_VendedorRegistrado Actualizar(Equipo_VendedorActualizar registroParaActualizar)
        {
            using (DistribucionBD db = new DistribucionBD())
            {

                Equipo_Vendedor Equipo_VendedorEquipo = db.Equipo_Vendedor.Find(registroParaActualizar.Id);
                Equipo_VendedorEquipo.CodEquipo = registroParaActualizar.CodEquipo;
                Equipo_VendedorEquipo.CodVend = registroParaActualizar.CodVend;

                db.SaveChanges();

                return Mapper.Map<Equipo_VendedorRegistrado>(Equipo_VendedorEquipo);
            }
        }

        public void Borrar(int IdDelRegistro)
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                Equipo_Vendedor Equipo_Vendedordelete = new Equipo_Vendedor() { Id = IdDelRegistro };
                db.Equipo_Vendedor.Attach(Equipo_Vendedordelete);
                db.Equipo_Vendedor.Remove(Equipo_Vendedordelete);
                db.SaveChanges();

            }
        }

        public List<Equipo_VendedorRegistrado> Filtrar(Equipo_VendedorRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public Equipo_VendedorRegistrado FindById(int Id)
        {
            using (DistribucionBD db = new DistribucionBD())
            {

                return Mapper.Map<Equipo_VendedorRegistrado>(db.Equipo_Vendedor.Find(Id));
            }
        }

        public List<Equipo_VendedorRegistrado> Listar()
        {
            using (DistribucionBD db = new DistribucionBD())
            {

                return db.Equipo_Vendedor.ToList()
                            .Select(x => Mapper.Map<Equipo_VendedorRegistrado>(x))
                            .ToList();
            }
        }

        public Equipo_VendedorRegistrado Registrar(Equipo_VendedorNuevo registroNuevo)
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                Equipo_Vendedor nuevoEquipo = Mapper.Map<Equipo_Vendedor>(registroNuevo);
                db.Equipo_Vendedor.Add(nuevoEquipo);
                db.SaveChanges();
                return Mapper.Map<Equipo_VendedorRegistrado>(nuevoEquipo);
            }
        }
    }
}
