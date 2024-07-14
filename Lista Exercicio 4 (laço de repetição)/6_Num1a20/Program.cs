// 6  Faça um programa que imprima na tela os números de 1 a 20, um abaixo do outro. Depois modifique o programa para que ele mostre os números um ao lado do outro. 
using System;
namespace Num1a20
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"{i}");

            }
            for (int i = 1; i <= 20; i++)
            {
                Console.Write($"{i} ");

            }






        }
    }
}