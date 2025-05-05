using Microsoft.Extensions.Options;
using PokeDataSource.Component.Pokemon.DataSourceImplement;
using PokeDataSource.Component.Pokemon.DataTransferObject;
using PokeDataSource.Configuration;
using PokeSERVICE.API_Integration;
using System.Threading.Tasks;

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

            var apiConnection = new ApiConnection(config);
            var apiConnectionImplementation = new PokemonListApiConnectionImp(apiConnection);
            var pokemonList = await apiConnectionImplementation.GetPokemonListAsync(20);

            int pause = 0;

        }
    }
}