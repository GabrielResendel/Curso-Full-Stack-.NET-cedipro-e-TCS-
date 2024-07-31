// 2.Escreva um algoritmo para ler uma temperatura em graus Fahrenheit, calcular e escrever o valor correspondente em graus Celsius (baseado na fórmula abaixo): 

using System;

namespace ConversorDeGraus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero de graus Fahrenheit que deseja converter para graus Celsius: ");
            double GrauF = Convert.ToDouble(Console.ReadLine());
            double convert = GrauF - 32;

            Console.WriteLine($"A conversão de {GrauF} Fahrenheit para graus Celsius e de : {convert * 5/9}  ");
        }
    }
}