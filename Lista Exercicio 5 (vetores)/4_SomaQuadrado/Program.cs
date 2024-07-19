//4. Faça um Programa que leia um vetor A com 10 números inteiros, calcule e mostre a soma dos quadrados dos elementos do vetor.
using System;
namespace SomaQuadrado
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] VetorA = new int[10];
            int soma = 0;

            Console.WriteLine("Digite 10 numeros inteiros e descubra sua soma ao quadrado: ");
            for (int i = 0;i < 10; i++){
                VetorA[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0;i < 10; i++){

                soma = VetorA[i] * VetorA[i];
                Console.WriteLine($"Soma do elemento {i+1} e: {soma}");
            }
        }
    }
}
