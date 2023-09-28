using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Almacen.Peticiones
{
    public class AlmacenActualizar
    {
        public string codempresa { get; set; }
        public string CODALMACEN { get; set; }
        public Nullable<System.DateTime> DATETRANS { get; set; }
        public Nullable<bool> TRANS { get; set; }
        public Nullable<bool> ESTADO { get; set; }
        public Nullable<bool> AJUSTESTOCK { get; set; }
        public Nullable<System.DateTime> FECTOMAINV { get; set; }
        public string TERMINAL { get; set; }
        public Nullable<bool> ACTIVO { get; set; }
        public string DESALMACEN { get; set; }
        public string direccion { get; set; }
        public string CDTIPO { get; set; }
        public Nullable<bool> TIPO { get; set; }

    }
}
