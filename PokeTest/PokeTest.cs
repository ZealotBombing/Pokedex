using PokeDataSource.Pokemon.DataTransferObject;
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
            var apiConnection = new ApiConnection();
            var pokemon = await apiConnection.GetPokeDataAsync<PokemonAp�ResultDto>("Pokemon/Pokemon/1");


        }
    }
}