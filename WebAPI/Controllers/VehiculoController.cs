using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.IBLs;
using Shared;
using DataAccessLayer.EFModels;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculoController : ControllerBase
    {
        private readonly IBL_Vehiculos _bl;

        public VehiculoController(IBL_Vehiculos bl)
        {
            _bl = bl;
        }

        // GET: api/<VehiculoController>
        [ProducesResponseType(typeof(List<Vehiculo>), 200)]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_bl.Get());
        }

        // GET api/<VehiculoController>/12345678
        [ProducesResponseType(typeof(Vehiculo), 200)]
        [HttpGet("{matricula}")]
        public IActionResult Get(string matricula)
        {
            return Ok(_bl.Get(matricula));
        }

        // POST api/<VehiculoController>
        [ProducesResponseType(typeof(Vehiculo), 200)]
        [HttpPost]
        public IActionResult Post([FromBody] Vehiculo x)
        {
            _bl.Insert(x);
            return Ok();
        }

        // PUT api/<VehiculoController>/12345678
        [HttpPut("{matricula}")]
        public IActionResult Put(string matricula, [FromBody] Vehiculo vehiculo)
        {

            vehiculo.Matricula = matricula;
            _bl.Update(vehiculo);
            return Ok(vehiculo);

        }

        // DELETE api/<ValuesController>/12345678
        [HttpDelete("{matricula}")]
        public IActionResult Delete(string matricula)
        {
            Vehiculo v = _bl.Get(matricula);
            if (v == null)
            {
                return NotFound();
            }

            _bl.Delete(v.Matricula);
            return Ok();
        }
    }
}
