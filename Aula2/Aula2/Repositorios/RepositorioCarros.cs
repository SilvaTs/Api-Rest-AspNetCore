using Aula2.Bordas.Repositorios;
using Aula2.Context;
using Aula2.Entities;
using System.Linq;

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

        public void Remove(int id)
        {
            var obj = _local.carro.Where(d => d.id == id).FirstOrDefault();
            if (obj == null)
            {
                throw new System.Exception();
            }
            _local.carro.Remove(obj);
            _local.SaveChanges();
        }
    }
}
