// 8 Faça um Programa que peça 2 números inteiros (int) e um número real (double). Calcule e mostre:a. o produto do dobro do primeiro com metade do segundo.b. a soma do triplo do primeiro com o terceiro.C. o terceiro elevado ao cubo.
using System;
using System.Globalization;

namespace SomaDeNumeros
{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero inteiro: ");
            int int1 = int.Parse(Console.ReadLine());

            Console.Write("Digite outro numero inteiro: ");
            int int2 = int.Parse(Console.ReadLine());

            Console.Write("Digite um numero decimal: ");
            double dec1 = Convert.ToDouble(Console.ReadLine());

                int a = (int1 * 2) + (int2 / 2);
                double b = (int1 * 3) + dec1;
                double c = (dec1 * dec1) * dec1;

           Console.WriteLine($"a) soma do dobro do numero 1 com a metade do numero 2: {a}");
           Console.WriteLine($"b) o triplo do numero 1 + o numero 3: {b}"); 
           Console.WriteLine($"c) o terceiro numero elevado ao cubo: {c}");    
        }
    }
}