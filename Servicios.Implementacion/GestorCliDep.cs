using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CapaDatafirst;
using Servicios.Interfaces.CliDep;
using Servicios.Interfaces.CliDep.Peticiones;
using Servicios.Interfaces.CliDep.Respuestas;

namespace Servicios.Implementacion
{
    public class GestorCliDep : IGestorDeCliDep
    {
        public CliDepRegistrado Actualizar(CliDepActualizar registroParaActualizar)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {

            CLIDEP nuevoCliDep = db.CLIDEP.Find(registroParaActualizar.CODCLIENTE);
            nuevoCliDep.CODEMPRESA = registroParaActualizar.CODEMPRESA;
            nuevoCliDep.CODDEP= registroParaActualizar.CODDEP;
            nuevoCliDep.CODCLIENTE = registroParaActualizar.CODCLIENTE;
            nuevoCliDep.ACTIVO = registroParaActualizar.ACTIVO;
            nuevoCliDep.CODRUTA = registroParaActualizar.CODRUTA;
            nuevoCliDep.CODDISTRITO = registroParaActualizar.CODDISTRITO;
            nuevoCliDep.MPERCEP = registroParaActualizar.MPERCEP;
            nuevoCliDep.notapedido = registroParaActualizar.notapedido;
            nuevoCliDep.ORT = registroParaActualizar.ORT;

            db.SaveChanges();

            return Mapper.Map<CliDepRegistrado>(nuevoCliDep);
            }
        }

        public void Borrar(int IdDelRegistro)
        {
            throw new NotImplementedException();
        }

        public string Busq_dep_cliente(string codempresa, string codcliente)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {

                var result = (from CD in db.CLIDEP
                              join CLI in db.CLIENTE on CD.CODCLIENTE equals CLI.codcliente
                              where (CD.CODEMPRESA == codempresa && CD.CODDEP == codcliente)
                              select new
                              {
                                  CODCLIENTE = CD.CODCLIENTE,
                              }).FirstOrDefault();

                if (result != null)
                {
                    return Convert.ToString(result.CODCLIENTE);
                }
                else
                {
                    return null;
                }
            }
        }

        public string Busq_dep_DatoAdjunto(string codempresa, string datoadjunto)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {

                var result = (from CD in db.CLIDEP
                              join CLI in db.CLIENTE on CD.CODCLIENTE equals CLI.codcliente
                              where (CD.CODEMPRESA == codempresa && CLI.DATOADJUNTO == datoadjunto)
                              select new
                              {
                                  CODCLIENTE = CD.CODCLIENTE,
                              }).FirstOrDefault();

                if (result != null)
                {
                    return Convert.ToString(result.CODCLIENTE);
                }
                else
                {
                    return null;
                }
            }
        }

        public string Busq_dep_DatoAdjunto2(string codempresa, string datoadjunto, string codclidep)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {

                var result = (from CD in db.CLIDEP
                              join CLI in db.CLIENTE on CD.CODCLIENTE equals CLI.codcliente
                              where (CD.CODEMPRESA == codempresa && CLI.DATOADJUNTO == datoadjunto && CLI.codcliente != codclidep)
                              select new
                              {
                                  CODCLIENTE = CD.CODCLIENTE,
                              }).FirstOrDefault();

                if (result != null)
                {
                    return Convert.ToString(result.CODCLIENTE);
                }
                else
                {
                    return null;
                }
            }
        }

        public void EliminarClidep(string codempresa, string coddep)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                CLIDEP clidepdelete = new CLIDEP() { CODDEP = coddep.ToString() };
                db.CLIDEP.Attach(clidepdelete);
                db.CLIDEP.Remove(clidepdelete);
                db.SaveChanges();

            }
        }

        public List<CliDepRegistrado> Filtrar(CliDepRegistrado registroGuardos)
        {
            throw new NotImplementedException();
        }

        public CliDepRegistrado FindById(string Id)
        {

            using (NARGESTEntities db = new NARGESTEntities())
            {
                return Mapper.Map<CliDepRegistrado>(db.CLIDEP.Find(Id));
            }

        }

        public List<CliDepRegistrado> Listar()
        {
            throw new NotImplementedException();
        }

        public List<CliDepRegistrado> ListarXCodCliente(CliDepRegistrado clidepregistrados)
        {


            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.CLIDEP.Where(x => (x.CODDEP.Contains(clidepregistrados.CODDEP)))
                .ToList().Select(x => Mapper.Map<CliDepRegistrado>(x))
                .ToList();

            }



        }

        public List<CliDepRegistradoMasOK> ListarXCodDep(CliDepRegistradoMasOK clidepregistrados)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {

                var result = (from CD in db.CLIDEP
                              join CLI in db.CLIENTE on CD.CODCLIENTE equals CLI.codcliente
                              join DIS in db.Distrito on CD.CODDISTRITO equals DIS.CodDis
                              join RUT in db.RUTA on CLI.RUTA equals RUT.CODIGO

                              where (CD.CODEMPRESA == clidepregistrados.CODEMPRESA && CD.CODDEP == clidepregistrados.CODDEP)
                              select new
                              {
                                  CODEMPRESA = CD.CODEMPRESA,
                                  CODDEP = CD.CODDEP,
                                  CODCLIENTE = CD.CODCLIENTE,
                                  ACTIVO = CD.ACTIVO,
                                  CODRUTA = CD.CODRUTA,
                                  CODDISTRITO = CD.CODDISTRITO,
                                  MPERCEP = CD.MPERCEP,
                                  notapedido = CD.notapedido,
                                  ORT = CD.ORT,
                                  DATOADJUNTO = CLI.DATOADJUNTO,
                                  direccion = CLI.direccion,
                                  ruc = CLI.ruc,
                                  dni = CLI.dni,
                                  CODCIUDAD = CLI.CODCIUDAD,
                                  DISTRITO = DIS.Descripcion,
                                  RUTA = RUT.DESCRIPCION,

                              }).ToList();

                List<CliDepRegistradoMasOK> ListCliDep = new List<CliDepRegistradoMasOK>();


                result.ForEach(dto => {
                    CliDepRegistradoMasOK clidep = new CliDepRegistradoMasOK();
                    clidep.CODEMPRESA = dto.CODEMPRESA;
                    clidep.CODCLIENTE = dto.CODCLIENTE;
                    clidep.CODDEP = dto.CODDEP;
                    clidep.ACTIVO = dto.ACTIVO;
                    clidep.CODRUTA = dto.CODRUTA;
                    clidep.CODDISTRITO = dto.CODDISTRITO;
                    clidep.MPERCEP = dto.MPERCEP;
                    clidep.notapedido = dto.notapedido;
                    clidep.ORT = dto.ORT;
                    clidep.DATOADJUNTO = dto.DATOADJUNTO;
                    clidep.direccion = dto.direccion;
                    clidep.ruc = dto.ruc;
                    clidep.dni = dto.dni;
                    clidep.CODCIUDAD = dto.CODCIUDAD;
                    clidep.DISTRITO = dto.DISTRITO;
                    clidep.RUTA = dto.RUTA;
                    ListCliDep.Add(clidep);
                });

                return ListCliDep;
            }


        }

        public CliDepRegistrado Registrar(CliDepNuevo registroNuevo)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                CLIDEP nuevoClidep = Mapper.Map<CLIDEP>(registroNuevo);
                bool existe = db.CLIDEP.Any(x => x.CODCLIENTE == registroNuevo.CODCLIENTE);
                if (existe == false)
                {
                    db.CLIDEP.Add(nuevoClidep);
                    db.SaveChanges();
                }
                else
                {
                    //MessageBox.Show("Hola");
                }
                return Mapper.Map<CliDepRegistrado>(nuevoClidep);
            }
        }
    }
}
