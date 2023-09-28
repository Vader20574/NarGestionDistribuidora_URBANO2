using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Cierre_Mes_Inv.Respuestas
{
    public class Cierre_Mes_InvRegistrado
    {
        public string AÑO { get; set; }
        public string MES { get; set; }
        public string ARTICULO { get; set; }
        public Nullable<int> STOCK { get; set; }
        public string ALMACEN { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public byte[] TSTAMP { get; set; }
        public int ID { get; set; }
    }
}
