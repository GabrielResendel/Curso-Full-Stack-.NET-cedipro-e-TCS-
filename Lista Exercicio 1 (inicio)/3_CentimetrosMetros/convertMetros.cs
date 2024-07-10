// 3. Faça um programa que converta metros para centimetros (1 metro tem qunatos centimetros? pense nisso).

using System;

namespace ConvertMetrosCM
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("----CONVERTENDO METROS EM CENTIMETROS----");
          Console.Write("digite o numero de metros que deseja converter: ");
            double metros = Convert.ToDouble(Console.ReadLine());

              Console.WriteLine($"A quantidade de {metros} metros covertida em centimetros é: {metros * 100}");
        }
    }
}

