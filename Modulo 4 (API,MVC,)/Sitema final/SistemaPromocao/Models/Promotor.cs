using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaPromocaoMVC.Models
{
    public abstract class Promotor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public string CartaoVisita { get; set; }
        public string Local { get; set; }

        public abstract void Promover();
    }

    public class ClubeITA : Promotor
    {
        public override void Promover()
        {
            // Implementação para ClubeITA
        }

        public void Vlog()
        {
            // Implementação para Vlog
        }

        public void Malhar()
        {
            // Implementação para Malhar
        }
    }

    public class ClubeSESC : Promotor
    {
        public override void Promover()
        {
            // Implementação para ClubeSESC
        }
    }
}
