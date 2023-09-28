using CapaDatafirst;
using Servicios.Interfaces.HistoVentas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDeHistoVentas : IGestorDeHistoVentas
    {
        public string HistoVentas(string ventacab, string codempresa)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.VERIFICA_HISTORICOVENT(ventacab, codempresa).FirstOrDefault();
            }
        }
    }
}
