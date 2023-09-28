using CapaDatafirst;
using Servicios.Interfaces.VentaxCobrar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDeVentaxCobrar : IGestorDeVentaxCobrar
    {
        public void ModificarCodVend(string TipoDoc, decimal NroDoc, string codClienteDep, string CodVend)
        {
            //using (NARGESTEntities Bd = new NARGESTEntities())
            //{

            //    bool existe = Bd.VENTA_X_COBRAR.Any(x => x.CDTIPODOCUM == TipoDoc && x.NRODOCU == NroDoc && x.CDCLIENTEDEP == codClienteDep);
            //    if (existe == true)
            //    {
            //        VENTA_X_COBRAR venta_x_cobrar = Bd.VENTA_X_COBRAR.FirstOrDefault(x => x.CDTIPODOCUM.Equals(TipoDoc) && x.NRODOCU.Equals(NroDoc) && x.CDCLIENTEDEP.Equals(codClienteDep));
            //        venta_x_cobrar.codvend = CodVend;        
            //        Bd.Entry(venta_x_cobrar);
            //        Bd.SaveChanges();
            //    }

            //}
        }
    }
}
