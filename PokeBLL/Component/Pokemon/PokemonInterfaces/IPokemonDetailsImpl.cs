using Pokemon.Component.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeBLL.Component.Pokemon.PokemonInterfaces
{
    internal interface IPokemonDetailsImpl
    {
        public Task<PokemonDto> GetPoKemonDetails(int pokeId);
    }
}
