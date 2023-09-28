using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.PromoSubCat.Respuestas
{
    public class PromoSubCatRegistrado
    {
        public string CODEMPRESA { get; set; }
        public string CODPROMO { get; set; }
        public string DESPROMO { get; set; }
        public decimal PRECIO_PROMO { get; set; }
        public string CODZONA { get; set; }
        public string CODLINEA { get; set; }
        public string CODSUBLINEA { get; set; }
        public string CODPRESVTA { get; set; }
        public bool ESCALA { get; set; }
        public decimal DESDE_SOLES_ART { get; set; }
        public decimal HASTA_SOLES_ART { get; set; }

        public decimal SOLES_ART_VTA { get; set; }

        public string CODARTI_PROMO { get; set; }
        public string CODPRESPROM { get; set; }
        public decimal CANT_ARTI_PROMO { get; set; }
        public decimal STOCK_PROMO { get; set; }
        public System.DateTime FEC_INI { get; set; }
        public System.DateTime FEC_FIN { get; set; }
        public bool activar { get; set; }
        public bool XTIPOPRE { get; set; }
        public bool XCLIENTE { get; set; }

        public bool XCATEGORIA { get; set; }
        public bool XSUBCATEGORIA { get; set; }
    }
}
