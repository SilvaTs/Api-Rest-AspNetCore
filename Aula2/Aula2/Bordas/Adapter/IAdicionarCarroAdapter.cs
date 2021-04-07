using Aula2.DTO.Carro.AdicionarCarro;
using Aula2.Entities;


namespace Aula2.Bordas.Adapter
{
    public interface IAdicionarCarroAdapter
    {
        public Carro converterRequestParaCarro(AdicionarCarroRequest request);
    }
}
