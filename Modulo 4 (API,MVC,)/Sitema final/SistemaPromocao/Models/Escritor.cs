using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaPromocaoMVC.Models
{
    public class Escritor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Biografia { get; set; }
        public string Tipo { get; set; }

        public void Escrever()
        {
            // Implementação do método
        }
    }

    public class EscritorBlog : Escritor
    {
        public void Vlog()
        {
            // Implementação do método Vlog específico para EscritorBlog
        }
    }

    public class EscritorLivro : Escritor
    {
        public void Vlog()
        {
            // Implementação do método Vlog específico para EscritorLivro
        }
    }
}
