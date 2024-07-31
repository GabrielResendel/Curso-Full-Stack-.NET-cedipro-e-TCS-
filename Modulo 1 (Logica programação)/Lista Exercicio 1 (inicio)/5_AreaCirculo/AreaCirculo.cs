
// 5. Faça um Programa que peça o raio de um círculo, calcule e mostre sua área (area do círculo = 3.14 * raio ao quadrado).
using System;

namespace AreaCirculo
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o raio do circulo: ");
                double raio = Convert.ToDouble(Console.ReadLine());
                double area = 3.14 * Math.Pow(raio, 2);

                Console.WriteLine("A area do circulo e de: " + area);
        }
    }
}