using AutoMapper;
using Dominio.Contextos;
using Dominio.Entidades.Modelo;
using Servicios.Interfaces.Facturacion.VentaDet;
using Servicios.Interfaces.Facturacion.VentaDet.Peticiones;
using Servicios.Interfaces.Facturacion.VentaDet.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDeFacturacionElectronicaDirectaD : IGestorDeFacturacionVentaDet
    {
        public VentaDetRegistrado Actualizar(VentaDetActualizar registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int IdDelRegistro)
        {
            throw new NotImplementedException();
        }

        public List<VentaDetRegistrado> Filtrar(VentaDetRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public List<VentaDetRegistrado> Listar()
        {
            throw new NotImplementedException();
        }

        public VentaDetRegistrado Registrar(NuevaVentaDet registroNuevo)
        {
            var ventadetfe = Mapper.Map<VentaDetFE>(registroNuevo);
            using (DistribucionBD Bd = new DistribucionBD())
            {
                Bd.VentaDetFE.Add(ventadetfe);
                Bd.SaveChanges();
            }
            return Mapper.Map<VentaDetRegistrado>(ventadetfe);
        }
    }
}
