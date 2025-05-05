using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using OpenQA.Selenium;
using PokeDataSource.Component.Pokemon.DataSourceInterfaces;
using PokeDataSource.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeSERVICE.API_Integration
{
    public class ApiConnection : IApiConnection
    {
        private readonly string _pokeHost;

        public ApiConnection(IOptions<PokeConfiguration> config)
        {
            _pokeHost = config.Value.PokeHost;
        }

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
