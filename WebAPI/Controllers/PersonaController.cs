using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.IBLs;
using Shared;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase{

        private readonly IBL_Personas _bl;

        public PersonaController(IBL_Personas bl){
            _bl = bl; 
        }

        // GET: api/<PersonasController>
        [ProducesResponseType(typeof(List<Persona>), 200)]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_bl.Get());
        }

        // GET api/<PersonasController>/12345678
        [ProducesResponseType(typeof(Persona), 200)]
        [HttpGet("{id}")]
        public IActionResult Get(string documento)
        {
            return Ok(_bl.Get(documento));
        }

        // POST api/<PersonasController>
        [ProducesResponseType(typeof(Persona), 200)]
        [HttpPost]
        public IActionResult Post([FromBody] Persona x)
        {
            _bl.Insert(x);
            return Ok();
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
