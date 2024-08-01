using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pisos_E_rodapes
{
    public class Retangulo
    {
        // Atributos
        public double A;
        public double B;


        // Metodos
        public void MudarValor(){
            Console.WriteLine("Digite o valor:");
            A = Convert.ToDouble(Console.ReadLine());
        }

        public void RetornarValor(){
            Console.WriteLine("Valores dos lados: ");
            Console.Write($"Lado A: {A}\n");
            Console.Write($"Lado B: {B}");
            
        }

        public double CalcularArea(){
            return A * B;
            
        }

        public double CalcularPerimetro(){

            return 2 * (A + B);
        }
    }
}