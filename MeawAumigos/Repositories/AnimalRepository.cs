using MeawAumigos.Context;
using MeawAumigos.Models;
using MeawAumigos.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace MeawAumigos.Repositories
{
    public class AnimalRepository: IAnimalRepository
    {
        private readonly AppDbContext _context;
        public AnimalRepository(AppDbContext contexto)
        {
            _context = contexto;
        }
        public IEnumerable<Animal> Animais => _context.Animais.Include(c=>c.Categoria);

        public IEnumerable<Animal> AnimaisFavoritos => _context.Animais.Where(l=>l.AnimalFavorito).Include(c=>c.Categoria);


        public Animal GetAnimalById(int animalId)
        {
            return _context.Animais.FirstOrDefault(l=>l.AnimalId == animalId);
        }
    }
}
