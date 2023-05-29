using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sisongs.Application.Services
{
    public interface IOngService
    {
        Task<List<Ong>> GetAllOngsAsync();
        Task CreateOngAsync(Ong ong);
    }


}