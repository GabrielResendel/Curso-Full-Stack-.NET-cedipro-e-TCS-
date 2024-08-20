using System;
using System.Collections.Generic;
using System.Linq;
namespace SistemaPromocao.Models
{
    public class Bodybuilder : IBodybuilders
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public void Malhar()
        {
            // Implementação do método Malhar
        }
    }

    public interface IBodybuilders
    {
        void Malhar();
    }
}
