// 13 Faça um algoritmo que leia três notas de um aluno, calcule e escreva a média final deste aluno. Considerar que a média é ponderada e que o peso das notas é 2, 3 e 5. Fórmula para o cálculo da média é:dfs
using System;
namespace NotaMedia
{
    class programa
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a nota 1: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

             Console.Write("Digite a nota 2: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

             Console.Write("Digite a nota 3: ");
            double n3 = Convert.ToDouble(Console.ReadLine());

                double peso1 = n1 * 2;
                double peso2 = n2 * 3;
                double peso3 = n3 * 5;
                double media = (peso1 + peso2 + peso3) / 10;

             Console.WriteLine($"A media das notas é: {media}");

        }
    }
}
