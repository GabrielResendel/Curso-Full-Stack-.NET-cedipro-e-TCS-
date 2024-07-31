// 2. Faça um programa que peça um numero e imprima o seu dobro.

using System;

namespace NumDobro
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.Write("Olá, digite um numero: ");
            double num = Convert.ToDouble(Console.ReadLine());
              Console.WriteLine($"O dobro de {num} é: {num * 2}");
        }
    }
}

