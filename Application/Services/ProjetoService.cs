using Domain.Models;
using Sisongs.Data.Repositories;

namespace Sisongs.Application.Services
{
    public class ProjetoService : IProjetoService
    {
        private readonly IProjetoRepository _projetoRepository;

        public ProjetoService(IProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }

        public async Task<List<Projeto>> GetAllProjetosAsync()
        {
            return await _projetoRepository.GetAllProjetosAsync();
        }
    }
}