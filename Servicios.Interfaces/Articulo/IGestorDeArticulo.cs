using Servicios.Interfaces.Articulo.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Articulo
{
    public interface IGestorDeArticulo
    {
        List<SP_LISTA_ARTICULO_FACT_Resp> SP_LISTA_ARTICULO_FACT(string cODEMPRESA, string cDZONA, int tIPO);
     
      List<SP_LISTA_ARTICULO_FACT_FILTRO_Resp> SP_LISTA_ARTICULO_FACT_FILTRO(string cODEMPRESA, string cDZONA, Nullable<int> tIPO, string tEXTO);

    }
}
