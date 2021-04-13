using Aula2.DTO.Carro.AtualizarCarro;
using Aula2.Entities;


namespace Aula2.Bordas.Adapter
{
    public interface IAtualizarCarroAdapter
    {
        public Carro ConverterRequestParaCarro(AtualizarCarroRequest request);
    }
}
