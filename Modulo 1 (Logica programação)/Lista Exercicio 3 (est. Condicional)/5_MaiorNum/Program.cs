// 5. Faça um Programa que leia três números e mostre o maior deles (digite apenas números diferentes).
using System;
namespace NumMaior
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite outro numero: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Digite mais um numero: ");
            int num3 = int.Parse(Console.ReadLine());
            int maior = num1;

                if (num2 > maior){
                    maior = num2;
                }if(num3 > maior){
                    maior = num3;
                }
                
                 Console.WriteLine($"O maior numero eo {maior}");


        }
    }
}
