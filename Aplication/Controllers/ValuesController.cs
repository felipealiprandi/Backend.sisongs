using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Sisongs.Application.Services;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IOngService _ongService;

        public ValuesController(IOngService ongService)
        {
            _ongService = ongService;
        }



        // GET: api/<ValuesController>
        [HttpGet]
        //[HttpGet]
        public string Get()
        {
            try
            {
                var ongs = _ongService.GetAllOngsAsync();
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

            return "deu certo";
        }


        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
