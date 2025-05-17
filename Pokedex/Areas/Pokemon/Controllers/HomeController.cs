using Microsoft.AspNetCore.Mvc;
using PokeBLL.Component.Pokemon.PokemonImplement;
using PokeBLL.Component.Pokemon.PokemonInterfaces;
using System.Threading.Tasks;

namespace Pokedex.Areas.Pokemon.Controllers
{
    [Area("Pokemon")]
    public class HomeController : Controller
    {
        private readonly IPokemonListImpl _pokemonListImpl;
        public HomeController(PokemonListImpl pokemonListImpl) { 
        
            this._pokemonListImpl = pokemonListImpl;
        }

        public async Task<IActionResult> PokemonList()
        {
            try
            {
                var pokemonList = await _pokemonListImpl.GetPokemonListAsync(20);
                return View(pokemonList);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
