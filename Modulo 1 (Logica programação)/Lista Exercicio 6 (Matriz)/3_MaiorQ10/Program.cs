//3-Leia uma matriz de tamanho 4 × 4. Em seguida, conte e escreva na tela quantos valores maiores do que 10 ela possui.
using System;
namespace Maiorq10
{
    class Program
    {
        static void Main(string[] args)
        {

        int[,] matriz = new int[4,4];
        int count = 0;

            for (int i = 0;i < matriz.GetLength(0);i++){
                for (int j = 0;j < matriz.GetLength(1);j++){
                    Console.Write("Digite um valor para a matriz: ");
                    matriz[i,j] = int.Parse(Console.ReadLine());
                }
            }

        Console.WriteLine("Os valores maior que 10 são: ");

            for (int i = 0;i < matriz.GetLength(0); i++){

                for (int j = 0;j < matriz.GetLength(1); j++){

                    if(matriz[i,j] > 10){
                        
                        Console.Write($"{matriz[i,j]} ");
                        count++;
                    }
       
                }
            }

        Console.Write($"\nO total de numeros maior que 10 foram : {count}");


        }
    }
}
