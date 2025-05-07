using PokeDataSource.Component.Pokemon.DataSourceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeBLL.Component.Pokemon.PokemonImplement
{
    public class PokemonListImpl
    {
        private readonly IApiConnection _apiConnection;

        public PokemonListImpl(IApiConnection apiConnection)
        {
            _apiConnection = apiConnection;
        }



    }
}
