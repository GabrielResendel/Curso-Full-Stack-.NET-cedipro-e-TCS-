// 4. Escreva um algoritmo para ler as dimensões de um quadrado e mostre sua área (base * altura ou base ).
using System;

namespace LerDimensão
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho de um lado do quadrado: ");
                double lado = Convert.ToDouble(Console.ReadLine());

                double dimen = lado * lado;

                Console.WriteLine("A dimensão do quadrado e: " + dimen);


        }
    }
}