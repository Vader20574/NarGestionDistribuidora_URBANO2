using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.ClienteXPromoSubCat.Respuestas
{
    public class ClienteXPromoSubCatRegistrado
    {
        public int Id { get; set; }
        public string CODPROMO { get; set; }
        public string CODCLIENTE { get; set; }
        public string RAZONSOCIAL { get; set; }
        public string CODSUBLINEA { get; set; }
    }
}
