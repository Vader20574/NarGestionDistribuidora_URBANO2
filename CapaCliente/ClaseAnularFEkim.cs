using Common.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaCliente
{
    public class ClaseAnularFEkim
    {

        IApiService apiService = new ApiService();

        public  ClaseAnularFEkim(string serie, string nume, string codtipodoc)
        {

            AnularFact( serie,  nume,  codtipodoc);
        }


        private async void AnularFact(string serie, string nume, string codtipodoc)
        {
            string url;
            url = System.Configuration.ConfigurationManager.AppSettings["url"].ToString();

            var response = await this.apiService.PostAsync(
               url,
              "api",
              "/AnularDocKim/"+serie+"/"+ nume + "/" + codtipodoc,
              ""
              );
        }


    }
}
