// 7 Faça um Programa que pergunte quanto você ganha por hora e o número de horas trabalhadas no mês. Calcule e mostre o total do seu salário no referido mês.
using System;

namespace TotalSalario
{
    class Programa
    {
        static void Main(string[] args)
        {
        
        Console.Write("Digite quanto você ganha por hora: ");
        double valorH = Convert.ToDouble(Console.ReadLine());

         Console.Write("Digite quantas horas você trabalhou no mês: ");
        double horasTrab = Convert.ToDouble(Console.ReadLine());

        double salario = horasTrab * valorH;

        Console.WriteLine($"Seu salario no mês e de: {salario}");


        }
    }
}

