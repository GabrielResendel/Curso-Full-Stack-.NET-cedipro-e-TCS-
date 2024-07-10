using System;

namespace CustoCarro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de custo de fabrica do carro: ");
            double fabrica = Convert.ToDouble(Console.ReadLine());
            double SomaDistribuidor = fabrica * 0.28;
            double SomaImposto = fabrica * 0.45;
            double ValorFinal = fabrica + SomaImposto + SomaImposto;

            Console.WriteLine($"o valor final do carro ao consumidor e: {ValorFinal}");
        }
    }
}
