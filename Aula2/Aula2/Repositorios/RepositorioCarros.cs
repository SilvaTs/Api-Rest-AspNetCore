using Aula2.Bordas.Repositorios;
using Aula2.Context;
using Aula2.Entities;


namespace Aula2.Repositorios
{
    public class RepositorioCarros : IRepositorioCarros
    {
        private readonly LocalDbContext _local;

        public RepositorioCarros(LocalDbContext local)
        {
            _local = local;
        }

        public int Add(Carro request)
        {
            _local.carro.Add(request);
            _local.SaveChanges();
            return request.id;
        }
    }
}
