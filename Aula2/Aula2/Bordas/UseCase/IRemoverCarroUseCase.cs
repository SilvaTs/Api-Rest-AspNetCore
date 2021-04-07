using Aula2.DTO.Carro.RemoverCarro;


namespace Aula2.UseCase
{
    public interface IRemoverCarroUseCase
    {
        RemoverCarroResponse Executar(RemoverCarroRequest request);
    }
}
