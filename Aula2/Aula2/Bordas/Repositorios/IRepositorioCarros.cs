
using Aula2.Entities;
using System.Collections.Generic;

namespace Aula2.Bordas.Repositorios
{
    public interface IRepositorioCarros
    {
        public void Add(Carro request);
        public void Remove(int id);
        public void Update(Carro request);     
        public Carro RetornaPorId(int id);
        public List<Carro> RetornarListaCarros();
    }
}
