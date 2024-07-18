// 3 Faça um Programa que leia 20 números inteiros e armazene-os num vetor. Armazene os números pares no vetor PAR e os números IMPARES no vetor impar. Imprima os três vetores.
using System;
namespace VetorImparPar
{
    class Program
    {
        static void Main(string[] args)
        {

        int[] Vetor = new int[20];
        int contImpar = 0;
        int contPar = 0;

            Console.WriteLine("Digite 20 numeros inteiros: ");

            for (int i = 0; i < 20; i++){
                Vetor[i] = int.Parse(Console.ReadLine());
            }

                //contando o tamanho do vetor impar e par
                for (int i = 0;i < 20; i++){

                    if(Vetor[i] % 2 == 0){
                        contPar++;
                    }else {
                        contImpar++;
                    }
                }

        int[] Impar = new int[contImpar];
        int[] Par = new int[contPar];
        int IndexPar = 0;
        int IndexImpar = 0;
        
            //adicionando nos vetores
            for (int i = 0;i < 20; i++){

                if(Vetor[i] % 2 == 0){

                    Par[IndexPar] = Vetor[i];
                    IndexPar++;
                }else {

                    Impar[IndexImpar] = Vetor[i];
                    IndexImpar++;
                }
            }
            
        Console.Write ("\nOs valores digitados foram:");
        for(int i = 0;i < Vetor.Length; i++){
            Console.Write($"{Vetor[i]} ");
        }

        Console.WriteLine("\nOs numeros pares foram:");
        for(int i = 0;i < Par.Length; i++){
            Console.Write($"{Par[i]} ");
        }

        Console.WriteLine("\nOs numeros Impares foram: ");
        for(int i = 0;i < Impar.Length; i++){
            Console.Write($"{Impar[i]} ");
        }
    



        }
    }
}