using Aula2.Entities;
using System.Collections.Generic;


namespace Aula2.Services
{
    public interface ICarroService
    {
        bool AdicionarCarro(Carro carro);
        public List<Carro> RetonarListaCarro();
        public Carro RetornarCarroPorId(int id);
        bool AtualizarCarro(Carro novoProduto);
        bool DeletarCarro(int id);
    }
}
