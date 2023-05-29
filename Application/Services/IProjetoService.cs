using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisongs.Application.Services
{
    public interface IProjetoService
    {
        Task<List<Projeto>> GetAllProjetosAsync();
    }
}
