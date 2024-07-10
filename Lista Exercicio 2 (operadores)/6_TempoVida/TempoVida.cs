// 6 Escreva um programa para calcular a redução do tempo de vida de um fumante. Pergunte a quantidade de cigarros fumados por dia e quantos anos ele já fumou. Considere que um fumante perde 10 minutos de vida a cada cigarro, calcule quantos dias de vida um fumante perderá. Exiba o total de dias.
using System;

namespace TempoVida
{
    class program
    {
        static void Main(string[] args)
        {
        Console.Write("Digite quantos cigarros você fuma por dia: ");
        double cigarroDia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite por quantos anos você fumou ou fuma: ");
        double anosFuma = Convert.ToDouble(Console.ReadLine());

            double menosMin = cigarroDia * 10;
            double minHoras = menosMin / 60;
            double dias = 24 / minHoras;

        Console.WriteLine($"Com o tempo fumando você perdeu o total de {dias} dias de vida!!");    

        }
    }
}