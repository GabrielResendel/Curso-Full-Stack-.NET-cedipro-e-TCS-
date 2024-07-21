/* 7. Em uma competição de salto em distância cada atleta tem direito a cinco saltos. O resultado do atleta será determinado pela média dos cinco valores. Você deve fazer um programa que receba o nome e as cinco distâncias alcançadas pelo atleta em seus saltos (armazenar em um vetor) e depois informe o nome, os saltos e a média dos saltos. A saída do programa deve ser conforme o exemplo abaixo:

Atleta: Rodrigo Curvêllo

Primeiro Salto: 6.5

Segundo Salto: 6.1

Terceiro Salto: 6.2

Quarto Salto: 5.4

Quinto Salto: 5.3

Resultado final:

Atleta: Rodrigo Curvêllo

Saltos: 6.5 - 6.1 - 6.2 - 5.4 - 5.3

Média dos saltos: 5.9 m */

using System;
namespace Distancia
{
    class Program
    {
        static void Main(string[] args)
        {

        Console.Write("Digite o nome do Atleta: ");
        string nome = Console.ReadLine();

        double[] saltos = new double[5];

            for (int i = 0; i < saltos.Length; i++)
            {
                Console.Write($"Salto {i + 1}: ");
                saltos[i] = double.Parse(Console.ReadLine());
            }

        double soma = 0;

            foreach (double salto in saltos)
            {
                soma += salto;
            }
            double media = soma / saltos.Length;

        
        Console.WriteLine($"\nResultado final:\n");
        Console.WriteLine($"Atleta: {nome}");
        Console.WriteLine($"Saltos: {string.Join(" - ", saltos)}");
        Console.WriteLine($"Média dos saltos: {media:F1} m");


        }
    }
}
