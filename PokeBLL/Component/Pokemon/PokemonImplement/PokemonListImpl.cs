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
    public class PokemonListImpl
    {
        private readonly IPokemonListApiConnectionImp _pokemonListApiConnectionImp;
        public PokemonListImpl(IPokemonListApiConnectionImp pokemonListApiConnectionImp)
        {
            _pokemonListApiConnectionImp = pokemonListApiConnectionImp;
        }

        public async Task<List<PokemonDto>> GetPokemonList(int offSet) {

            var pokemonList = await _pokemonListApiConnectionImp.GetPokemonListAsync(offSet);

            return PokemonMapper.ToDto(pokemonList);
        }

    }
}
