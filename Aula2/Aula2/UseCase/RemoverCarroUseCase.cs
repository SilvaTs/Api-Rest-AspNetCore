using Aula2.Bordas.Repositorios;
using Aula2.DTO.Carro.RemoverCarro;
using System;


namespace Aula2.UseCase
{
    public class RemoverCarroUseCase : IRemoverCarroUseCase
    {

        private readonly IRepositorioCarros _repositorioCarros;

        public RemoverCarroUseCase(IRepositorioCarros repositorioCarros)
        {
            _repositorioCarros = repositorioCarros;
        }

        public RemoverCarroResponse Executar(RemoverCarroRequest request)
        {
            var response = new RemoverCarroResponse();
            try
            {
                _repositorioCarros.Remove(request.id);
                response.msg = "Removido com sucesso";
                return response;
            }
            catch (Exception e)
            {
                throw new System.Exception(e.Message);
            }
        }
    }
}
