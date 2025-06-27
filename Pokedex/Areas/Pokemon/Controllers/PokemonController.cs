using Microsoft.AspNetCore.Mvc;
using PokeBLL.Component.Pokemon.PokemonImplement;

namespace Pokedex.Areas.Pokemon.Controllers
{
    public class PokemonController : Controller
    {
        public readonly PokemonDetailsImpl pokemonDetailsImpl;

        public PokemonController(PokemonDetailsImpl pokemonDetails)
        {
            this.pokemonDetailsImpl = pokemonDetails;
        }
        public IActionResult PokemonDetails(int pokemonId)
        {
            var pokemonDetails = this.pokemonDetailsImpl.GetPoKemonDetails(pokemonId);

            return View(pokemonDetails);
        }
    }
}
