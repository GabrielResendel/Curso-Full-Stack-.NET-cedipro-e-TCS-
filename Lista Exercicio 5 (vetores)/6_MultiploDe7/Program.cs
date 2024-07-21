// 6. Faça um programa que preencha um vetor de tamanho 100 com os 100 primeiros números naturais que não são múltiplos de 7. Ao final, imprima esse vetor na tela.
using System;
namespace MultiploDe7
{
    class Program
    {
        static void Main(string[] args)
        {

        int[] vetor = new int[100];
        int Num = 0;
        int Index = 0;

            while (Index < 100)
            {
                if (Num % 7 != 0)
                {
                    vetor[Index] = Num;
                    Index++;
                }
                Num++;
            }

        foreach (int item in vetor)
        {
            Console.WriteLine(item);
        }
        }
    }
}