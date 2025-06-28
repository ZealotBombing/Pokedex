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
    public class PokemonDetailsApiConnectionImpl : IPokemonDetailsApiConnectionImpl
    {
        public readonly IApiConnection _apiConnection;

        public PokemonDetailsApiConnectionImpl(IApiConnection apiConnection)
        {
            _apiConnection = apiConnection;
        }

        public async Task<PokemonApiResultDto> GetPokemon(int pokemonId)
        {
            var pokemonData = await _apiConnection.GetPokeDataAsync<PokemonApiResultDto>($"{PokemonEndPointName.PokemonEndPoint}pokeId={pokemonId}");

            return pokemonData;
        }
    }
}
