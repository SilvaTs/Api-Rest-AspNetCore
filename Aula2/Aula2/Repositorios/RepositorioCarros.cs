using Aula2.Bordas.Repositorios;
using Aula2.Context;
using Aula2.Entities;
using System.Collections.Generic;
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

        public void Add(Carro request)
        {
            _local.carro.Add(request);
            _local.SaveChanges();
          
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

        public void Update(Carro request)
        {
            _local.carro.Attach(request);
            _local.Entry(request).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _local.SaveChanges();
        }
        public Carro RetornaPorId(int id)
        {
            foreach (Carro carros in _local.carro)
            {
                if (carros.id.Equals(id))
                {
                    return carros;
                }
            }
            return null;
        }

        public List<Carro> RetornarListaCarros()
        {
            return _local.carro.ToList();

        }

    }
}
