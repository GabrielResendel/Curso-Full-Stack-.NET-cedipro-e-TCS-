// 2 Faça um Programa que peça 4 notas e mostre a média (10 + 10 + 10 + 10 / 4 tem que dar resultado 10).
using System;
using System.Globalization;

namespace MediaNota
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Diga as notas e some sua media!!");
            Console.Write("Digite a nota 1: ");
            double nota1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite a nota 1: ");
            double nota2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite a nota 1: ");
            double nota3 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite a nota 1: ");
            double nota4 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double res = (nota1 + nota2 + nota3 + nota4) / 4;

         Console.WriteLine($"A media das notas são: {(res).ToString("F2", CultureInfo.InvariantCulture)}");   
        }
    }
}
