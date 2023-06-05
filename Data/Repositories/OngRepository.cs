using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Sisongs.Infrastructure.Data;
using Sisongs.Data.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sisongs.Data.Repositories
{
    public class OngRepository : IOngRepository
    {
        private readonly SisongsDbContext _dbContext;

        public OngRepository(SisongsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Ong>> GetAllOngsAsync()
        {
            try
            {
                return await _dbContext.Ongs.ToListAsync();
            }
            catch (Exception ex)
            {
                return new List<Ong>();
            }


        }

        public async Task CreateOngAsync(Ong ong)
        {
            try
            {
                _dbContext.Ongs.Add(ong);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var erro = ex.ToString();
            }

        }
    }
}