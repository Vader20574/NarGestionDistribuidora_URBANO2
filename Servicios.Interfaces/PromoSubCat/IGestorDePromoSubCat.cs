using Servicios.Interfaces.Compartido;
using Servicios.Interfaces.PromoSubCat.Peticiones;
using Servicios.Interfaces.PromoSubCat.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Servicios.Interfaces.PromoSubCat
{
    public interface IGestorDePromoSubCat : IMantenimientoBase<PromoSubCatNuevo, PromoSubCatActualizar, PromoSubCatRegistrado>
    {
        PromoSubCatRegistrado FindById(string Id);
        void Borrar(string codemp, string codpromo);
    }
}
