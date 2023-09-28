using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CapaDatafirst;
using Servicios.Interfaces.Cliente;
using Servicios.Interfaces.Cliente.Peticiones;
using Servicios.Interfaces.Cliente.Respuestas;
using Servicios.Interfaces.Facturacion.VentaCab.Respuestas;

namespace Servicios.Implementacion
{
    public class GestorDeCliente : IGestorDeCliente
    {
        public ClienteRegistrado Actualizar(ClienteActualizar registroParaActualizar)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {            

                CLIENTE nuevoCliente = db.CLIENTE.Find(registroParaActualizar.codcliente);
              
                nuevoCliente.CODEMPRESA = registroParaActualizar.CODEMPRESA;
                nuevoCliente.DESCUENTO = registroParaActualizar.DESCUENTO;
                nuevoCliente.CTA_LET = registroParaActualizar.CTA_LET;
                nuevoCliente.CTA_ANT = registroParaActualizar.CTA_ANT;
                nuevoCliente.CTA_VTA = registroParaActualizar.CTA_ANT;
                nuevoCliente.SALDODISPONIBLE = registroParaActualizar.SALDODISPONIBLE;
                nuevoCliente.MTOLIMCRED = registroParaActualizar.MTOLIMCRED;
                nuevoCliente.telefono = registroParaActualizar.telefono;
                nuevoCliente.ruc = registroParaActualizar.ruc;
                nuevoCliente.direccion = registroParaActualizar.direccion;
                nuevoCliente.codcliente = registroParaActualizar.codcliente;
                nuevoCliente.CODTIPOPAGO = registroParaActualizar.CODTIPOPAGO;
                nuevoCliente.CODTIPCLI = registroParaActualizar.CODTIPCLI;
                nuevoCliente.CODCIUDAD = registroParaActualizar.CODCIUDAD;
                nuevoCliente.CODEMPRESA = registroParaActualizar.CODEMPRESA;
                nuevoCliente.CuotaT = registroParaActualizar.CuotaT;
                nuevoCliente.CuotaS = registroParaActualizar.CuotaS;
                nuevoCliente.cuotaD = registroParaActualizar.cuotaD;
                nuevoCliente.razonsocial = registroParaActualizar.razonsocial;
                nuevoCliente.materno = registroParaActualizar.materno;
                nuevoCliente.paterno = registroParaActualizar.paterno;
                nuevoCliente.nombres = registroParaActualizar.nombres;
                nuevoCliente.codzona = registroParaActualizar.codzona;
                nuevoCliente.dni = registroParaActualizar.dni;
                nuevoCliente.email = registroParaActualizar.email;
                nuevoCliente.TIPCREDFAC = registroParaActualizar.TIPCREDFAC;
                nuevoCliente.MONEDACRED = registroParaActualizar.MONEDACRED;
                nuevoCliente.pais = registroParaActualizar.pais;
                nuevoCliente.contacto = registroParaActualizar.contacto;
                nuevoCliente.telecont = registroParaActualizar.telecont;
                nuevoCliente.celucont = registroParaActualizar.celucont;
                nuevoCliente.emailcont = registroParaActualizar.emailcont;
                nuevoCliente.faxcliente = registroParaActualizar.faxcliente;
                nuevoCliente.iddepa = registroParaActualizar.iddepa;
                nuevoCliente.coddis = registroParaActualizar.coddis;
                nuevoCliente.empleado = registroParaActualizar.empleado;
                nuevoCliente.RUTA = registroParaActualizar.RUTA;
                nuevoCliente.TIPONEGOCIO = registroParaActualizar.TIPONEGOCIO;
                nuevoCliente.CODTIPOPRE = registroParaActualizar.CODTIPOPRE;
                nuevoCliente.imagen = "";
                nuevoCliente.imagen2 = "";
                nuevoCliente.ORT = registroParaActualizar.ORT;
                nuevoCliente.CodCatCliente = registroParaActualizar.CodCatCliente;
                nuevoCliente.CODSegCliente = registroParaActualizar.CODSegCliente;
                nuevoCliente.Visicoolers = registroParaActualizar.Visicoolers;
                nuevoCliente.Cantidad = registroParaActualizar.Cantidad;
                nuevoCliente.Observacion = registroParaActualizar.Observacion;
                nuevoCliente.CoordenadasX = registroParaActualizar.CoordenadasX;
                nuevoCliente.CoordenadasY = registroParaActualizar.CoordenadasY;
                nuevoCliente.DiasVisita = registroParaActualizar.DiasVisita;
                nuevoCliente.DATOADJUNTO = registroParaActualizar.DATOADJUNTO;
                nuevoCliente.ESTADO = registroParaActualizar.ESTADO;
                nuevoCliente.creacion = registroParaActualizar.creacion;
                nuevoCliente.Ubigeo = registroParaActualizar.Ubigeo;
                nuevoCliente.IdClasif1 = registroParaActualizar.IdClasif1;
                nuevoCliente.IdClasif2 = registroParaActualizar.IdClasif2;
                nuevoCliente.IdClasif3 = registroParaActualizar.IdClasif3;

                db.SaveChanges();
                return Mapper.Map<ClienteRegistrado>(nuevoCliente);
            }
        }

        public void Borrar(int IdDelRegistro)
        {
           
        }

        public int Busq_cliedep_vta(string codempresa, string coddep, string ventacab)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return Convert.ToInt16(db.SP_BUSQUEDA_CLIENTEDEP_VTA(codempresa, coddep, ventacab).FirstOrDefault());
            }
        }

        public string Busq_clie_ped(string codempresa, string codcliente)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.SP_BUSQUEDA_CLIENTE_PEDIDO(codempresa, codcliente).FirstOrDefault();
            }
        }

        public int Busq_clie_vta(string codempresa, string coddep, string ventacab)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return Convert.ToInt16(db.SP_BUSQUEDA_CLIENTE_VTA(codempresa, coddep, ventacab).FirstOrDefault());
            }
        }

        public double CobranzaXCliente(string codempresa, string codcliente)
        {
            double result;

            using (NARGESTEntities db = new NARGESTEntities())
            {
                result=  Convert.ToDouble(db.SP_SELECT_COBRANZAXCLIENTE(codempresa, codcliente).FirstOrDefault());
                return result;
            }
        }

        public void EliminarCliente(string codcliente)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                CLIENTE clientedelete = new CLIENTE() { codcliente = codcliente.ToString() };
                db.CLIENTE.Attach(clientedelete);
                db.CLIENTE.Remove(clientedelete);
                db.SaveChanges();

            }
        }

        public void EliminarSusClidep(string codempresa, string codcliente)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {

                var result = (from CD in db.CLIDEP
                              join CLI in db.CLIENTE on CD.CODCLIENTE equals CLI.codcliente
                              where (CD.CODEMPRESA == codempresa && CD.CODDEP == codcliente)
                              select new
                              {
                                  CODCLIENTE = CD.CODCLIENTE,
                              }).ToList();


                result.ForEach(dto =>
                {
                    CLIENTE clientedelete = new CLIENTE() {codcliente = dto.CODCLIENTE.ToString() };
                    db.CLIENTE.Attach(clientedelete);
                    db.CLIENTE.Remove(clientedelete);
                    db.SaveChanges();

                    CLIDEP clidepdelete = new CLIDEP() { CODCLIENTE = dto.CODCLIENTE.ToString() };
                    db.CLIDEP.Attach(clidepdelete);
                    db.CLIDEP.Remove(clidepdelete);
                    db.SaveChanges();


                });


            }
        }

        public List<ClienteRegistrado> Filtrar(ClienteRegistrado registroGuardos)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.CLIENTE.Where(x => (x.codcliente.Contains(registroGuardos.codcliente.ToString())))
                            .ToList()
                            .Select(x => Mapper.Map<ClienteRegistrado>(x))
                            .ToList();
            }
        }

        public List<ClienteRegistrado> FiltrarxCodCliente(ClienteRegistrado registroGuardos)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {

                return db.CLIENTE.Where(x => (x.codcliente.Contains(registroGuardos.codcliente.ToString())))
                    .ToList()
                            .Select(x => Mapper.Map<ClienteRegistrado>(x))
                            .ToList();
            }
        }

        public List<ClienteRegistrado> FiltrarxDatoAdjunto1(string DatoAdjunto)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.CLIENTE.Where(x => (x.DATOADJUNTO.Contains(DatoAdjunto.ToString()) && x.TRANS==false))
                //return db.CLIENTE.Where(x => (x.DATOADJUNTO.Contains(DatoAdjunto.ToString()) ))
                    .ToList()
                            .Select(x => Mapper.Map<ClienteRegistrado>(x))
                            .ToList();
            }
        }

        public List<ClienteRegistrado> FiltrarxDatoAdjunto2(string DatoAdjunto, string codcliente)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {

                return db.CLIENTE.Where(x => (x.DATOADJUNTO.Contains(DatoAdjunto.ToString()) && (x.codcliente!=codcliente.ToString()) && x.TRANS==false))
                    .ToList()
                            .Select(x => Mapper.Map<ClienteRegistrado>(x))
                            .ToList();
            }
        }

        public List<ClienteRegistrado> FiltrarxTodos(ClienteRegistrado registroGuardos)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {

                return db.CLIENTE.Where(x => (x.codcliente.Contains(registroGuardos.codcliente.ToString()) || x.DATOADJUNTO.Contains(registroGuardos.DATOADJUNTO.ToString()) || x.direccion.Contains(registroGuardos.direccion.ToString()) || x.ruc.Contains(registroGuardos.ruc.ToString()) || x.dni.Contains(registroGuardos.dni.ToString())))
                            .ToList()
                            .Select(x => Mapper.Map<ClienteRegistrado>(x))
                            .ToList();
            }
        }

        public List<CIienteSelecionado1> FiltrarxTodos2(CIienteSelecionado1 registroGuardos)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {

                return db.CLIENTE.ToList()
                            .Select(x => Mapper.Map<CIienteSelecionado1>(x))
                            .ToList();
            }
        }

        public ClienteRegistrado FindById(string Id)
        {
           

            using (NARGESTEntities db = new NARGESTEntities())
            {

                return Mapper.Map<ClienteRegistrado>(db.CLIENTE.Find(Id));
            }


        }

        public List<ClienteRegistrado> Listar()
        {
            throw new NotImplementedException();
        }

        public ClienteRegistrado Registrar(ClienteNuevo registroNuevo)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                CLIENTE nuevoCliente = Mapper.Map<CLIENTE>(registroNuevo);
                bool existe = db.CLIENTE.Any(x => x.codcliente== registroNuevo.codcliente);
                if (existe == false)
                {
                    db.CLIENTE.Add(nuevoCliente);
                    db.SaveChanges();
                }
                else
                {
                    //MessageBox.Show("Hola");
                }
                return Mapper.Map<ClienteRegistrado>(nuevoCliente);
            }
        }

        public decimal SumPedidos(string codcliente)
        {
            decimal result;
            using (NARGESTEntities db = new NARGESTEntities())
            {

                result =Convert.ToDecimal(db.SP_SUMPEDIDO(codcliente).FirstOrDefault());
                return result;
            }
        }
    }
}
