using Microsoft.AspNetCore.Mvc;

namespace Pokedex.Areas.Pokemon.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult PokemonList()
        {
            return View();
        }
    }
}
