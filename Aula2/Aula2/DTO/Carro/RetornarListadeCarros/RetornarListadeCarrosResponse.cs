

using System.Collections.Generic;

namespace Aula2.DTO.Carro.RetornarListadeCarros
{
    public class RetornarListadeCarrosResponse
    {
        public List<Aula2.Entities.Carro> carros { get; set; }
        public string msg { get; set; }
    }
}
