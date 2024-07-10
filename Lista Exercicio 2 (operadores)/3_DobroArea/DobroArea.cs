// 3 Faça um Programa que calcule a área de um quadrado, em seguida mostre o dobro desta área para o usuário.
using System;
using System.Globalization;

namespace DobroArea
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.Write("Digite o tamanho de um lado do quadrado: ");
         double lado = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);
         double area = lado * lado;
         double dobro = area * 2;

         Console.WriteLine($"A sua aréa do quadrado é: {area} e seu dobro é: {dobro}");


        }
    }
}