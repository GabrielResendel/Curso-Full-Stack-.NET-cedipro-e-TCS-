// 1. Faça um Programa que peça um valor e mostre na tela se o valor é positivo ou negativo.
using System;

namespace PosiOuNega
{
    class Programa
    {
        static void Main(string[] args)
        {
        
        Console.Write("Digete um valor: ");
        int valor = int.Parse(Console.ReadLine());
        
        if(valor < 0){
            Console.WriteLine("o valor digitado e negativo!");
        }else {
            Console.WriteLine("o valor digitado e positivo!");
        }

        }
    }
}
