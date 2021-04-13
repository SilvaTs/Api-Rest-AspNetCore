using Aula2.Bordas.Adapter;
using Aula2.DTO.Carro.AtualizarCarro;
using Aula2.Entities;
using System;


namespace Aula2.Adapter
{
    public class AtualizarCarroAdapter : IAtualizarCarroAdapter
    {
       
        public Carro ConverterRequestParaCarro(AtualizarCarroRequest request)
        {
            var novoCarro = new Carro();
            novoCarro.id = request.id;
            novoCarro.Marca = request.marca;
            novoCarro.Modelo = request.modelo;
            novoCarro.combustivel = request.combustivel;
            return novoCarro;
        }
    }
}
