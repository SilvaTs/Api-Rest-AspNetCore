
using Aula2.Bordas.Repositorios;
using Aula2.DTO.Carro.RetornarListadeCarros;
using System;


namespace Aula2.UseCase
{
    public class RetornarListadeCarrosUseCase : IRetornarListadeCarrosUseCase
    {
        private readonly IRepositorioCarros _repositorioCarros;

        public RetornarListadeCarrosUseCase(IRepositorioCarros repositorioCarros)
        {
            _repositorioCarros = repositorioCarros;
        }
        public RetornarListadeCarrosResponse Executar()
        {
            var response = new RetornarListadeCarrosResponse();
            try
            {
                response.carros = _repositorioCarros.RetornarListaCarros();
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
