﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Cierre_Inv_Gloria.Peticiones
{
    public class Cierre_Inv_GloriaNuevo
    {
        public string AÑO { get; set; }
        public string MES { get; set; }
        public string ARTICULO { get; set; }
        public int STOCK { get; set; }
        public string ALMACEN { get; set; }
        public DateTime FECHA { get; set; }

    }
}