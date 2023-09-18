using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.IBLs;
using Shared;
using DataAccessLayer.EFModels;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase{

        private readonly IBL_Personas _bl;

        public PersonaController(IBL_Personas bl){
            _bl = bl; 
        }

        // GET: api/<PersonaController>
        [ProducesResponseType(typeof(List<Persona>), 200)]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_bl.Get());
        }

        // GET api/<PersonaController>/12345678
        [ProducesResponseType(typeof(Persona), 200)]
        [HttpGet("{documento}")]
        public IActionResult Get(string documento)
        {
            return Ok(_bl.Get(documento));
        }

        // POST api/<PersonaController>
        [ProducesResponseType(typeof(Persona), 200)]
        [HttpPost]
        public IActionResult Post([FromBody] Persona x)
        {
            _bl.Insert(x);
            return Ok();
        }

        // PUT api/<PersonaController>/12345678
        [HttpPut("{documento}")]
        public IActionResult Put(string documento , [FromBody] Persona persona){

            persona.Documento = documento;
            _bl.Update(persona);
            return Ok(persona);

        }

        // DELETE api/<ValuesController>/12345678
        [HttpDelete("{documento}")]
        public IActionResult Delete(string documento)
        {
            Persona p = _bl.Get(documento);
            if (p == null)
            {
                return NotFound();
            }

            _bl.Delete(p.Documento);
            return Ok();
        }


    }
}
