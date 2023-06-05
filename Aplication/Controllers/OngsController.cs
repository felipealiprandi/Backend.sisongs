using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Sisongs.Application.Services;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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