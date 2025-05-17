using PokeDataSource.Component.Pokemon.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDataSource.Component.Pokemon.DataSourceInterfaces
{
    public interface IPokemonListApiConnectionImp
    {
        public Task<List<PokemonApiResultDto>> GetPokemonListAsync(int offSet);
    }
}
