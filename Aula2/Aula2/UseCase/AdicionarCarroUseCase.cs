using Aula2.Bordas.Adapter;
using Aula2.Bordas.Repositorios;
using Aula2.DTO.Carro.AdicionarCarro;
using System;


namespace Aula2.UseCase
{
    public class AdicionarCarroUseCase : IAdicionarCarroUseCase
    {
        private readonly IRepositorioCarros _repositorioProdutos;
        private readonly IAdicionarCarroAdapter _adapter;

        public AdicionarCarroUseCase(IRepositorioCarros repositorioProdutos, 
                                        IAdicionarCarroAdapter adapter)
        {
            _repositorioProdutos = repositorioProdutos;
            _adapter = adapter;
        }

        public AdicionarCarroResponse Executar(AdicionarCarroRequest request)
        {
            var response = new AdicionarCarroResponse();

            try
            {
                if (request.marca.Length < 5)
                {
                    response.msg = "Erro ao adicionar o produto";
                    return response;
                }

                var produtoAdicionar = _adapter.converterRequestParaCarro(request);
                _repositorioProdutos.Add(produtoAdicionar);
                response.msg = "Adicionado com sucesso";
                response.id = produtoAdicionar.id;
                return response;
            }
            catch
            {
                response.msg = "Erro ao adicionar o carro";
                return response;
            }
            
        }
    }
}
