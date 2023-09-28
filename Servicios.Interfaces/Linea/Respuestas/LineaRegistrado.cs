using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Linea.Respuestas
{
    public class LineaRegistrado
    {
        [JsonProperty("codempresa")]
        public string CODEMPRESA { get; set; }
        [JsonProperty("codlinea")]
        public string CODLINEA { get; set; }
        [JsonProperty("deslinea")]
        public string DESLINEA { get; set; }
        [JsonProperty("estado")]
        public Nullable<bool> ESTADO { get; set; }
        [JsonProperty("trans")]
        public Nullable<bool> TRANS { get; set; }
        [JsonProperty("datetrans")]
        public Nullable<System.DateTime> DATETRANS { get; set; }
        [JsonProperty("codtipoprod")]
        public string CODTIPOPROD { get; set; }
        [JsonProperty("correlativo")]
        public decimal CORRELATIVO { get; set; }
    }
}
