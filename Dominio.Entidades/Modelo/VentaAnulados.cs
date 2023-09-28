using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.Modelo
{
    public class VentaAnulados: EntidadBase
    {
        public string CODTIPODOC { get; set; }
        public string NRODOCU { get; set; }
        public string CODLINEA { get; set; }

    }
}
