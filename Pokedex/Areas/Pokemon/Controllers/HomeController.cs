using Microsoft.AspNetCore.Mvc;

namespace Pokedex.Areas.Pokemon.Controllers
{
    [Area("Pokemon")]
    public class HomeController : Controller
    {
        public IActionResult PokemonList()
        {
            return View();
        }
    }
}
