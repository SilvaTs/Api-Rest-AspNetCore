using Aula2.Context;
using Aula2.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace Aula2.Services
{
    public class CarroService : ICarroService
    {

        private readonly LocalDbContext _local;

        public CarroService(LocalDbContext local)
        {
            _local = local;
        }

        public bool AdicionarCarro(Carro carro)
        {
            _local.carro.Add(carro);
            _local.SaveChanges();
            return true;
        }

        public bool AtualizarCarro(Carro novoCarro)
        {
            _local.carro.Attach(novoCarro);
            _local.Entry(novoCarro).State = EntityState.Modified;
            _local.SaveChanges();
            return true;
        }

        public bool DeletarCarro(int id)
        {
            var objApagar = _local.carro.Where(d => d.id == id).FirstOrDefault();
            _local.carro.Remove(objApagar);
            _local.SaveChanges();
            return true;
        }

        public List<Carro> RetonarListaCarro()
        {
            return _local.carro.ToList();
        }

        public Carro RetornarCarroPorId(int id)
        {
            return _local.carro.Where(d => d.id == id).FirstOrDefault();
        }
    }
}
