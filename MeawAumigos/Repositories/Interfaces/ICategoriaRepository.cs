using MeawAumigos.Models;

namespace MeawAumigos.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
