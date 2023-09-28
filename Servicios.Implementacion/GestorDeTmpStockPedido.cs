using AutoMapper;
using CapaDatafirst;
using Servicios.Interfaces.TmpStockPedido;
using Servicios.Interfaces.TmpStockPedido.Peticiones;
using Servicios.Interfaces.TmpStockPedido.Respuestas;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDeTmpStockPedido : IGestorDeTmpStockPedido
    {
        public TmpStockPedidoRegistrado Actualizar(TmpStockPedidoActualizar registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int IdDelRegistro)
        {
            throw new NotImplementedException();
        }

        public int Extraer_Stock(string codarti, string alm, string correl)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return Convert.ToInt32(db.SP_EXTAER_STOCK(codarti, alm, correl).FirstOrDefault());
            }
        }

        public List<TmpStockPedidoRegistrado> Filtrar(TmpStockPedidoRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public List<TmpStockPedidoRegistrado> Listar()
        {
            throw new NotImplementedException();
        }

        public List<TmpStockPedidoRegistrado> Listar(string codempresa, int Correl)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {

                return db.TMP_STOCKPEDIDO.Where(x => (x.CODEMPRESA.Contains(codempresa)) && (x.CORREL.Equals(Correl))).ToList().Select(x => Mapper.Map<TmpStockPedidoRegistrado>(x)).ToList();
            }

        }

        public TmpStockPedidoRegistrado Registrar(TmpStockPedidoNuevo registroNuevo)
        {
            throw new NotImplementedException();
        }

        public void UPDATE_TMP_STOCKPEDIDO(string codemp, int correl, string codarti, decimal stk)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {



                try
                {

                    db.NSP_UPDATE_TMP_STOCKPEDIDO(codemp, correl, codarti, stk);
                }
                catch (DbEntityValidationException ex)
                {

                    // Retrieve the error messages as a list of strings.
                    var errorMessages = ex.EntityValidationErrors
                            .SelectMany(x => x.ValidationErrors)
                            .Select(x => x.ErrorMessage);

                    // Join the list to a single string.
                    var fullErrorMessage = string.Join("; ", errorMessages);

                    // Combine the original exception message with the new one.
                    var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                    // Throw a new DbEntityValidationException with the improved exception message.
                    throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
                }




            }
        }
    }
}
