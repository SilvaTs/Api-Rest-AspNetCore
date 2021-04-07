using Aula2.Entities;
using System.Collections.Generic;


namespace Aula2.Services
{
    public interface ICarroService
    {
        bool AdicionarCarro(Carro carro);
        List<Carro> RetonarListaCarro();
        Carro RetornarCarroPorId(int id);
        bool AtualizarCarro(Carro novoProduto);
        bool DeletarCarro(int id);
    }
}
