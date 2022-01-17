using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using UNOUI.Models;

namespace UNOUI.Helpers
{
    public class ApiService
    {
        static private HttpClient Client { get; set; }

        private static void CreateClient()
        {
            HttpClientHandler handler = new HttpClientHandler()
            {
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };

            Client = new HttpClient(handler)
            {
                BaseAddress = new Uri("https://localhost:7094/")
            };
        }

        public static async Task<Response> RecuperarPalabraAsync()
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

        public static async Task<Response> RecuperarLetraAsync(char letra)
        {
            try
            {
                string request = JsonConvert.SerializeObject(letra);
                StringContent content = new StringContent(request, Encoding.UTF8, "application/json");
                if (Client == null)
                    CreateClient();

                HttpResponseMessage response = await Client.PostAsync("api/recuperar/letra", content);
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

        public static async Task<Response> PostAsync<T>(string controller, T model)
        {
            try
            {
                string request = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(request, Encoding.UTF8, "application/json");

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

                T item = JsonConvert.DeserializeObject<T>(result);
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

        public static async Task<Response> DeleteAsync()
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
