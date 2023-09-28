using AutoMapper;
using CapaDatafirst;
using Servicios.Interfaces.Articulo;
using Servicios.Interfaces.Articulo.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDeArticulo : IGestorDeArticulo
    {
        public List<SP_LISTA_ARTICULO_FACT_Resp> SP_LISTA_ARTICULO_FACT(string cODEMPRESA, string cDZONA, int tIPO)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.SP_LISTA_ARTICULO_FACT(cODEMPRESA, cDZONA, tIPO).ToList().Select(x => Mapper.Map<SP_LISTA_ARTICULO_FACT_Resp>(x)).ToList();
            }
        }

        public List<SP_LISTA_ARTICULO_FACT_FILTRO_Resp> SP_LISTA_ARTICULO_FACT_FILTRO(string cODEMPRESA, string cDZONA, int? tIPO, string tEXTO)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.SP_LISTA_ARTICULO_FACT_FILTRO(cODEMPRESA, cDZONA, tIPO, tEXTO).ToList().Select(x => Mapper.Map<SP_LISTA_ARTICULO_FACT_FILTRO_Resp>(x)).ToList();
            }
        }
    }
}
