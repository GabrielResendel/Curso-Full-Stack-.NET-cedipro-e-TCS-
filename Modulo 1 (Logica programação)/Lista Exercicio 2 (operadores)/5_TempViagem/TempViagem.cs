// 5 Calcule o tempo de uma viagem de carro. Pergunte a distância a percorrer e a velocidade média esperada para a viagem.
using System;
using System.Globalization;

namespace tempViagem
{
    class program{
        static void Main(string[] args)
        {
            Console.Write("Qual a distancia que vai percorrer: ");
            double dis = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("E qual será sua velocidade media? : ");
            double vel = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double res = dis / vel;

            Console.WriteLine($"Seu tempo estimado para chegar ao local é : {(res).ToString("F2", CultureInfo.InvariantCulture)} Horas e minutos");
        }
    }
}
