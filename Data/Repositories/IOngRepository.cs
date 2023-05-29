using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Sisongs.Data.Repositories
{
    public interface IOngRepository
    {
        Task<List<Ong>> GetAllOngsAsync();
        Task CreateOngAsync(Ong ong);
    }
}
