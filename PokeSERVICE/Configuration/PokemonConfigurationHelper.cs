using Microsoft.Extensions.Options;
using PokeDataSource.Configuration;

public class ConfigurationHelper
{
    public static IOptions<PokeConfiguration> GetPokemonConfiguration()
    {
        var config = Options.Create(new PokeConfiguration
        {
            PokeHost = "https://localhost:44306/"
        });

        return config;
    }
}
