using Microsoft.AspNetCore.Mvc;

namespace Pokedex.Areas.Pokemon.Controllers
{
    public class PokemonController : Controller
    {
        public IActionResult PokemonDetails(int pokemonId)
        {
            return View();
        }
    }
}
