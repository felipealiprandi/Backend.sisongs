﻿using Domain.Models;
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

        //[HttpGet]
        //public async Task<ActionResult<List<Ong>>> Get()
        //{
        //    var ongs = await _ongService.GetAllOngsAsync();
        //    return Ok(ongs);
        //}

        [HttpGet]
        public async Task<string> Get()
        {
            try
            {
                var ongs = await _ongService.GetAllOngsAsync();
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

            return "deu certo";
        }

        [HttpGet("novo")]
        public async Task<string> Get2()
        {
            try
            {
                return "deu certo";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

            return "deu errado";
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Ong ong)
        {
            await _ongService.CreateOngAsync(ong);
            return Ok(ong);
        }
    }
}