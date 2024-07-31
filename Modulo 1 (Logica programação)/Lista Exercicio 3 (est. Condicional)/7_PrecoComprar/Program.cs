// 7Faça um programa que pergunte o preço de três produtos e informe qual produto você deve comprar, sabendo que a decisão é sempre pelo mais barato
using System;
namespace Precomenor
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do produto 1: ");
            double prod1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor do produto 2: ");
            double prod2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor do produto 3: ");
            double prod3 = Convert.ToDouble(Console.ReadLine());

            double menor = prod1;

            if (prod2 < menor){
                menor = prod2;
            }if (prod3 < menor){
                menor = prod3;
            }

            Console.WriteLine($"O melhor preço eo de {menor}");
        }
    }
}    