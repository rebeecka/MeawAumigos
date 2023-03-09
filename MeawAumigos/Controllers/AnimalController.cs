using MeawAumigos.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MeawAumigos.Controllers
{
    public class AnimalController : Controller
    {
        private readonly IAnimalRepository _animalRepository;

        public AnimalController(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }

        public IActionResult List()
        {
            var animais = _animalRepository.Animais;
            return View(animais);
        }
    }
}
