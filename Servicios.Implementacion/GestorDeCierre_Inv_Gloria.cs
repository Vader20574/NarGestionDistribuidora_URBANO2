
using AutoMapper;
using Dominio.Contextos;
using Dominio.Entidades.Modelo;
using Servicios.Interfaces.Cierre_Inv_Gloria;
using Servicios.Interfaces.Cierre_Inv_Gloria.Peticiones;
using Servicios.Interfaces.Cierre_Inv_Gloria.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDeCierre_Inv_Gloria : IGestorDeCierre_Inv_Gloria
    {
        public Cierre_Inv_GloriaRegistrado Actualizar(Cierre_Inv_GloriaActualizar registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int IdDelRegistro)
        {
            throw new NotImplementedException();
        }

        public void BorrarTodo()
        {
            using (DistribucionBD db = new DistribucionBD())
            {

                var all = from c in db.Cierre_Inv_Gloria select c;
                db.Cierre_Inv_Gloria.RemoveRange(all);
                db.SaveChanges();

            }
        }

        public List<Cierre_Inv_GloriaRegistrado> Filtrar(Cierre_Inv_GloriaRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public List<Cierre_Inv_GloriaRegistrado> Listar()
        {
            throw new NotImplementedException();
        }

        public Cierre_Inv_GloriaRegistrado Registrar(Cierre_Inv_GloriaNuevo registroNuevo)
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                Cierre_Inv_Gloria nuevoCierre_Inv_Gloria = Mapper.Map<Cierre_Inv_Gloria>(registroNuevo);
                    db.Cierre_Inv_Gloria.Add(nuevoCierre_Inv_Gloria);
                    db.SaveChanges();
                return Mapper.Map<Cierre_Inv_GloriaRegistrado>(nuevoCierre_Inv_Gloria);
            }
        }
    }
}
