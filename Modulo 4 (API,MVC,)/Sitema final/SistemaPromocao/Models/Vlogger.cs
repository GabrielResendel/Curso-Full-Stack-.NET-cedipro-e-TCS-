using Sytem;
using System.Collections.Generic;
using System.Linq;
namespace SistemaPromocaoMVC.Models
{
    public class Vlogger : IVlogger
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public void Vlog()
        {
            // Implementação do método Vlog
        }
    }

    public interface IVlogger
    {
        void Vlog();
    }
}
