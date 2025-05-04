using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeSERVICE.API_Integration
{
    public class ApiIntregration
    {
        public async Task<T> GetPokeDataAsync<T>(string endPoint)
        {
            using (HttpClient pokeClient = new HttpClient())
            {
                Uri baseAddress = new Uri(_pokeHost);
                pokeClient.BaseAddress = baseAddress;

                HttpResponseMessage httpResponseMessage = await pokeClient.GetAsync(endPoint);

                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    string pokeJson = await httpResponseMessage.Content.ReadAsStringAsync();
                    var pokeData = JsonConvert.DeserializeObject<T>(pokeJson);

                    return pokeData;
                }

                throw new Exception("Error in request");
            }

        }
    }
}
