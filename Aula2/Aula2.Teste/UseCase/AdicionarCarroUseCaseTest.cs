using Aula2.Bordas.Adapter;
using Aula2.Bordas.Repositorios;
using Aula2.DTO.Carro.AdicionarCarro;
using Aula2.Entities;
using Aula2.Teste.Builder;
using Aula2.UseCase;
using FluentAssertions;
using Moq;
using System;
using Xunit;

namespace Aula2.Teste.UseCase
{
    public class AdicionarCarroUseCaseTest
    {

        private readonly Mock<IRepositorioCarros> _repositorioCarros;
        private readonly Mock<IAdicionarCarroAdapter> _adicionarCarrosAdapter;
        private readonly AdicionarCarroUseCase _usecase;

        public AdicionarCarroUseCaseTest()
        {
            _repositorioCarros = new Mock<IRepositorioCarros>();
            _adicionarCarrosAdapter = new Mock<IAdicionarCarroAdapter>();
            _usecase = new AdicionarCarroUseCase(
                _repositorioCarros.Object,
                _adicionarCarrosAdapter.Object
            );
        }

        [Fact]
        public void Carro_AdicionarCarro_QuandoRetonarSucesso()
        {

            var request = new AdicionarCarroRequestBuilder().Build();
            var response = new AdicionarCarroResponse();
            var carro = new Carro();
            carro.id = 1;

            response.msg = "Carro adicionado com sucesso";
            response.id = carro.id;

            _repositorioCarros.Setup(repositorio => repositorio.Add(carro)).Returns(carro.id);
            _adicionarCarrosAdapter.Setup(adapter => adapter.converterRequestParaCarro(request)).Returns(carro);


            var result = _usecase.Executar(request);


            response.Should().BeEquivalentTo(result);

        }

        [Fact]
        public void Carro_AdicionarCarro_QuandoMarcaMenorCinco()
        {
           
            var request = new AdicionarCarroRequestBuilder().withNameLength(10).Build();
            var response = new AdicionarCarroResponse();
           
            response.msg = "Erro ao adicionar o carro";

           
            var result = _usecase.Executar(request);

          
            response.Should().BeEquivalentTo(result);
        }

        [Fact]
        public void Carro_AdicionarCarro_QuandoRepositorioExcecao()
        {
          
            var request = new AdicionarCarroRequestBuilder().Build();
            var response = new AdicionarCarroResponse();
            var carro = new Carro();
            carro.id = 1;
            response.msg = "Erro ao adicionar o carro";
            _adicionarCarrosAdapter.Setup(adapter => adapter.converterRequestParaCarro(request)).Returns(carro);
            _repositorioCarros.Setup(repositorio => repositorio.Add(carro)).Throws(new Exception());

          
            var result = _usecase.Executar(request);

            response.Should().BeEquivalentTo(result);
        }


    }
}
