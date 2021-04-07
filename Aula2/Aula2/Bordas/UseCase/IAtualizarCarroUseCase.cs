using Aula2.DTO.Carro.AtualizarCarro;


namespace Aula2.UseCase
{
    public interface IAtualizarCarroUseCase
    {
        AtualizarCarroResponse Executar(AtualizarCarroRequest request);
    }
}
