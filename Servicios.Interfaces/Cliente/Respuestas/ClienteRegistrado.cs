using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Cliente.Respuestas
{
    public class ClienteRegistrado
    {

        public string CODEMPRESA { get; set; }
        public string codcliente { get; set; }
        public Nullable<System.DateTime> DATETRANS { get; set; }
        public Nullable<bool> TRANS { get; set; }
        public Nullable<bool> ESTADO { get; set; }
        public Nullable<decimal> DESCUENTO { get; set; }
        public string CTA_LET { get; set; }
        public string CTA_ANT { get; set; }
        public string CTA_VTA { get; set; }
        public Nullable<decimal> SALDODISPONIBLE { get; set; }
        public Nullable<decimal> MTOLIMCRED { get; set; }
        public string telefono { get; set; }
        public string ruc { get; set; }
        public string direccion { get; set; }
        public string CODTIPOPAGO { get; set; }
        public string CODTIPCLI { get; set; }
        public string CODCIUDAD { get; set; }
        public string codvend { get; set; }
        public Nullable<decimal> CuotaT { get; set; }
        public Nullable<decimal> CuotaS { get; set; }
        public Nullable<decimal> cuotaD { get; set; }
        public string dni { get; set; }
        public string razonsocial { get; set; }
        public string materno { get; set; }
        public string paterno { get; set; }
        public string nombres { get; set; }
        public string codzona { get; set; }
        public string email { get; set; }
        public string TIPCREDFAC { get; set; }
        public string MONEDACRED { get; set; }
        public string pais { get; set; }
        public string contacto { get; set; }
        public string telecont { get; set; }
        public string celucont { get; set; }
        public string emailcont { get; set; }
        public string faxcliente { get; set; }
        public string DATOADJUNTO { get; set; }
        public string coddis { get; set; }
        public string iddepa { get; set; }
        public Nullable<bool> tipo { get; set; }
        public Nullable<System.DateTime> creacion { get; set; }
        public Nullable<bool> empleado { get; set; }
        public string RUTA { get; set; }
        public string TIPONEGOCIO { get; set; }
        public string CODTIPOPRE { get; set; }
        public string imagen { get; set; }
        public string imagen2 { get; set; }
        public Nullable<decimal> MPERCEP { get; set; }
        public Nullable<bool> ORT { get; set; }
        public string CODSegCliente { get; set; }
        public string CodCatCliente { get; set; }
        public Nullable<int> Visicoolers { get; set; }
        public string Cantidad { get; set; }
        public string Observacion { get; set; }
        public string CoordenadasX { get; set; }
        public string CoordenadasY { get; set; }
        public string DiasVisita { get; set; }
        public string Ubigeo { get; set; }
        public Nullable<int> IdClasif1 { get; set; }
        public Nullable<int> IdClasif2 { get; set; }
        public Nullable<int> IdClasif3 { get; set; }

    }
}
