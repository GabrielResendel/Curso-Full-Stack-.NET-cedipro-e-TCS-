// 1 Faça um programa que leia uma matriz de tamanho 4 × 4. Imprima na tela o maior valor contido nessa matriz e a sua localização (linha e coluna).
using System;
namespace Matriz4x4
{
    class Program
    {
        static void Main(string[] args)
        {

        int[,] matriz = new int[4,4];

            for (int linha = 0; linha < matriz.GetLength(0); linha++){

                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++){

                    Console.Write("Digite um valor: ");
                    matriz[linha,coluna] = int.Parse(Console.ReadLine());
                }
            }

        int max = 0;
        int posL = 0,posC = 0;

            for (int linha = 0;linha < matriz.GetLength(0); linha++){

                for(int coluna = 0;coluna < matriz.GetLength(1);coluna++){

                    if (matriz[linha,coluna] > max){
                        max = matriz[linha,coluna];
                        posL = linha;
                        posC = coluna;
                    }
                }
            }

        Console.WriteLine($"O maior numero da matriz e o: {max}");
        Console.WriteLine($"Ele se encontra na Linha {posL} Coluna {posC}");


        }
    }
}

