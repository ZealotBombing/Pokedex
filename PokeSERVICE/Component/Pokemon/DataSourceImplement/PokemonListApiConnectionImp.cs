using PokeDataSource.Component.Pokemon.DataSourceEndPointName;
using PokeDataSource.Component.Pokemon.DataSourceInterfaces;
using PokeDataSource.Component.Pokemon.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDataSource.Component.Pokemon.DataSourceImplement
{
    public class PokemonListApiConnectionImp
    {
        private readonly IApiConnection _apiConnection;

        public PokemonListApiConnectionImp(IApiConnection apiConnection)
        {
            this._apiConnection = apiConnection;
        }
        public async Task<List<PokemonApiResultDto>> GetPokemonListAsync(int offSet) {

            var taskList = new List<Task<PokemonApiResultDto>>();

            for (int i = 1; i <= offSet; i++)
            {
                var pokemon = _apiConnection.GetPokeDataAsync<PokemonApiResultDto>($"{PokemonEndPointName.PokemonEndPoint}pokeId={i}");
                taskList.Add(pokemon);
            }

            var pokemonList = await Task.WhenAll(taskList);

            return pokemonList.ToList();
        }
    }
}
