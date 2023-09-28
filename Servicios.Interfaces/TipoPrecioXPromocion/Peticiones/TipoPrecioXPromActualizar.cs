using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.TipoPrecioXPromocion.Peticiones
{
    public class TipoPrecioXPromActualizar
    {
        public string CODEMPRESA { get; set; }
        public string CODPROMO { get; set; }
        public string CODTIPOPRE { get; set; }
        public string DSTIPOPRE { get; set; }
        public string CODIGO { get; set; }
        public int Id { get; set; }

    }
}
