using PokeDataSource.Component.Pokemon.DataSourceInterfaces;
using Pokemon.Component.BusinessMapper;
using Pokemon.Component.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeBLL.Component.Pokemon.PokemonImplement
{
    public class PokemonDetailsImpl
    {
        public readonly IPokemonDetailsApiConnectionImpl _pokemonDetailsApiConnectionImpl;
        public PokemonDetailsImpl(IPokemonDetailsApiConnectionImpl pokemonDetailsApiConnectionImpl)
        {
            _pokemonDetailsApiConnectionImpl = pokemonDetailsApiConnectionImpl;
        }

        public async Task<PokemonDto> GetPoKemonDetails(int pokeId) { 

            var pokemon = await _pokemonDetailsApiConnectionImpl.GetPokemon(pokeId);

            return PokemonMapper.ToDto(pokemon);
        }
    }
}
