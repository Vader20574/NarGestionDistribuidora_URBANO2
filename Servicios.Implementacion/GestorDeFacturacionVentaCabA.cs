
using Servicios.Interfaces.Facturacion.VentaCab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios.Interfaces.Facturacion.VentaCab.Peticiones;
using Servicios.Interfaces.Facturacion.VentaCab.Respuestas;
using AutoMapper;
using CapaDatafirst;
using System.Data.Entity.Validation;
using Dominio.Contextos;
using Dominio.Entidades.Modelo;

namespace Servicios.Implementacion
{
    public class GestorDeFacturacionVentaCabA : IGestorDeFacturacionVentaCab
    {
        public VentaCabRegistrado Actualizar(VentacabActualizar registroParaActualizar)
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                VentaAnulados lineaModificar = Mapper.Map<VentaAnulados>(registroParaActualizar);
                db.VentaAnulados.Attach(lineaModificar);
                db.Entry(lineaModificar).Property(x => x.CODTIPODOC).IsModified = true;
                db.Entry(lineaModificar).Property(x => x.NRODOCU).IsModified = true;
                db.Entry(lineaModificar).Property(x => x.Id).IsModified = true;
                db.SaveChanges();
                return Mapper.Map<VentaCabRegistrado>(lineaModificar);

            }
        }


        public void Borrar(NuevaVentacab nuevoHdocumento)
        {
            using (DistribucionBD db = new DistribucionBD())
            {
                    VentaAnulados registro = db.VentaAnulados.FirstOrDefault(x => x.Id.Equals(nuevoHdocumento.ID));
                    db.VentaAnulados.Attach(registro);
                    db.VentaAnulados.Remove(registro);
                    db.SaveChanges();
            }
        }

      

        public VentaCabRegistrado CrearVentaCab(NuevaVentacab registroNuevo)
        {
            var ventacab = Mapper.Map<VentaAnulados>(registroNuevo);
            using (DistribucionBD db = new DistribucionBD()) 
            {
                try
                {
                    bool existe = db.VentaAnulados.Any(x => x.NRODOCU == registroNuevo.NRODOCU && x.CODTIPODOC.Equals(registroNuevo.CODTIPODOC) && x.CODLINEA.Equals(registroNuevo.CODVEND));
                    if (existe == false)
                    {
                        ventacab.CODLINEA = registroNuevo.CODVEND;
                        db.VentaAnulados.Add(ventacab);
                        db.SaveChanges();
                    }
                    else
                    {

                    }
                }
                catch (DbEntityValidationException ex)
                {

                    // Retrieve the error messages as a list of strings.
                    var errorMessages = ex.EntityValidationErrors
                            .SelectMany(x => x.ValidationErrors)
                            .Select(x => x.ErrorMessage);

                    // Join the list to a single string.
                    var fullErrorMessage = string.Join("; ", errorMessages);

                    // Combine the original exception message with the new one.
                    var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                    // Throw a new DbEntityValidationException with the improved exception message.
                    throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
                }

            }
            return Mapper.Map<VentaCabRegistrado>(ventacab);
        }

        public List<VentaCabRegistrado> Filtrar(VentaCabRegistrado registroGuardos)
        {

            using (DistribucionBD db = new DistribucionBD())
            {
                return db.VentaAnulados.Where(x => (x.NRODOCU.Contains(registroGuardos.NRODOCU.ToString()) || x.CODTIPODOC.Contains(registroGuardos.CODTIPODOC.ToString())) && x.CODLINEA.Contains(registroGuardos.CODVEND.ToString()))
                                         .ToList()
                                         .Select(x => Mapper.Map<VentaCabRegistrado>(x) )
                                         .ToList();

            }

        }

        public List<VentaCabRegistrado> Listar()
        {
            throw new NotImplementedException();
        }

        
    }
}
