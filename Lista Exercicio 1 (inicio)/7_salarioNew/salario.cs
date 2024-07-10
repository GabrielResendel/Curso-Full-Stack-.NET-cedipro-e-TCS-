// 7. Escreva um algoritmo para ler o salário mensal atual de um funcionário e calcular e escrever o valor do novo salário com 12% de reajuste. 
using System;

namespace AjusteSalario
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu salario mensal: ");
               double salario = Convert.ToDouble(Console.ReadLine());
               double reajuste = salario * 0.12;
               double NovoSalario = salario + reajuste;

            Console.WriteLine($"Seu salario é: {salario} com o reajuste de 12% ele fica: {NovoSalario}");
        }
    }
}
