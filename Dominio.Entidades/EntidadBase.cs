using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class EntidadBase
    {
        public int Id { get; set; }
        public DateTime DiaHoraDeCreacion { get; set; }

        public DateTime UltimaDiaDeEdicion { get; set; }

        public bool FueBorrado { get; set; }
        public EntidadBase()
        {
            this.DiaHoraDeCreacion = DateTime.Now;
            this.UltimaDiaDeEdicion = DateTime.Now;
            this.FueBorrado = false;
        }
    }
}
