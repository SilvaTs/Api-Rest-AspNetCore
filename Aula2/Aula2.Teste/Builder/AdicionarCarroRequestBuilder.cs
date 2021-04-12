using Aula2.DTO.Carro.AdicionarCarro;
using Bogus;


namespace Aula2.Teste.Builder
{
    public class AdicionarCarroRequestBuilder
    {

        private readonly Faker _faker = new Faker("pt_BR");
        private readonly AdicionarCarroRequest _adicionarCarro;

        public AdicionarCarroRequestBuilder()
        {
            _adicionarCarro = new AdicionarCarroRequest();
            _adicionarCarro.marca = _faker.Random.String(40);
            _adicionarCarro.modelo = _faker.Random.String(40);
            _adicionarCarro.combustivel = _faker.Random.String(40);
        }

        public AdicionarCarroRequestBuilder withNameLength(int tamanho)
        {
            _adicionarCarro.marca = _faker.Random.String(tamanho);
            return this;
        }


        public AdicionarCarroRequest Build()
        {
            return _adicionarCarro;
        }

    }
}
