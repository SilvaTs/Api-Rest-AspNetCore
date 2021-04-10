using Aula2.DTO.Carro.AdicionarCarro;
using Aula2.DTO.Carro.RemoverCarro;
using Aula2.Entities;
using Aula2.Services;
using Aula2.UseCase;
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

        private readonly IAdicionarCarroUseCase _adicionarCarroUseCase;
        private readonly IRemoverCarroUseCase _removerCarroUseCase;

        public CarroController(ILogger<CarroController> logger, ICarroService carro,
             IAdicionarCarroUseCase adicionarCarroUseCase,
            IRemoverCarroUseCase removerCarroUseCase
            )
        {
            _logger = logger;
            _carro = carro;
            _adicionarCarroUseCase = adicionarCarroUseCase;
            _removerCarroUseCase = removerCarroUseCase;
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
        public IActionResult carroAdd([FromBody] AdicionarCarroRequest novoCarro)
        {
            return Ok(_adicionarCarroUseCase.Executar(novoCarro));
        }

        [HttpPut]
        public IActionResult carroUpdate([FromBody] Carro novoCarro)
        {
            return Ok(_carro.AtualizarCarro(novoCarro));
        }


        [HttpDelete("{id}")]
        public IActionResult carroDelete(int id)
        {
            var request = new RemoverCarroRequest();
            request.id = id;
            return Ok(_removerCarroUseCase.Executar(request));
        }

    }
}
