//8- Faça um programa que leia 5 números e informe a soma e a média dos números
using System;
namespace SomaMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;

            for (int i = 0;i < 5; i++){
                Console.Write("Digite um numero: ");
                double num = Convert.ToDouble(Console.ReadLine());

                soma += num;
            }

            Console.WriteLine($"A soma dos numeros e de: {soma} \nA media os numeros e: {soma / 5}");
        }
    }
}
