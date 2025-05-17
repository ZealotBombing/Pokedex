using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDataSource.Component.Pokemon.DataSourceInterfaces
{
    public interface IApiConnection
    {
        public Task<T> GetPokeDataAsync<T>(string endPoint);
    }
}
