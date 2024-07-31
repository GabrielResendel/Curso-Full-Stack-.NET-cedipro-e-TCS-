// 1 Faça um Programa que leia um vetor de 10 números reais e mostre-os na ordem inversa.
using System;
namespace ValorInverso
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] Vetor = new int[10];
            
            Console.WriteLine("Digite 10 numeros inteiros: ");
            for (int i = 0; i < 10; i++){
                Vetor[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Seus numeros na ordem iversa e: ");

            for(int i = 9; i >= 0; i--){

                Console.Write($"{Vetor[i]} ");
            }

        }
    }
}
