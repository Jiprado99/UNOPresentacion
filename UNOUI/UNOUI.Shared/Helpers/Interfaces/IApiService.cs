using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UNOUI.Models;

namespace UNOUI.Helpers.Interfaces
{
    public interface IApiService
    {
        Task<Response> RecuperarPalabraAsync();
        Task<Response> RecuperarLetraAsync(char letra);
        Task<Response> PostAsync<T, O>(string controller, T model);
        Task<Response> DeleteAsync();

    }
}
