using Aula2.Entities;
using Aula2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Aula2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarroController : ControllerBase
    {

        private readonly ILogger<CarroController> _logger;
        private readonly ICarroService _carro;

        public CarroController(ILogger<CarroController> logger, ICarroService carro)
        {
            _logger = logger;
            _carro = carro;
        }

        [HttpGet]
        public IActionResult TodosCarros()
        {
            return Ok(_carro.RetonarListaCarro());
        }

        [HttpGet("{id}")]
        public IActionResult carro(int id)
        {
            return Ok(_carro.RetornarCarroPorId(id));
        }

        [HttpPost]
        public IActionResult produtoAdd([FromBody] Carro novoCarro)
        {
            return Ok(_carro.AdicionarCarro(novoCarro));
        }

        [HttpPut]
        public IActionResult carroUpdate([FromBody] Carro novoCarro)
        {
            return Ok(_carro.AtualizarCarro(novoCarro));
        }


        [HttpDelete("{id}")]
        public IActionResult carroDelete(int id)
        {
            return Ok(_carro.DeletarCarro(id));
        }

    }
}
