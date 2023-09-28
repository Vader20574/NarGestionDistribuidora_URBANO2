using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.Modelo
{
    public class Supervisor
    {
        public string Codempresa { get; set; }
        [Key]
        public string Codsuperv { get; set; }
        public string Dssuperv { get; set; }
        public string Direccion { get; set; }

        public decimal nrofac { get; set; }
        public decimal nrobol { get; set; }
        public decimal nroped { get; set; }

        public decimal nrofacRef { get; set; }
        public decimal nrobolRef { get; set; }
        public decimal nropedRef { get; set; }


        public bool EDESE { get; set; }
        public bool GIEF { get; set; }
        public bool GIEB { get; set; }


    }
}
