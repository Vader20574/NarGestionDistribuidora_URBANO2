using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.ClieFuerza.Peticiones
{
    public class ClieFuerzaActualizar
    {
        public string CODEMPRESA { get; set; }
        public string CODCLIE { get; set; }
        public string CODFUERZA { get; set; }
        public Nullable<decimal> CREDITO_F { get; set; }
        public Nullable<decimal> SALDO_CREDF { get; set; }
        public int ID { get; set; }
    }
}
