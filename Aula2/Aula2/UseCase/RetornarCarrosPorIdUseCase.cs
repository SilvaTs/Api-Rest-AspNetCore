using Aula2.Bordas.Repositorios;
using Aula2.DTO.Carro.RetornarCarroPorId;
using System;


namespace Aula2.UseCase
{
    public class RetornarCarrosPorIdUseCase : IRetornarCarrosPorIdUseCase
    {
        private readonly IRepositorioCarros _repositorioCarros;

        public RetornarCarrosPorIdUseCase(IRepositorioCarros repositorioCarros)
        {
            _repositorioCarros = repositorioCarros;
        }

        public RetornarCarroPorIdResponse Executar(RetornarCarroPorIdRequest request)
        {
            var response = new RetornarCarroPorIdResponse();
            try
            {
                response.carro = _repositorioCarros.RetornaPorId(request.id);
                response.msg = "Retornado com sucesso";
                return response;
            }
            catch
            {
                response.msg = "Erro ao Retornar";
                return response;
            }
        }
    }
}
