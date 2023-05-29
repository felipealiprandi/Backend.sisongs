using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sisongs.Data.Repositories;

namespace Sisongs.Application.Services
{
    public class OngService : IOngService
    {
        private readonly IOngRepository _ongRepository;

        public OngService(IOngRepository ongRepository)
        {
            _ongRepository = ongRepository;
        }

        public async Task<List<Ong>> GetAllOngsAsync()
        {
            return await _ongRepository.GetAllOngsAsync();
        }

        public async Task CreateOngAsync(Ong ong)
        {
            await _ongRepository.CreateOngAsync(ong);
        }
    }
}