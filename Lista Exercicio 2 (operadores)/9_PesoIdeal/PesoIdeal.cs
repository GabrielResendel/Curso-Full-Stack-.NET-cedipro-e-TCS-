// 9 Tendo como dados de entrada a altura de uma pessoa, construa um algoritmo que calcule seu peso ideal, usando a seguinte fórmula: (72,7 * altura) – 58
using System;
using System.Globalization;

namespace Name
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua altura e descubra seu peso ideal: ");
            double altura = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                double pesoIdeal = (72.7 * altura) - 58;

          Console.WriteLine($"Seu peso ideal e de: {(pesoIdeal).ToString("F2", CultureInfo.InvariantCulture)} KG");      
        }
    }
}