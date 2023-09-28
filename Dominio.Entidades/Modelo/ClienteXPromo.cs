using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.Modelo
{
    public class ClienteXPromo:EntidadBase
    {
        public string CODPROMO { get; set; }
        public string CODCLIENTE { get; set;}
        public string RAZONSOCIAL { get; set; }
        public string CODARTI_VTA { get; set; }
        
    }
}
