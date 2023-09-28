using AutoMapper;
using CapaDatafirst;
using Servicios.Interfaces.ClieFuerza;
using Servicios.Interfaces.ClieFuerza.Peticiones;
using Servicios.Interfaces.ClieFuerza.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDeClieFuerza : IGestorDeClieFuerza
    {
        public ClieFuerzaRegistrado Actualizar(ClieFuerzaActualizar registroParaActualizar)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {

                CLIE_FUERZA regcliefuerza = db.CLIE_FUERZA.Find(registroParaActualizar.ID);
                regcliefuerza.CODEMPRESA = registroParaActualizar.CODEMPRESA;
                regcliefuerza.CODCLIE = registroParaActualizar.CODCLIE;
                regcliefuerza.CODFUERZA = registroParaActualizar.CODFUERZA;
                regcliefuerza.CREDITO_F = registroParaActualizar.CREDITO_F;
                regcliefuerza.SALDO_CREDF= registroParaActualizar.SALDO_CREDF;
              

                db.SaveChanges();

                return Mapper.Map<ClieFuerzaRegistrado>(regcliefuerza);
            }
        }

        public void Borrar(int IdDelRegistro)
        {
            throw new NotImplementedException();
        }

        public void EliminarXCliente(string codcliente)
        {

            using (NARGESTEntities db = new NARGESTEntities())
            {
                var clie_fuerza = db.CLIE_FUERZA.FirstOrDefault(x => x.CODCLIE == codcliente);// object your want to delete
                if (  clie_fuerza != null)
                {
                db.CLIE_FUERZA.Remove(clie_fuerza);
                db.SaveChanges();
                }
            }

        }

        public List<ClieFuerzaRegistrado> Filtrar(ClieFuerzaRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public List<ClieFuerzaRegistrado> Listar()
        {
            throw new NotImplementedException();
        }

        public List<ClieFuerzaListar> ListarXClieFuerza(ClieFuerzaRegistrado cliefuerzaregistrados)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {

                var result = (from C in db.CLIE_FUERZA
                              join F in db.FUERZAVENTA on C.CODFUERZA equals F.CODIGO
                     
                              where (C.CODEMPRESA == cliefuerzaregistrados.CODEMPRESA && C.CODCLIE == cliefuerzaregistrados.CODCLIE)
                              select new
                              {    
                                  Id= C.ID,
                                  CODFUERZA = C.CODFUERZA,
                                  DESCRIPCION = F.DESCRIPCION,
                                  CREDITO_F = C.CREDITO_F,
                                  SALDO_CREDF = C.SALDO_CREDF,
                                 

                              }).ToList();

                List<ClieFuerzaListar> ListClieFuerza = new List<ClieFuerzaListar>();


                result.ForEach(dto => {
                    ClieFuerzaListar cliefuerzalist = new ClieFuerzaListar();
                    cliefuerzalist.Id = dto.Id;
                    cliefuerzalist.CODFUERZA = dto.CODFUERZA;
                    cliefuerzalist.DESCRIPCION = dto.DESCRIPCION;
                    cliefuerzalist.CREDITO_F= dto.CREDITO_F;
                    cliefuerzalist.SALDO_CREDF = dto.SALDO_CREDF;

                    ListClieFuerza.Add(cliefuerzalist);
                });

                return ListClieFuerza;
            }

        }

        public ClieFuerzaRegistrado Registrar(ClieFuerzaNuevo registroNuevo)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                CLIE_FUERZA nuevocliefuerza = Mapper.Map<CLIE_FUERZA>(registroNuevo);
                bool existe = db.CLIE_FUERZA.Any(x => x.CODCLIE == registroNuevo.CODCLIE.ToString());
                if (existe == false)
                {
                    db.CLIE_FUERZA.Add(nuevocliefuerza);
                    db.SaveChanges();
                }
                else
                {
                    //MessageBox.Show("Hola");
                }
                return Mapper.Map<ClieFuerzaRegistrado>(nuevocliefuerza);
            }
        }
    }
}
