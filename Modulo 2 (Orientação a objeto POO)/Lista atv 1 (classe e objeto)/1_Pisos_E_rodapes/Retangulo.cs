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
        public double MudarValor(){
            return Convert.ToDouble(Console.ReadLine());
        }

        public void RetornarValor(){
            Console.WriteLine("Valores do retangulo: ");
            Console.Write($"Comprimento: {A}\n");
            Console.Write($"Largura: {B}");
            
        }

        public double CalcularArea(){
            return A * B;
            
        }

        public double CalcularPerimetro(){

            return 2 * (A + B);
        }
    }
}