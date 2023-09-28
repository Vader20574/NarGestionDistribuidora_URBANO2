using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.LineaCorreDoc.Peticiones
{

    public class LineaCorreDocNuevo 
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("codempresa")]
        public string Codempresa { get; set; }
       
        [JsonProperty("nrofac")]
        public decimal nrofac { get; set; }
     
        [JsonProperty("nrobol")]
        public decimal nrobol { get; set; }
       
        [JsonProperty("nrofacref")]
        public decimal nrofacRef { get; set; }
        [JsonProperty("nrobolref")]
        public decimal nrobolRef { get; set; }
        [JsonProperty("enviaelect")]
        public bool EnviaElect { get; set; }
        [JsonProperty("lineacodlinea")]
        public string LineaCodlinea { get; set; }


    }

}
