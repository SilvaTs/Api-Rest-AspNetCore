using Aula2.DTO.Carro.AdicionarCarro;


namespace Aula2.Bordas.UseCase
{
    public interface IAdicionarCarroUseCase
    {
        AdicionarCarroResponse Executar(AdicionarCarroRequest request);
    }
}
