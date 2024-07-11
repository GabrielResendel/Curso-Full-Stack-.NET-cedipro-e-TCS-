// 1 Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido. 
using System;
namespace Nota0a10
{
    class programa
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite uma nota entre 0 a 10: ");
                double Nota = Convert.ToDouble(Console.ReadLine());

            while (Nota < 0 || Nota > 10)
            {
                Console.Write("Digite uma nota valida!: ");
                Nota = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine($"A nota e : {Nota}");
        }

    }
}
