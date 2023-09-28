using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.Modelo
{
    public class TIPODOC1
    {
        public int Id;
        public Nullable<System.DateTime> DATETRANS { get; set; }
        public Nullable<bool> TRANS { get; set; }
        public Nullable<bool> ESTADO { get; set; }
        public Nullable<bool> NTACRE { get; set; }
        public string DSABRV { get; set; }
        public string DSTIPODOC { get; set; }
        public string CODTIPODOC { get; set; }
        public string CODEMPRESA { get; set; }
        public bool VTA { get; set; }
        public bool CONTABLE { get; set; }
        public bool COMPRBTECOBRO { get; set; }
        public bool COMPRBTEPAGO { get; set; }
        public Nullable<bool> PERCEP { get; set; }
        public Nullable<bool> PERCEPT { get; set; }
    }
}
