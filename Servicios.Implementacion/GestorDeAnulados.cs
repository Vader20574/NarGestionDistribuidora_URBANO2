using Dominio.Contextos;
using Servicios.Interfaces.Anulados;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion
{
    public class GestorDeAnulados : IGestorDeAnulados
    {
        public void cur_tmp_datosprod_histo(string codempresa, string ventadethist, int histo, int correl)
        {

            using (DistribucionBD db = new DistribucionBD())
            {
                string cadena;
            var conn = db.Database.Connection;
            cadena = conn.ConnectionString.ToString();
            //cadena = "Data Source=.; Database=BDKIM120620; Trusted_connection=True;";

            using (SqlConnection sql = new SqlConnection(cadena))
              {
                using (SqlCommand cmd = new SqlCommand("CUR_TMP_DATOSPROD_HISTO", sql))
                {
                    cmd.CommandTimeout = 5000;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@CODEMPRESA", codempresa));
                    cmd.Parameters.Add(new SqlParameter("@VENTADETHIST", ventadethist));
                    cmd.Parameters.Add(new SqlParameter("@HISTO", histo));
                    cmd.Parameters.Add(new SqlParameter("@CORREL", correl));
                    //var response = new List<RespBuscarDocRegistrado>();
                    sql.Open();
                    var reader = cmd.ExecuteReader();
                }
              }
            }



        }
    }
}
