using Servicios.Interfaces.Linea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios.Interfaces.Linea.Peticiones;
using Servicios.Interfaces.Linea.Respuestas;
using CapaDatafirst;
using AutoMapper;

namespace Servicios.Implementacion
{
    public class GestorDeLinea : IGestorDeLinea
    {
        public LineaRegistrado Actualizar(LineaActualizar registroParaActualizar)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int IdDelRegistro)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                LINEA nuevaLinea = new LINEA() { CODLINEA = IdDelRegistro.ToString() };
                db.LINEAs.Attach(nuevaLinea);
                db.LINEAs.Remove(nuevaLinea);
                db.SaveChanges();

            }
        }

        public List<LineaRegistrado> Filtrar(LineaRegistrado registroGuardos)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.LINEAs.Where(x => x.CODLINEA.Contains(registroGuardos.CODLINEA.ToString()) || x.DESLINEA.Contains(registroGuardos.DESLINEA.ToString()))
                                         .ToList()
                                         .Select(x => Mapper.Map<LineaRegistrado>(x))
                                         .ToList();
            }
        }

        public List<LineaRegistrado> Listar()
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                return db.LINEAs.ToList().Select(x => Mapper.Map<LineaRegistrado>(x)).ToList();
            }
        }

        public LineaRegistrado Registrar(LineaNuevo registroNuevo)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                LINEA nuevoLinea = Mapper.Map<LINEA>(registroNuevo);
                bool existe = db.LINEAs.Any(x => x.CODLINEA == registroNuevo.CODLINEA);
                if (existe == false)
                {
                    db.LINEAs.Add(nuevoLinea);
                    db.SaveChanges();
                }
                else
                {
                    //MessageBox.Show("Hola");
                }


                return Mapper.Map<LineaRegistrado>(nuevoLinea);
            }
        }
    }
}
