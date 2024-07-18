//  2 Faça um Programa que leia um vetor de 10 caracteres, e diga quantas consoantes foram lidas. Imprima as consoantes (Entenda que serão digitados somente letras do alfabeto sem acento).
using System;
namespace consoantes
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] Letras = new char[10];
            int cont = 0;
            

                Console.WriteLine("Digite 10 letras do alfabeto: ");
                for (int i = 0; i < 10; i++){
                    Letras[i] = char.Parse(Console.ReadLine());
                }


            Console.WriteLine($"\nForam Digitadas essas consoantes: ");

                for (int i = 0; i < 10; i++){

                    if(Letras[i] == 'a' || Letras[i] =='e'|| Letras[i] =='i'|| Letras[i] =='o'|| Letras[i] =='u'){
                        cont++;
                        Console.Write($"{Letras[i]} ");
                    }

                }
                
            Console.Write($"\nNo total foram {cont} consoantes digitadas!!");


        }
    }
}