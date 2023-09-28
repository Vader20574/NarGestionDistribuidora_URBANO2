using AutoMapper;
using Dominio.Contextos;
using Dominio.Entidades.Modelo;
using Servicios.Interfaces.Facturacion.VentaCab;
using Servicios.Interfaces.Facturacion.VentaCab.Peticiones;
using Servicios.Interfaces.Facturacion.VentaCab.Respuestas;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDeFacturacionElectronicaDirecta : IGestorDeFacturacionVentaCab
    {
        public VentaCabRegistrado Actualizar(VentacabActualizar registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(NuevaVentacab registroGuardos)
        {
            throw new NotImplementedException();
        }

        public VentaCabRegistrado CrearVentaCab(NuevaVentacab registroNuevo)
        {
            var ventacabfe = Mapper.Map<VentaCabFE>(registroNuevo);
            using (DistribucionBD Bd = new DistribucionBD())
            {
                Bd.VentaCabFE.Add(ventacabfe);
                Bd.SaveChanges();
            }
            return Mapper.Map<VentaCabRegistrado>(ventacabfe);
        }

        public List<VentaCabRegistrado> Filtrar(VentaCabRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }
    }
}
