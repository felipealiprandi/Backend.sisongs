using Domain.Models;
using Sisongs.Infrastructure.Data;
using Sisongs.Data.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sisongs.Data.Repositories
{
    public class ProjetoRepository : IProjetoRepository
    {
        private readonly SisongsDbContext _dbContext;

        public ProjetoRepository(SisongsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Projeto>> GetAllProjetosAsync()
        {
            return await _dbContext.Projetos.ToListAsync();
        }
    }
}