using Aula2.DTO.Carro.AdicionarCarro;


namespace Aula2.UseCase
{
    public interface IAdicionarCarroUseCase
    {
        AdicionarCarroResponse Executar(AdicionarCarroRequest request);
    }
}
