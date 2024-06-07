using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using restApi.Model;
using restApi.Services;

namespace restApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PessoaController : ControllerBase
    {

        private readonly ILogger<PessoaController> _logger;
        private readonly IPessoaService _pessoaService;
        public PessoaController(ILogger<PessoaController> logger, IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_pessoaService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _pessoaService.FindById(id);
            if (person == null) return NotFound();
            return Ok(person);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Pessoa pessoa)
        {
            if (pessoa == null) return BadRequest();
            return Ok(_pessoaService.Create(pessoa));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Pessoa pessoa)
        {
            if (pessoa == null) return BadRequest();
            return Ok(_pessoaService.Update(pessoa));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _pessoaService.Delete(id);
            return NoContent();
        }
    }
}
