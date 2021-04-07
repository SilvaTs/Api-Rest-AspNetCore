using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2.Entities
{
    public class Carro
    {
        [Key]
        public int id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string combustivel { get; set; }
    }
}
