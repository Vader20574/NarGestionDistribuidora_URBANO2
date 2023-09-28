using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.Modelo
{
    public class Cierre_Inv_Protisa : EntidadBase
    {
        public string AÑO { get; set; }
        public string MES { get; set; }
        public string ARTICULO { get; set; }
        public int STOCK { get; set; }
        public string ALMACEN { get; set; }
        public DateTime FECHA { get; set; }
    }
}
