using Domain.Models;

namespace Sisongs.Data.Repositories
{
    public interface IProjetoRepository
    {
        Task<List<Projeto>> GetAllProjetosAsync();
    }
}
