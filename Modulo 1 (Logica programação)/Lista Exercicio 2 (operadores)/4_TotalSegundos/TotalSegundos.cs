// 4 Escreva um programa que leia a quantidade de dias, horas, minutos e segundos do usuário. Calcule o total em segundos. (1 minutos tem quantos segundos? 1 hora tem quantos minutos?)
using System;

namespace TotalSegundos
{
    class program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Calcule o total de segundos dizendo horas, minutos e segundos ");
            Console.Write("Horas: ");
            int hora = int.Parse(Console.ReadLine());
            int horaS = 3600 * hora;

            Console.Write("Minutos: ");
            int min = int.Parse(Console.ReadLine());
            int minS = 60 * min;

            Console.Write("Segundos: ");
            int seg = int.Parse(Console.ReadLine());

            int res = horaS + minS + seg;

        Console.WriteLine($"O total de segundo de {hora} Horas {min} Minutos {seg} Segundos é : {res}");   
    
        }
    }

}
