//2. Faça um programa que declare uma matriz de tamanho 5 × 5. Preencha com 1 a diagonal principal e com 0 os demais elementos. Ao final, escreva a matriz obtida na tela.
using System;
namespace MatrizDiagonal1
{
    class Program
    {
        static void Main(string[] args)
        {

        int[,] matriz = new int[5,5];
        int diagonal = 0;

            for (int i = 0; i < matriz.GetLength(0); i++){
                
                for (int j = 0;j < matriz.GetLength(1); j++){

                    if (i == diagonal && j == diagonal){
                        matriz[i,j]= 1;
                        diagonal++;
                    }else {
                        matriz[i,j] = 0;
                    }
                }
            }

        for (int i = 0;i < matriz.GetLength(0);i++){

            for (int j = 0;j < matriz.GetLength(1);j++){
                Console.Write($"{matriz[i,j]} ");
            }
            Console.WriteLine();
        }    

        }
    }
}
