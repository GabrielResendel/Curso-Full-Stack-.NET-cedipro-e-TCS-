// 7- Faça um programa que leia 5 números e informe o maior número. 
using System;
namespace MaiorNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumMaior = 0;
            
            for (int i = 0;i < 5; i++){
                Console.Write("Digite um numero: ");
                int num = int.Parse(Console.ReadLine());

                if (num > NumMaior){
                    NumMaior = num;
                }

            }
            Console.WriteLine($"O numero maior e: {NumMaior}");


        }

    }
}
