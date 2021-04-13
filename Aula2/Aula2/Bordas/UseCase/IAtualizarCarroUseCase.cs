using Aula2.DTO.Carro.AtualizarCarro;


namespace Aula2.Bordas.UseCase
{
    public interface IAtualizarCarroUseCase
    {
        AtualizarCarroResponse Executar(AtualizarCarroRequest request);
    }
}
