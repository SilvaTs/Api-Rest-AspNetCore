using Aula2.Bordas.Adapter;
using Aula2.DTO.Carro.AdicionarCarro;
using Aula2.Entities;


namespace Aula2.Adapter
{
    public class AdicionarCarroAdapter : IAdicionarCarroAdapter
    {
      

        public Carro converterRequestParaCarro(AdicionarCarroRequest request)
        {
            var novoCarro = new Carro();
            novoCarro.Marca = request.marca;
            novoCarro.Modelo = request.modelo;
            novoCarro.combustivel = request.combustivel;
            return novoCarro;
        }
    }
}
