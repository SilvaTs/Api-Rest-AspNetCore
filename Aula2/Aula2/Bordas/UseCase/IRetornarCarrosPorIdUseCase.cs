


using Aula2.DTO.Carro.RetornarCarroPorId;

namespace Aula2.UseCase
{
    public interface IRetornarCarrosPorIdUseCase
    {
        RetornarCarroPorIdResponse Executar(RetornarCarroPorIdRequest request);
    }
}
