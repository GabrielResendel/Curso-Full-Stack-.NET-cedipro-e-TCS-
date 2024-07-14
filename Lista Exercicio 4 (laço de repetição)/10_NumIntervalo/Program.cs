// 10 Faça um programa que receba dois números inteiros e gere os números inteiros que estão no intervalo compreendido por eles, ex: se o usuário digitar 1 e 5 imprimir na tela 2, 3 e 4 (números que estão entre 1 e 5).
using System;
namespace IntervaloNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero inteiro: ");
            int Num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite um numero inteiro: ");
            int Num2 = int.Parse(Console.ReadLine());

                
            int MenorNum, MaiorNum;

            if(Num1 < Num2){
                MenorNum = Num1;
                MaiorNum = Num2;

            }else {

                MenorNum = Num2;
                MaiorNum = Num1;

            }



                for (int i = MenorNum + 1; i < MaiorNum; i++){
                
                    Console.Write($"{i} ");
                
                }
               
                
        
        }
    }
}
