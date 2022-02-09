using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using UNOUI.Helpers.Interfaces;
using UNOUI.Models;

namespace UNOUI.Helpers
{
    public class ApiService : IApiService
    {
        static private HttpClient Client { get; set; }

        private void CreateClient()
        {
            HttpClientHandler handler = new HttpClientHandler()
            {
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };

            Client = new HttpClient(handler)
            {
                BaseAddress = new Uri("https://apipalabras.herokuapp.com/")
            };
        }

        public async Task<Response> RecuperarPalabraAsync()
        {
            try
            {
                if (Client == null)
                    CreateClient();
                HttpResponseMessage response = await Client.GetAsync("api/recuperar/palabra");
                string result = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = result,
                    };
                }
                var palabras = JsonConvert.DeserializeObject<Palabra[]>(result);
                return new Response
                {
                    IsSuccess = true,
                    Result = palabras,
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message,
                };
            }
        }

        public async Task<Response> RecuperarLetraAsync(char letra)
        {
            try
            {
                if (Client == null)
                    CreateClient();

                HttpResponseMessage response = await Client.GetAsync($"api/recuperar/letra?letra={letra}");
                string result = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = result,
                    };
                }
                var palabras = JsonConvert.DeserializeObject<Palabra[]>(result);
                return new Response
                {
                    IsSuccess = true,
                    Result = palabras,
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message,
                };
            }
        }

        public async Task<Response> PostAsync<T, O>(string controller, T model)
        {
            try
            {
                string request = JsonConvert.SerializeObject(model);
                var content = new StringContent(request, Encoding.UTF8, "application/json");

                if (Client == null)
                    CreateClient();

                HttpResponseMessage response = await Client.PostAsync($"api/{controller}", content);
                string result = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = result,
                    };
                }

                O item = JsonConvert.DeserializeObject<O>(result);
                return new Response
                {
                    IsSuccess = true,
                    Result = item,
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<Response> DeleteAsync()
        {
            try
            {
                if (Client == null)
                    CreateClient();

                HttpResponseMessage response = await Client.DeleteAsync("api/borrar/palabra");
                string result = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = result,
                    };
                }
                var palabras = JsonConvert.DeserializeObject<Palabra[]>(result);
                return new Response
                {
                    IsSuccess = true,
                    Result = palabras,
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message,
                };
            }

        }
    }
}
