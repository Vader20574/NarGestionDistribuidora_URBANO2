using Dominio.Contextos;
using Servicios.Interfaces.RequerimientoTienda;
using Servicios.Interfaces.RequerimientoTienda.Respuestas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDeRequerimientoTienda : IGestorDeRequerimientoTienda
    {

        public List<RequerimientoTiendaReg> ListarRequerimientoTienda(string FecIni, string FecFin)
        {


            using (DistribucionBD db = new DistribucionBD())
            {
               string cadena;
            var conn = db.Database.Connection;
            cadena = conn.ConnectionString.ToString();
            //cadena = "Data Source=.; Database=BDKIM120620; Trusted_connection=True;";

            using (SqlConnection sql = new SqlConnection(cadena))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_RequerimientoTienda", sql))
                {
                    cmd.CommandTimeout = 5000;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FECHA1", FecIni));
                    cmd.Parameters.Add(new SqlParameter("@FECHA2", FecFin));
             
                    var response = new List<RequerimientoTiendaReg>();
                    sql.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            response.Add(MapToRespRequerimientoTiendaReg(reader));
                        }
                    }

                    return response;
                }
            }

            }

        

        }


        private RequerimientoTiendaReg MapToRespRequerimientoTiendaReg(SqlDataReader reader)
        {
            return new RequerimientoTiendaReg()
            {

                Nrodocu = reader["NRODOCU"].ToString(),
       



            };
        }



    }
}
