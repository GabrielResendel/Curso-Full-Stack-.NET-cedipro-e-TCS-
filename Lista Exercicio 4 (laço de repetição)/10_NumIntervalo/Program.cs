// 10 Faça um programa que receba dois números inteiros e gere os números inteiros que estão no intervalo compreendido por eles, ex: se o usuário digitar 1 e 5 imprimir na tela 2, 3 e 4 (números que estão entre 1 e 5).
using System;
namespace IntervaloNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero inteiro: ");
            int Num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite um numero inteiro: ");
            int Num2 = int.Parse(Console.ReadLine());

                
                for (int i = Num1 - 1; Num1 < Num2; Num1++){
                    Console.Write($"{i++}");
                }
                    
                
        
        }
    }
}
