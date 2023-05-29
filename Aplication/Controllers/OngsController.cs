using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Sisongs.Application.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MeuProjeto.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OngsController : ControllerBase
    {
        private readonly IOngService _ongService;

        public OngsController(IOngService ongService)
        {
            _ongService = ongService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Ong>>> Get()
        {
            var ongs = await _ongService.GetAllOngsAsync();
            return Ok(ongs);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Ong ong)
        {
            await _ongService.CreateOngAsync(ong);
            return Ok(ong);
        }
    }
}