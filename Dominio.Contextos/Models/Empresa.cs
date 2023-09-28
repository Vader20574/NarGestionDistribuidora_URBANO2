using System;
using System.Collections.Generic;

namespace Dominio.Contextos.Models
{
    public partial class Empresa
    {
        public DateTime? Datetrans { get; set; }
        public bool? Trans { get; set; }
        public string Ruc { get; set; }
        public string Razonsocialabr { get; set; }
        public string Razonsocial { get; set; }
        public string Codempresa { get; set; }
        public bool? Estado { get; set; }
        public string Direccion { get; set; }
        public string Registropatronal { get; set; }
    }
}
