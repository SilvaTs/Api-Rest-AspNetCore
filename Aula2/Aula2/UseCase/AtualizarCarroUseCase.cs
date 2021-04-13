
using Aula2.Bordas.Adapter;
using Aula2.Bordas.Repositorios;
using Aula2.Bordas.UseCase;
using Aula2.DTO.Carro.AtualizarCarro;

namespace Aula2.UseCase
{
    public class AtualizarCarroUseCase : IAtualizarCarroUseCase
    {
        private readonly IRepositorioCarros _repositorioCarros;
        private readonly IAtualizarCarroAdapter _adapter;

        public AtualizarCarroUseCase(IRepositorioCarros repositorioCarros, IAtualizarCarroAdapter adapter)
        {
            _repositorioCarros = repositorioCarros;
            _adapter = adapter;
        }
        public AtualizarCarroResponse Executar(AtualizarCarroRequest request)
        {
            var response = new AtualizarCarroResponse();
            try
            {

                var carroAdicionar = _adapter.ConverterRequestParaCarro(request);
                _repositorioCarros.Update(carroAdicionar);


                response.msg = "Atualizado com sucesso";
                return response;
            }
            catch
            {
                response.msg = "Erro ao Atualizar";
                return response;
            }
        }
    }

}
