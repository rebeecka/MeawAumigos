using MeawAumigos.Models;
using System.Collections.Generic;

namespace MeawAumigos.Repositories.Interfaces
{
    public interface IAnimalRepository
    {
        IEnumerable<Animal> Animais { get; }
        IEnumerable<Animal> AnimaisFavoritos { get; }
        Animal GetAnimalById(int animalId);
    }
}
