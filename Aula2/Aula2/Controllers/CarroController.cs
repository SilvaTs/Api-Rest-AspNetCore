using Aula2.Bordas.UseCase;
using Aula2.DTO.Carro.AdicionarCarro;
using Aula2.DTO.Carro.AtualizarCarro;
using Aula2.DTO.Carro.RemoverCarro;
using Aula2.DTO.Carro.RetornarCarroPorId;
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
        private readonly IAtualizarCarroUseCase _atualizarCarroUseCase;
        private readonly IRetornarListadeCarrosUseCase _retornarListadeCarrosUseCase;
        private readonly IRetornarCarrosPorIdUseCase _retornarCarrosUseCase;
        public CarroController(ILogger<CarroController> logger, ICarroService carro,
             IAdicionarCarroUseCase adicionarCarroUseCase,
             IRemoverCarroUseCase removerCarroUseCase,
             IAtualizarCarroUseCase atualizarCarroUseCase,
             IRetornarListadeCarrosUseCase retornarListadeCarrosUseCase,
             IRetornarCarrosPorIdUseCase retornarCarrosUseCase

            )
        {
            _logger = logger;
            _carro = carro;
            _adicionarCarroUseCase = adicionarCarroUseCase;
            _removerCarroUseCase = removerCarroUseCase;
            _atualizarCarroUseCase = atualizarCarroUseCase;
            _retornarListadeCarrosUseCase = retornarListadeCarrosUseCase;
            _retornarCarrosUseCase = retornarCarrosUseCase;

        }

        [HttpGet]
        public IActionResult TodosCarros()
        {
            return Ok(_carro.RetonarListaCarro());
        }

        [HttpGet("{id}")]
        public IActionResult carro(int id)
        {
            var request = new RetornarCarroPorIdRequest();
            request.id = id;
            return Ok(_carro.RetornarCarroPorId(id));
        }

        [HttpPost]
        public IActionResult carroAdd([FromBody] AdicionarCarroRequest novoCarro)
        {
            return Ok(_adicionarCarroUseCase.Executar(novoCarro));
        }

        
        [HttpDelete("{id}")]
        public IActionResult carroDelete(int id)
        {
            var request = new RemoverCarroRequest();
            request.id = id;
            return Ok(_removerCarroUseCase.Executar(request));
        }

        [HttpPut]
        public IActionResult carroUpdate([FromBody] AtualizarCarroRequest novoCarro)
        {
            return Ok(_atualizarCarroUseCase.Executar(novoCarro));
        }

    }
}
