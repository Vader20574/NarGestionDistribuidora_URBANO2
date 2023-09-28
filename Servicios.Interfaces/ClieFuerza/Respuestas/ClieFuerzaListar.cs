using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.ClieFuerza.Respuestas
{
    public class ClieFuerzaListar
    {
        public int Id { get; set; }
        public string CODFUERZA { get; set; }
        public string DESCRIPCION { get; set; }
        public Nullable<decimal> CREDITO_F { get; set; }
        public Nullable<decimal> SALDO_CREDF { get; set; }

    }
}
