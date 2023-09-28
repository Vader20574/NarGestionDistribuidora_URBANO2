using Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Common.Services
{
    public interface IApiService
    {
        Task<Response> GetListAsync<T>(string urlBase, string servicePrefix, string controller);

        Task<Response> GetListAsync<T>(string urlBase, string servicePrefix, string controller, string tokenType, string accessToken);
        Task<Response> PostAsync<T>(string urlBase, string servicePrefix, string controller, T model);
        Task<Response> PutAsync<T>(string urlBase, string servicePrefix, string controller, int id, T model);
        Task<Response> DeleteAsync(string urlBase, string servicePrefix, string controller, int id);

       
    }
}
