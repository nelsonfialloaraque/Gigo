

namespace Gigo.Services
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Common.Models;
    using Newtonsoft.Json;
    
 


    public class ApiService
    {
       
        public async Task<Response> GetList<T>(string urlBase, string prefix, string controller)
         {
            // this method works to consomption any api service, any list
            try
            {
                // object client works to make communication
                var client = new HttpClient();

                // then we have object client we are going to charge his address urlBase
                client.BaseAddress = new Uri(urlBase);
                // we are going to link prefix and controller
                var url = $"{prefix}{controller}";
                //var urlTest = string.Format("{0}{1}", prefix, controlador);
                // now we are going to request(send)
                var response = await client.GetAsync(url); // in this point he starting to doing communications and he come back we get one response
                // this response we have read because we will have objet in memory
                // we are comsumption a service it return like restFull and we are going to read like string, so its an string because its a Json object

                var answer = await response.Content.ReadAsStringAsync(); // answer is a Json like string

                // si fallo hay que devolver el status que no pudo
                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = answer
                    };

                }

                // if we arrive here, we have success but we dont have our objet yet
                // so there are two operations we are going to do all session
                // when I have a string Json and I wanna to convert in Objects is called deserialize operation
                // and the other operation is take a objet and to converting to string and is called serialize
                //so for serialize and deserialize we use NewtonSoft library
                var list = JsonConvert.DeserializeObject < List<T>>(answer);
                return new Response
                {
                    IsSuccess = true,
                    Result = list
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
        
        
    }

   
}
