using Microsoft.Extensions.Options;
using PokeDataSource.Component.Pokemon.DataSourceImplement;
using PokeDataSource.Component.Pokemon.DataTransferObject;
using PokeDataSource.Configuration;
using PokeSERVICE.API_Integration;
using System.Threading.Tasks;
using NUnit.Framework;
using PokeDataSource.Component.Pokemon.DataSourceInterfaces;
using PokeBLL.Component.Pokemon.PokemonInterfaces;
using PokeBLL.Component.Pokemon.PokemonImplement;

namespace PokeTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task GetPokemon()
        {
            var config = Options.Create(new PokeConfiguration
            {
                PokeHost = "https://localhost:44306/"
            });
            
            var apiConnection = new ApiConnection(config);
            var pokemon = await apiConnection.GetPokeDataAsync<PokemonApiResultDto>("Pokemon/Pokemon/?pokeId=1");

            int pause = 0;

        }

        [Test]
        public async Task GetPokemonList()
        {
            var config = Options.Create(new PokeConfiguration
            {
                PokeHost = "https://localhost:44306/"
            });

            IApiConnection apiConnection = new ApiConnection(config);
            IPokemonListApiConnectionImp pokemonList = new PokemonListApiConnectionImp(apiConnection);
            IPokemonListImpl pokemonListImpl = new PokemonListImpl(pokemonList);

            var result = await pokemonListImpl.GetPokemonListAsync(20);

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);

        }
    }
}