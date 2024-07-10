// 12  Uma revendedora de carros usados paga a seus funcionários vendedores um salário fixo por mês e mais 5% do valor das vendas por ele efetuadas. Escrever um algoritmo que leia o número de carros por ele vendidos, o valor do carro e o salário fixo.         Calcule e escreva o salário final do vendedor.
using System;

class Program
{
    static void Main(string[] args)
    {     
        Console.Write("Salário fixo do vendedor: R$ ");
        double salarioFixo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Número de carros vendidos: ");
        int carrosVendidos = int.Parse(Console.ReadLine());

        Console.Write("Valor de cada carro vendido: R$ ");
        double valorCarro = Convert.ToDouble(Console.ReadLine());

        double valorTotalVendas = carrosVendidos * valorCarro;

        double comissao = valorTotalVendas * 0.05;

        double salarioFinal = salarioFixo + comissao;

        Console.WriteLine("\nSalário final do vendedor: R$ " + salarioFinal.ToString("F2"));
    }
}

