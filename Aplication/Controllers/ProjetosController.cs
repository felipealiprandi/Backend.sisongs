using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Sisongs.Application.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjetosController : ControllerBase
    {
        private readonly IProjetoService _projetoService;

        public ProjetosController(IProjetoService projetoService)
        {
            _projetoService = projetoService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Projeto>>> Get()
        {
            var projetos = await _projetoService.GetAllProjetosAsync();
            return Ok(projetos);
        }
    }
}